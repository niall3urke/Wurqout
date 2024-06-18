using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Wurqout.Code.Workout
{
    public class WorkoutTimer
    {

        // Fields - readonly

        private readonly List<WorkoutBlock> blocks;

        private readonly IJSRuntime js;

        // Fields

        private CancellationTokenSource pauseTokenSource;

        // Actions 

        public Action<WorkoutBlock> BlockChanged { get; set; }

        public Action<int> TimeChanged { get; set; }

        public Action Completed { get; set; }

        // Properties

        public WorkoutBlock CurrentBlock { get; set; }

        public bool Paused { get; set; }

        public bool Cancel { get; set; }

        // Constructors

        public WorkoutTimer(List<WorkoutBlock> blocks, IJSRuntime js)
        {
            this.blocks = blocks;
            this.js = js;
        }

        // Methods - public

        public async Task Start()
        {
            await CreateAudio();

            foreach (var block in blocks)
            {
                BlockChanged.Invoke(block);

                if (block.IsTimed)
                {
                    await Countdown(block.Duration);
                }
                else
                {
                    TimeChanged.Invoke(block.NumReps);
                    Paused = true;
                    await Pause();
                }


                if (Cancel)
                    return;
            }
            await DisposeAudio();

            Completed.Invoke();
        }

        public async Task Pause()
        {
            pauseTokenSource = new CancellationTokenSource();
            bool isWaiting = true;

            while (isWaiting)
            {
                try
                {
                    // Delay is capped to 16.67 minutes
                    await Task.Delay(1000000, pauseTokenSource.Token);
                }
                catch (TaskCanceledException)
                {
                    isWaiting = false;
                }
            }
        }

        public void Play()
        {
            if (pauseTokenSource != null)
            {
                pauseTokenSource.Cancel();
            }
        }

        // Methods - private

        private async Task Countdown(int duration)
        {
            var interval = new TimeSpan(0, 0, 1);
            var nextTick = DateTime.Now + interval;
            for (int i = duration; i > 0; i--)
            {
                long pauseOffset = 0;

                if (Cancel)
                    return;

                if (Paused)
                {
                    var timer = new Stopwatch();
                    timer.Start();
                    await Pause();
                    timer.Stop();
                    pauseOffset = timer.ElapsedTicks;
                }

                TimeChanged.Invoke(i);

                if (i < 2)
                {
                    await Tone2();
                }
                else if (i < 3)
                {
                    await Tone1();
                }
                else if (i < 4)
                {
                    await Tone1();
                }

                nextTick = nextTick.AddTicks(pauseOffset);

                while (DateTime.Now < nextTick)
                {
                    await Task.Delay(nextTick - DateTime.Now);
                }

                nextTick += interval;
            }
        }

        private async Task CreateAudio() =>
           await js.InvokeVoidAsync("createAudio");

        private async Task DisposeAudio() =>
            await js.InvokeVoidAsync("disposeAudio");

        private async Task Tone1() =>
            await js.InvokeVoidAsync("tone1");

        private async Task Tone2() =>
            await js.InvokeVoidAsync("tone2");

    }
}
