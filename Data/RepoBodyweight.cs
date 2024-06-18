using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wurqout.ViewModels;

namespace Wurqout.Data
{

    // Source: https://www.self.com/gallery/bodyweight-exercises-you-can-do-at-home

    public class RepoBodyweight
    {

        // Properties

        private static List<Exercise> MountainClimbers { get; set; }

        private static List<Exercise> LegReaches { get; set; }

        private static List<Exercise> HighKnees { get; set; }

        private static List<Exercise> LegRaises { get; set; }

        private static List<Exercise> Movements { get; set; }

        private static List<Exercise> Crunches { get; set; }

        private static List<Exercise> PushUps { get; set; }

        private static List<Exercise> Burpees { get; set; }

        private static List<Exercise> Planks { get; set; }

        private static List<Exercise> Squats { get; set; }

        private static List<Exercise> Lunges { get; set; }

        private static List<Exercise> Glutes { get; set; }

        // Methods: static

        public static List<Exercise> Fetch()
        {
            Initialize();

            var exercises = new List<Exercise>();
            exercises.AddRange(MountainClimbers);
            exercises.AddRange(LegReaches);
            exercises.AddRange(HighKnees);
            exercises.AddRange(Movements);
            exercises.AddRange(LegRaises);
            exercises.AddRange(Crunches);
            exercises.AddRange(PushUps);
            exercises.AddRange(Burpees);
            exercises.AddRange(Squats);
            exercises.AddRange(Lunges);
            exercises.AddRange(Glutes);
            exercises.AddRange(Planks);
            return exercises;
        }

        // Methods: private

        private static void Initialize()
        {
            MountainClimbers ??= GetMountainClimbers();
            LegReaches ??= GetLegReaches();
            HighKnees ??= GetHighKnees();
            Movements ??= GetMovement();
            LegRaises ??= GetLegRaises();
            LegRaises ??= GetLegRaises();
            Crunches ??= GetCrunches();
            PushUps ??= GetPushUps();
            Burpees ??= GetBurpees();
            Squats ??= GetSquats();
            Lunges ??= GetLunges();
            Planks ??= GetPlanks();
            Glutes ??= GetGlutes();
        }

        private static List<Exercise> GetSquats()
        {
            var a = new Exercise("Squats")
            {
                PrimaryGroup = MuscleGroup.Quads,
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/59c81783bdd6c02d85791296/master/w_1600%2Cc_limit/Fitness_08.gif",
                Difficulty = 0,
                Family = Family.Squat,
                IsCardio = true,
                Steps = new[]
                {
                    "Stand with your feet about shoulder-width apart and slightly turned out with your weight in your heels.",
                    "Hinge your hips to sit your butt back and bend your knees until your thighs are parallel to the ground.",
                    "Drive through your heels to stand back up straight. Squeeze your butt and keep your core tight as you stand."
                }
            };
            var b = new Exercise("Squat Jumps")
            {
                PrimaryGroup = MuscleGroup.Quads,
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/57d8843650778cef321a440a/master/w_1200%2Cc_limit/SQUAT_JUMP.gif",
                Difficulty = 3,
                Family = Family.Squat,
                IsCardio = true,
                Steps = new[]
                {
                    "Stand with your feet slightly wider than hip-distance apart.",
                    "Sit your butt back and bend your knees to drop into a squat, keeping your chest upright.",
                    "Jump up into the air as high as you can and straighten out your legs.",
                    "Land back on the floor with soft knees."
                }
            };
            var c = new Exercise("Squat Jacks")
            {
                PrimaryGroup = MuscleGroup.Quads,
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/582ca2515950e5b245aca70e/master/w_1200%2Cc_limit/SQUAT_JACKS.gif",
                Difficulty = 3,
                Family = Family.Squat,
                IsCardio = true,
                Steps = new[]
                {
                    "Start standing with your feet together, hands at your chest.",
                    "Jump your feet out and sit back into a small squat.",
                    "Jump your feet back together to return to standing."
                }
            };
            var d = new Exercise("Side Step Squats")
            {
                PrimaryGroup = MuscleGroup.Quads,
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/57aa0087d077f2273cf20474/master/w_1200%2Cc_limit/SIDE_STEP_SQUAT.gif",
                Difficulty = 1,
                Family = Family.Squat,
                IsCardio = true,
                Steps = new[]
                {
                    "Stand tall with your feet together and hands on your hips.",
                    "Step your right foot to the right, so your feet are just wider than shoulder-width apart.",
                    "Drop your butt back and bend your knees to lower into a squat.",
                    "Straighten your knees and bring your foot back to the starting position.",
                    "Repeat on the other side."
                }
            };
            var e = new Exercise("Split Squat")
            {
                PrimaryGroup = MuscleGroup.Quads,
                FocusArea = FocusArea.Lowerbody,
                Difficulty = 2,
                IsCardio = true,
                Family = Family.Squat,
            };
            var f = new Exercise("Squat Pulse")
            {
                PrimaryGroup = MuscleGroup.Quads,
                FocusArea = FocusArea.Lowerbody,
                Difficulty = 2,
                Family = Family.Squat,
                IsCardio = true,
            };
            var g = new Exercise("Squat Pulse with One Foot Raised")
            {
                PrimaryGroup = MuscleGroup.Quads,
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/581614aa3e931a7a5ad87cb9/master/w_1200%2Cc_limit/PLIE_ONE_FOOT_RAISED.gif",
                Difficulty = 3,
                Family = Family.Squat,
                IsCardio = true,
                Steps = new[]
                {
                    "Start standing with your feet wide and your toes slightly turned out.",
                    "Bend your knees into a slight squat and lift your left heel so you’re on your toes. Keep your right foot flat on the ground.",
                    "Lower your butt a few inches toward the ground while keeping your chest up. Continue pulsing up and down.",
                    "Repeat on the other side."
                }
            };
            var h = new Exercise("Wall Sit")
            {
                PrimaryGroup = MuscleGroup.Quads,
                FocusArea = FocusArea.Lowerbody,
                Difficulty = 2,
                Family = Family.Squat,
                IsCardio = true,
            };
            return new List<Exercise> { a, b, c, d, e, f, g, h };
        }

        private static List<Exercise> GetLunges()
        {
            var a = new Exercise("Lunges")
            {
                PrimaryGroup = MuscleGroup.Quads,
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/59c81a69bdd6c02d8579129c/master/w_1200%2Cc_limit/Fitness_06.gif",
                Difficulty = 0,
                Family = Family.Lunge,
                IsCardio = true,
                Steps = new[]
                {
                    "Stand with your feet together.",
                    "Take a big step forward with your right foot. Bend your right leg until your front thigh is parallel to the floor and your back knee is just barely touching the floor.",
                    "Push up through your back front heel to return to the start position.",
                    "Repeat on the other side."
                }
            };
            var b = new Exercise("Side Lunges")
            {
                PrimaryGroup = MuscleGroup.Quads,
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/59c810babdd6c02d85791294/master/w_1200%2Cc_limit/062917_fitness_18.gif",
                Difficulty = 0,
                Family = Family.Lunge,
                IsCardio = true,
                Steps = new[]
                {
                    "Stand with your feet hip-width apart.",
                    "Take a big step out to your right. Bend your knee and push your butt back to do a side lunge. Keep your chest lifted and core tight.",
                    "Repeat on the other side."
                }
            };
            var c = new Exercise("Reverse Lunges")
            {
                PrimaryGroup = MuscleGroup.Quads,
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/57ee8dbb3429de5367e0b6cf/master/w_1600%2Cc_limit/REVERSE_LUNGE.gif",
                Difficulty = 0,
                Family = Family.Lunge,
                IsCardio = true,
                Steps = new[]
                {
                    "Start standing with your feet about shoulder-width apart.",
                    "Step backwards with your left foot, landing on the ball of your foot and bending your knees to create two 90-degree angles.",
                    "Push through your right heel to return to standing.",
                    "Repeat on the other side."
                }
            };
            var d = new Exercise("Curtsey Lunges with Side Kick")
            {
                PrimaryGroup = MuscleGroup.Quads,
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/57aa007a5b248dd83bbb1737/master/w_1200%2Cc_limit/CURTSY_LUNGE_SIDEKICK.gif",
                Difficulty = 1,
                Family = Family.Lunge,
                IsCardio = true,
                Steps = new[]
                {
                    "Stand tall with your feet hip-width apart.",
                    "Step your left leg diagonally behind your right leg and bend your knees to lower into a lunge.",
                    "Push through your right heel to stand, and sweep your left leg out to the side.",
                    "Repeat on the other side."
                }
            };
            var e = new Exercise("Jumping Lunges")
            {
                PrimaryGroup = MuscleGroup.Quads,
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/59c82042bdd6c02d857912a0/master/w_800%2Cc_limit/15.gif",
                Family = Family.Lunge,
                Difficulty = 3,
                IsCardio = true,
                Steps = new[]
                {
                    "Start in a lunge with your left leg forward, hands at your sides. Bend both knees to 90 degrees, keeping your abs tight and back straight.",
                    "Swing arms to propel your body up, straightening your legs. Land back in a lunge and continue jumping.",
                    "Repeat on the other side."
                }
            };
            var f = new Exercise("Power Lunges")
            {
                PrimaryGroup = MuscleGroup.Quads,
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/57a206519f633566420fe542/master/w_1200%2Cc_limit/POWER_LUNGE.gif",
                Difficulty = 2,
                Family = Family.Lunge,
                IsCardio = true,
                Steps = new[]
                {
                    "Stand with your feet hip-width apart.",
                    "Lunge back with your right foot, bending both knees 90 degrees.",
                    "Straighten your left leg and jump into the air while driving your right knee up in front of your body.",
                    "Immediately lower your right foot back into a lunge.",
                    "Repeat on the other side."
                }
            };
            var g = new Exercise("Reverse Lunge to High Kick")
            {
                PrimaryGroup = MuscleGroup.Quads,
                FocusArea = FocusArea.Lowerbody,
                Difficulty = 1,
                Family = Family.Lunge,
                IsCardio = true,
            };
            var h = new Exercise("Forward to Reverse Lunge")
            {
                PrimaryGroup = MuscleGroup.Quads,
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/59638f33427847455e70cfef/master/w_1200%2Cc_limit/062917_fitness_05.gif",
                Difficulty = 2,
                Family = Family.Lunge,
                IsCardio = true,
                Steps = new[]
                {
                    "Stand with your feet hip-width apart.",
                    "Step forward with your left foot into a forward lunge, with both knees bent so that your knees so that the front thigh is parallel to the floor and the back knee is about two inches from the floor.",
                    "Push off your front foot, hover your foot as you stand straight up, and immediately step back into a reverse lunge.",
                    "Drive through your front foot to stand back up"
                }
            };
            return new List<Exercise> { a, b, c, d, e, f, g, h };
        }

        private static List<Exercise> GetGlutes()
        {
            var a = new Exercise("Glute Bridge")
            {
                PrimaryGroup = MuscleGroup.Glutes,
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/57aa0081d077f2273cf20473/master/w_1200%2Cc_limit/HIP_BRIDGE.gif",
                Difficulty = 0,
                Family = Family.GluteRaise,
                IsCardio = true,
                Steps = new[]
                {
                    "Start lying flat on your back, your knees bent and your heels a few inches away from your butt. Your feet should be about hip-distance apart.," +
                    "Lift your hips up, then lower them back to the ground."
                }
            };
            var b = new Exercise("Marching Glute Bridge")
            {
                PrimaryGroup = MuscleGroup.Glutes,
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/57ebed4f1dda7f545cbd714d/master/w_1600%2Cc_limit/MarchingGluteBridge.gif",
                Difficulty = 1,
                Family = Family.GluteRaise,
                IsCardio = true,
                Steps = new[]
                {
                    "Lie faceup on your mat with your knees bent and feet flat on the floor. Lift your hips off the mat into a bridge.",
                    "Keeping your right knee bent, lift your right foot off the floor. Try to keep your hips still.",
                    "Hold for five seconds. Slowly lower your right foot to the ground but keep your hips lifted.",
                    "Lift your left foot off the ground to repeat on the other side."
                }
            };
            var c = new Exercise("Single Leg Glute Bridges")
            {
                PrimaryGroup = MuscleGroup.Glutes,
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/59c810b2b2227d7913413b7f/master/w_1200%2Cc_limit/062917_fitness_17.gif",
                Difficulty = 2,
                Family = Family.GluteRaise,
                IsCardio = true,
                Steps = new[]
                {
                    "Lie on your back with your knees bent and feet flat on the floor.",
                    "Lift your left leg straight up above you, toes pointing at the ceiling. Your left knee should be directly over your left hip.",
                    "Raise your hips and lower them back to the ground, keeping your leg in the air.",
                    "Repeat on the other side."
                }
            };
            return new List<Exercise> { a, b, c };
        }

        private static List<Exercise> GetMountainClimbers()
        {
            var a = new Exercise("Mountain Climbers")
            {
                FocusArea = FocusArea.Wholebody,
                ImageUrl = "https://media.self.com/photos/5817a88e6839af65340d5371/master/w_1200%2Cc_limit/MOUNTAIN_CLIMBERS.gif",
                Difficulty = 0,
                Family = Family.Climber,
                IsCardio = true,
                Steps = new[]
                {
                    "Start in a high plank and draw your right knee under your torso, keeping your toes off the ground.",
                    "Return your right foot to the starting position.",
                    "Switch legs and bring your left knee under your chest. Keep switching legs as if you're running in place."
                }
            };
            var b = new Exercise("Spider-Man Mountain Climbers")
            {
                FocusArea = FocusArea.Wholebody,
                ImageUrl = "https://media.self.com/photos/597a5def35f46850de30260e/master/w_1200%2Cc_limit/knee-to-arms.gif",
                Difficulty = 2,
                Family = Family.Climber,
                IsCardio = true,
                Steps = new[]
                {
                    "Start in a high plank.",
                    "Drive your right knee out and up toward your right tricep. As you do, turn your head to watch your knee meet your arm.",
                    "Alternate sides as fast as you can while still maintaining a sturdy plank and keeping your torso in place."
                }
            };
            var c = new Exercise("Trunk Rotations")
            {
                FocusArea = FocusArea.Wholebody,
                ImageUrl = "https://media.self.com/photos/59c8199f3b781d294ccafdca/master/w_1200%2Cc_limit/Untitled-10.gif",
                Difficulty = 1,
                Family = Family.Climber,
                IsCardio = true,
                Steps = new[]
                {
                    "Start in a high plank with your core engaged.",
                    "Bring your left knee underneath your body toward your right elbow by twisting your torso slightly.",
                    "Repeat the movement alternating sides."
                }
            };
            return new List<Exercise> { a, b, c };
        }

        private static List<Exercise> GetCrunches()
        {
            var a = new Exercise("Sit-Ups")
            {
                FocusArea = FocusArea.Core,
                Difficulty = 0,
                Family = Family.Crunch,
                IsCardio = true,
            };
            var b = new Exercise("Crunches")
            {
                FocusArea = FocusArea.Core,
                Difficulty = 1,
                Family = Family.Crunch,
                IsCardio = true,
            };
            var c = new Exercise("Russian Twists")
            {
                FocusArea = FocusArea.Core,
                Difficulty = 2,
                Family = Family.Crunch,
                IsCardio = true,
            };
            var d = new Exercise("Bicycle Crunches")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/59c816bcea81f306765b2882/master/w_1200%2Cc_limit/move9%2520(1).gif",
                Difficulty = 2,
                Family = Family.Crunch,
                IsCardio = true,
                Steps = new[]
                {
                    "Sit on floor with your knees bent, feet lifted, and your hands behind head.",
                    "Keep your chest up and back straight as you lean back to engage your abs.",
                    "Twist to bring your right elbow to your left knee, straightening your right leg.",
                    "Alternate sides with control."
                }
            };
            var e = new Exercise("Bird Dog Crunches")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/59c8187d41062372cfaba034/master/w_1200%2Cc_limit/Fitness_12.gif",
                Difficulty = 1,
                Family = Family.Crunch,
                IsCardio = true,
                Steps = new[]
                {
                    "Start on your hands and knees in tabletop position with your wrists above your shoulders and your knees below your hips.",
                    "Inhale and extend your right arm forward and left leg back, maintaining a flat back and keeping your hips in line with the floor.",
                    "Squeeze your abs and exhale as you draw your right elbow to your left knee.",
                    "Extend back out to start."
                }
            };
            var f = new Exercise("Sit-Ups to Twists")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/59c81ab5b2227d7913413b85/master/w_800%2Cc_limit/Untitled-7.gif",
                Difficulty = 1,
                Family = Family.Crunch,
                IsCardio = true,
                Steps = new[]
                {
                    "Lie on your back with your knees bent and feet flat to the floor.",
                    "Place your hands behind your head, engage your core and do a full sit-up. At the top of the sit-up, bring your right elbow to your left knee and twist your body toward that side.",
                    "Lower back down to start.",
                    "Repeat this movement alternating sides each time."
                }
            };
            var g = new Exercise("Alternating Knee to Chest")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/59c8184bbdd6c02d8579129a/master/w_1200%2Cc_limit/move3.gif",
                Difficulty = 0,
                Family = Family.Crunch,
                IsCardio = true,
                Steps = new[]
                {
                    "Lie on your back and extend one leg out a few inches off the ground. Hold the opposite knee into your chest.",
                    "Switch legs, bringing your nose to the knee that is in toward your chest each time.",
                    "Keep your lower back down, head lifted off the ground, and abs engaged."
                }
            };
            var h = new Exercise("Standing Oblique Crunches")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/57fe5cd2aaf6a14302f41c41/master/w_1200%2Cc_limit/STANDING_OBLIQUE_CRUNCH%2520(1).gif",
                Difficulty = 0,
                Family = Family.Crunch,
                IsCardio = true,
                Steps = new[]
                {
                    "Stand with your feet hip-width apart and hands behind your head and elbows wide.",
                    "Lift your left knee toward your left elbow while you bend your torso up and over to the left.",
                    "Repeat on the other side."
                }
            };
            var i = new Exercise("Supermans")
            {
                FocusArea = FocusArea.Core,
                Difficulty = 1,
                Family = Family.Crunch,
                IsCardio = true,
            };
            var j = new Exercise("Hollow Rocks")
            {
                FocusArea = FocusArea.Core,
                Difficulty = 2,
                Family = Family.Crunch,
                IsCardio = true,
            };
            var k = new Exercise("Down Dog Abs")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/5786a09f737bb3be07fb9605/master/w_1200%2Cc_limit/Down_Dog_Series.gif",
                Difficulty = 2,
                Family = Family.Crunch,
                IsCardio = true,
                Steps = new[]
                {
                    "Start in down dog and lift your right leg into the air. This is your down dog split position (also known as three-legged down dog).",
                    "Bring your right knee under your torso. Pause then extend your right leg back to down dog split.",
                    "Now bring your right knee to meet your right elbow. Pause then extend your right leg back to down dog split.",
                    "Finally, bring your right knee across your torso to meet your left elbow. Pause then extend right leg back to down dog split.",
                    "Repeat the same sequence on the other side."
                }
            };
            return new List<Exercise> { a, b, c, d, e, f, g, h, i, j, k };
        }

        private static List<Exercise> GetPushUps()
        {
            var a = new Exercise("Push-Ups")
            {
                FocusArea = FocusArea.Upperbody,
                ImageUrl = "https://media.self.com/photos/59a6e77a912f8b75cea00753/master/w_1200%2Cc_limit/13.gif",
                Difficulty = 0,
                Family = Family.Pushup,
                IsCardio = true,
                Steps = new[]
                {
                    "Start in a high plank position with your hands flat on the floor about shoulder-width apart, wrists under shoulders.",
                    "Keeping your body in one long line, bend your arms and lower yourself as close to the floor as you can. Your elbows should be at about a 45-degree angle to your torso.",
                    "Push back up to start."
                }
            };
            var b = new Exercise("Wide Grip Push-Ups")
            {
                FocusArea = FocusArea.Upperbody,
                ImageUrl = "https://media.self.com/photos/59a6e786d0a3e87c2f5010a5/master/w_1200%2Cc_limit/20.gif",
                Difficulty = 0,
                Family = Family.Pushup,
                IsCardio = true,
                Steps = new[]
                {
                    "Start in a high plank position with your hands flat on the floor a little bit wider than shoulder-width apart, wrists under shoulders.",
                    "Keeping your body in one long line, bend your arms and lower yourself as close to the floor as you can.",
                    "Push back up to start."
                }
            };
            var c = new Exercise("Diamond Push-Ups")
            {
                FocusArea = FocusArea.Upperbody,
                ImageUrl = "https://media.self.com/photos/57f3b9875f7bf9bb45db3948/master/w_1200%2Cc_limit/DiamondPushup.gif",
                Difficulty = 2,
                Family = Family.Pushup,
                IsCardio = true,
                Steps = new[]
                {
                    "Start in a high plank. Walk your hands together so that your thumbs and forefingers form a triangle.",
                    "Bend your elbows to lower your chest and torso toward the floor and then push back up.",
                }
            };
            var d = new Exercise("Close Grip Push-Ups")
            {
                FocusArea = FocusArea.Upperbody,
                ImageUrl = "https://media.self.com/photos/59a6e77a912f8b75cea00753/master/w_1200%2Cc_limit/13.gif",
                Difficulty = 1,
                Family = Family.Pushup,
                IsCardio = true,
            };
            return new List<Exercise> { a, b, c, d };
        }

        private static List<Exercise> GetBurpees()
        {
            var a = new Exercise("Burpees")
            {
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/5943fddc4e4e9b6122499b42/master/w_1200%2Cc_limit/burpees6.gif",
                Difficulty = 4,
                Family = Family.Burpee,
                IsCardio = true,
                Steps = new[]
                {
                    "Stand with your feet shoulder-width apart, arms by your sides.",
                    "Bend your knees and reach forward to place your hands on the floor.",
                    "Kick your legs straight out behind you and immediately lower your entire body down to the ground, bending at the elbows.",
                    "Use your arms to quickly push your body back up and hop your legs back under your body.",
                    "Jump straight up into the air, reaching your arms overhead. End with your knees slightly bent."
                }
            };
            var b = new Exercise("Froggers")
            {
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/59c805ebea81f306765b2880/master/w_1200%2Cc_limit/FROGGER1%2520(1).gif",
                Difficulty = 0,
                Family = Family.Burpee,
                IsCardio = true,
                Steps = new[]
                {
                    "Stand with your legs wider than hip-width apart, knees bent, and upper body hinged slightly forward.",
                    "Place your hands on the ground in front of you, then jump your straight legs back into a high plank.",
                    "Jump your feet to the outsides of your hands and bring your hands toward your chest to return to the starting position."
                }
            };
            var c = new Exercise("Walkouts")
            {
                FocusArea = FocusArea.Upperbody,
                Difficulty = 1,
                Family = Family.Burpee,
                IsCardio = true,
            };
            var d = new Exercise("Single Leg Walkouts")
            {
                FocusArea = FocusArea.Upperbody,
                Difficulty = 2,
                Family = Family.Burpee,
                IsCardio = true,
            };
            var e = new Exercise("Walkouts with Push-Up")
            {
                FocusArea = FocusArea.Upperbody,
                Difficulty = 3,
                Family = Family.Burpee,
                IsCardio = true,
            };
            var f = new Exercise("Single Leg Walkouts with Push-Up")
            {
                FocusArea = FocusArea.Upperbody,
                ImageUrl = "https://media.self.com/photos/59c8209cb2227d7913413b87/master/w_1200%2Cc_limit/13.gif",
                Difficulty = 4,
                Family = Family.Burpee,
                IsCardio = true,
                Steps = new[]
                {
                    "Start with your feet hip-width apart, hands at sides. Lift your left leg slightly off the ground.",
                    "Bend at your hips to reach hands to floor and crawl out to a high plank, keeping your left leg hovering off the ground.",
                    "With shoulders over wrists and abs engaged, do a push-up.",
                    "Crawl your hands back to your feet and stand.",
                    "Repeat on the other side."
                }
            };
            return new List<Exercise> { a, b, c, d, e, f };
        }

        private static List<Exercise> GetPlanks()
        {
            var a = new Exercise("Plank")
            {
                FocusArea = FocusArea.Core,
                Difficulty = 0,
                Family = Family.Plank,
                IsCardio = true,
            };
            var b = new Exercise("Plank Ups")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/57eacd33fc07bf4a790d3269/master/w_1200%2Cc_limit/Plank_Ups-new.gif",
                Difficulty = 2,
                Family = Family.Plank,
                IsCardio = true,
                Steps = new[]
                {
                    "Start in a high plank. Bend one arm to bring the elbow and forearm to the floor.",
                    "Bring the other arm down so you are in a forearm plank.",
                    "Push back up to the start position, placing each hand where your elbows were.",
                    "Repeat this pattern, alternating which side you lower first with each rep."
                }
            };
            var c = new Exercise("Plank Hops")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/5786a09a737bb3be07fb9604/master/w_1200%2Cc_limit/BUNNY_HOP.gif",
                Difficulty = 2,
                Family = Family.Plank,
                IsCardio = true,
                Steps = new[]
                {
                    "Begin in a high plank with your feet together.",
                    "Tighten your abs and jump your feet to the right, bringing your knees toward your right elbow.",
                    "Jump your feet back to plank and repeat on the other side."
                }
            };
            var d = new Exercise("Plank Taps")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/5810d4f649a11728733b6125/master/w_1200%2Cc_limit/PLANK_TAPS.gif",
                Difficulty = 1,
                Family = Family.Plank,
                IsCardio = true,
                Steps = new[]
                {
                    "Start in a high plank with your feet hip-width apart.",
                    "Tap each hand to the opposite shoulder while engaging your core to keep the hips as still as possible."
                }
            };
            var e = new Exercise("Side Plank")
            {
                FocusArea = FocusArea.Core,
                Difficulty = 1,
                Family = Family.Plank,
                IsCardio = true,
            };
            var f = new Exercise("Bear Plank")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/59c818e641062372cfaba036/master/w_1200%2Cc_limit/Fitness_13.gif",
                Difficulty = 3,
                Family = Family.Plank,
                IsCardio = true,
                Steps = new[]
                {
                    "Start on your hands and knees in tabletop position with your wrists above your shoulders and your knees below your hips.",
                    "Lift your knees just a few inches off the ground. Use your core to balance and keep your back flat.",
                    "Slowly tap your hand to your opposite knee. Repeat, alternating sides.",
                    "Keep your torso still and try not to twist your body."
                }
            };
            var g = new Exercise("Plank Jacks")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/57e2b922edd53cfa267dfa03/master/w_1200%2Cc_limit/PLANK_JACKS%2520(2).gif",
                Difficulty = 2,
                Family = Family.Plank,
                IsCardio = true,
                Steps = new[]
                {
                    "Start in high plank.",
                    "Keeping your core engaged, jump your feet out and in (like jumping jacks)."
                }
            };
            var h = new Exercise("Side Plank Dips")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/59c81ac4ea81f306765b2888/master/w_1200%2Cc_limit/Untitled-6.gif",
                Difficulty = 2,
                Family = Family.Plank,
                IsCardio = true,
                Steps = new[]
                {
                    "Start in a side plank, with your left foot stacked on top of your right and your body in a straight line.",
                    "Drop your hips toward the floor and raise back to starting position (or a little higher, if you can).",
                    "Repeat on the other side."
                }
            };
            var i = new Exercise("Plank T Rotations")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/57c70c1c022a42d236f4aefe/master/w_1200%2Cc_limit/PLANK_T_ROTATION.gif",
                Difficulty = 1,
                Family = Family.Plank,
                IsCardio = true,
                Steps = new[]
                {
                    "Start in a high plank with your feet hip-distance apart.",
                    "Now rotate your entire body to the right into a side plank with your shoulder above your wrists.",
                    "Extend your right arm to the ceiling and continue to drive your hips up.",
                    "Return to center position, then repeat on the opposite side."
                }
            };
            var j = new Exercise("Lateral Plank Walks")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/59c81311b2227d7913413b83/master/w_1200%2Cc_limit/LATERAL_PLANK_WALKS%2520(1).gif",
                Difficulty = 3,
                Family = Family.Plank,
                IsCardio = true,
                Steps = new[]
                {
                    "Start in a high plank with your shoulders above your wrists and abs tight.",
                    "Step your right foot and right hand to the right, immediately following with your left foot and left hand. Take a few \"steps\" in one direction, then walk in the opposite direction."
                }
            };
            var k = new Exercise("Forearm Side Plank Twists")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/5812686049a11728733b6140/master/w_1200%2Cc_limit/FOREARM_SIDE_PLANK_TWIST.gif",
                Difficulty = 2,
                Family = Family.Plank,
                IsCardio = true,
                Steps = new[]
                {
                    "Start in a forearm side plank on your left side with your left elbow on the floor below your shoulder.",
                    "Place your right arm behind your head.",
                    "Rotate your torso toward the floor, bringing your right elbow to meet your left hand.",
                    "Repeat on the other side."
                }
            };
            var l = new Exercise("Side Plank Rotation Kicks")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/59c81fcfea81f306765b288a/master/w_1200%2Cc_limit/11.gif",
                Difficulty = 3,
                Family = Family.Plank,
                IsCardio = true,
                Steps = new[]
                {
                    "Start in a high plank with your shoulders over wrists, abs engaged, and glutes tight.",
                    "Lift your left foot and kick it under your torso toward the right side of your body. At the same time, reach your right hand to touch your left foot, balancing on your left arm and right leg.",
                    "Repeat on the other side."
                }
            };
            return new List<Exercise> { a, b, c, d, e, f, g, h, i, j, k, l };
        }

        private static List<Exercise> GetMovement()
        {
            var a = new Exercise("Box Jumps")
            {
                FocusArea = FocusArea.Lowerbody,
                Equipment = Equipment.Box,
                IsCardio = true,
                Family = Family.Movement,
            };
            var b = new Exercise("Skater Hops")
            {
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/59c80412bdd6c02d85791292/master/w_1200%2Cc_limit/skater-hops.gif",
                IsCardio = true,
                Family = Family.Movement,
                Steps = new[]
                {
                    "Starting at the left of your space, squat slightly then jump to the right as far as you can.",
                    "Land on your right foot and try not to touch your left foot down.",
                    "Jump back across to land on your left foot."
                }
            };
            var c = new Exercise("Step-In Step-Out")
            {
                FocusArea = FocusArea.Lowerbody,
                IsCardio = true,
                Family = Family.Movement,
            };
            return new List<Exercise> { a, b, c };
        }

        private static List<Exercise> GetHighKnees()
        {
            var a = new Exercise("High Knees")
            {
                FocusArea = FocusArea.Lowerbody,
                ImageUrl = "https://media.self.com/photos/59c817c8ea81f306765b2884/master/w_1200%2Cc_limit/Fitness_11.gif",
                Difficulty = 1,
                IsCardio = true,
                Family = Family.HighKnee,
                Steps = new[]
                {
                    "Stand with your feet hip-width apart.",
                    "Run in place, bringing your knees up toward your chest as high as possible while pumping your arms.",
                    "Keep your chest lifted, core engaged, and land lightly on the balls of your feet."
                }
            };
            var b = new Exercise("High Knees Four Touch")
            {
                FocusArea = FocusArea.Lowerbody,
                Difficulty = 3,
                IsCardio = true,
                Family = Family.HighKnee,
            };
            var c = new Exercise("High Knees Arms Raised")
            {
                FocusArea = FocusArea.Lowerbody,
                Difficulty = 2,
                IsCardio = true,
                Family = Family.HighKnee,
            };
            return new List<Exercise> { a, b, c };
        }

        private static List<Exercise> GetLegRaises()
        {
            var a = new Exercise("V-Ups")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/58126868ff42479b58d5a9a4/master/w_1200%2Cc_limit/VUp.gif",
                Difficulty = 2,
                Family = Family.LegRaise,
                IsCardio = true,
                Steps = new[]
                {
                    "Lie faceup with your arms and legs extended and resting on the floor.",
                    "Keep your abs tight and lift your hands and feet to meet over your torso, rolling your core as you sit up.",
                    "Lower your arms and legs back to the floor."
                }
            };
            var b = new Exercise("Leg Raises")
            {
                FocusArea = FocusArea.Core,
                Difficulty = 1,
                Family = Family.LegRaise,
                IsCardio = true,
            };
            var c = new Exercise("Scissor Kicks")
            {
                FocusArea = FocusArea.Core,
                Difficulty = 1,
                Family = Family.LegRaise,
                IsCardio = true,
            };
            var d = new Exercise("Alternating Leg Raise and Reach")
            {
                FocusArea = FocusArea.Core,
                Difficulty = 0,
                Family = Family.LegRaise,
                IsCardio = true,
            };
            var e = new Exercise("Single Leg Pulses")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/59c81784bdd6c02d85791298/master/w_1200%2Cc_limit/move4.gif",
                Difficulty = 3,
                Family = Family.LegRaise,
                IsCardio = true,
                Steps = new[]
                {
                    "Bring your right knee to your chest and extend the right leg to the ceiling. Keep your left leg extended and off the floor about 3 to 5 inches.",
                    "Interlace your fingertips behind your right knee.",
                    "Using your abs (not your hands), pulse your upper body up 3 to 5 inches. Make sure your low back stays planted firmly on the floor.",
                    "Repeat on the other side."
                }
            };
            var f = new Exercise("Horizontal Scissor Kicks")
            {
                FocusArea = FocusArea.Core,
                Difficulty = 1,
                Family = Family.LegRaise,
                IsCardio = true,
            };
            var g = new Exercise("Lateral Leg Raises")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/59aeea7cfd9d3f33d296b7ac/master/w_1600%2Cc_limit/gif3.gif",
                Difficulty = 0,
                Family = Family.LegRaise,
                IsCardio = true,
                Steps = new[]
                {
                    "Lie on your side, legs extended.",
                    "Lift your top leg 45 degrees, then lower slowly.",
                    "Do 5 lifts with your toe flexed, 5 with your toe pointed, and 5 with your toe pointed toward the ceiling.",
                    "Repeat on the other side."
                }
            };
            var h = new Exercise("Donkey Kicks")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/59aeea7e31384d0e66dee265/master/w_1200%2Cc_limit/gif5.gif",
                Difficulty = 0,
                IsCardio = true,
                Steps = new[]
                {
                    "Start on all fours.",
                    "Pull your right knee toward your chest, keeping your foot flexed.",
                    "Then, kick your right leg up behind you and toward the sky, then back down, keeping your knee bent and foot flexed.",
                    "Repeat on the other side."
                }
            };
            var i = new Exercise("Donkey Whips")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/59aeea80fd9d3f33d296b7ae/master/w_1200%2Cc_limit/gif6.gif",
                Difficulty = 0,
                Family = Family.LegRaise,
                IsCardio = true,
                Steps = new[]
                {
                    "Start on all fours.",
                    "Lift your right leg, extending it behind you.",
                    "Swing your right leg to the right side and then back to center.",
                    "Repeat on the other side."
                }
            };
            var j = new Exercise("Fire Hydrants")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/59aeea7f928ba138b01d3d10/master/w_1600%2Cc_limit/gif7.gif",
                Difficulty = 0,
                Family = Family.LegRaise,
                IsCardio = true,
                Steps = new[]
                {
                    "Start on all fours.",
                    "Lift your right leg to the side, keeping your knee bent, until your knee reaches hip height.",
                    "Lower to start, hovering your knee above the ground.",
                    "Repeat on the other side."
                }
            };
            var k = new Exercise("Single Leg Kickbacks")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/59c8111741062372cfaba032/master/w_1200%2Cc_limit/062917_fitness_16.gif",
                Difficulty = 1,
                Family = Family.LegRaise,
                IsCardio = true,
                Steps = new[]
                {
                    "Start on all fours with your knees under your hips and hands under your shoulders.",
                    "Lift your left leg and flex your foot as you kick it back behind you and straighten your leg.",
                    "Return to start.",
                    "Repeat on the other side."
                }
            };
            var l = new Exercise("Side Kicks")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/59c81929ea81f306765b2886/master/w_1200%2Cc_limit/Untitled-17.gif",
                Difficulty = 2,
                Family = Family.LegRaise,
                IsCardio = true,
                Steps = new[]
                {
                    "Stand next to a wall, far enough away so that you can bend your torso forward and press your palms against it, elbows bent.",
                    "Place both hands on the wall. Lift your right leg off the ground, parallel to the floor.",
                    "Bring your right knee in toward your right elbow. Then, flex your foot and kick the leg back out straight to the parallel position.",
                    "Repeat on the other side."
                }
            };
            var m = new Exercise("Dead Bugs")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/592746df8ac16b353cb97c81/master/w_800%2Cc_limit/move12.gif",
                Difficulty = 1,
                Family = Family.LegRaise,
                IsCardio = true,
                Steps = new[]
                {
                    "Lie on your back with your arms at shoulder level raised toward the ceiling. Bring your legs up into tabletop position (knees bent 90 degrees and stacked over your hips).",
                    "Slowly extend your right leg out straight, while simultaneously dropping your left arm overhead. Keep both a few inches from the ground.",
                    "Bring your arm and leg back to the starting position.",
                    "Repeat on the other side, extending your left leg and your right arm."
                }
            };
            return new List<Exercise> { a, b, c, d, e, f, g, h, i, j, k, l, m };
        }

        private static List<Exercise> GetLegReaches()
        {
            var a = new Exercise("Double Leg Reach")
            {
                FocusArea = FocusArea.Core,
                Difficulty = 0,
                Family = Family.LegReach,
                IsCardio = true,
            };
            var b = new Exercise("Single Leg Balance Taps")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/59c81ae041062372cfaba038/master/w_1200%2Cc_limit/Fitness_15.gif",
                Difficulty = 1,
                Family = Family.LegReach,
                IsCardio = true,
                Steps = new[]
                {
                    "Stand with your feet together, arms straight at your sides.",
                    "Slowly hinge forward at the hips, keeping your back flat as you lift your right leg out straight behind you and reach your right arm down toward the floor.",
                    "At the bottom of the movement, your torso and right leg should be almost parallel to the floor.",
                    "Keeping your core tight, stand up straight, keeping the right leg straight (and keeping the weight in your left foot).",
                    "Repeat on the other side."
                }
            };
            var c = new Exercise("Single Leg Reach and Jump")
            {
                FocusArea = FocusArea.Core,
                ImageUrl = "https://media.self.com/photos/59c81f52bdd6c02d8579129e/master/w_1200%2Cc_limit/16.gif",
                Difficulty = 2,
                Family = Family.LegReach,
                IsCardio = true,
                Steps = new[]
                {
                    "Stand with feet hip width apart, hands at your sides.",
                    "Hinge at your hips and bend your knees to extend your left leg behind you (no higher than your hips) as you reach your left arm to ground about a foot ahead of where your left foot was.",
                    "Drive your left knee up to return to an upright position, and hop on your right foot",
                    "Repeat on the other side."
                }
            };
            return new List<Exercise> { a, b, c };
        }


    }
}
