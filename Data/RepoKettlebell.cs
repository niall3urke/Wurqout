using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wurqout.ViewModels;

namespace Wurqout.Data
{
    public class RepoKettlebell
    {

        // Source: https://www.menshealth.com/uk/building-muscle/a758657/the-7-best-kettlebell-exercises-to-build-muscle/

        private static List<Exercise> Thrusters { get; set; }

        private static List<Exercise> Movements { get; set; }

        private static List<Exercise> Snatches { get; set; }

        private static List<Exercise> Presses { get; set; }

        private static List<Exercise> Swings { get; set; }

        private static List<Exercise> Squats { get; set; }

        private static List<Exercise> Cleans { get; set; }

        // Methods: static

        public static List<Exercise> Fetch()
        {
            Intialize();

            var exercises = new List<Exercise>();
            exercises.AddRange(Thrusters);
            exercises.AddRange(Movements);
            exercises.AddRange(Snatches);
            exercises.AddRange(Presses);
            exercises.AddRange(Swings);
            exercises.AddRange(Cleans);
            exercises.AddRange(Squats);
            return exercises;
        }

        private static void Intialize()
        {
            Cleans ??= GetCleanAndPress();
            Thrusters ??= GetThrusters();
            Movements ??= GetMovements();
            Snatches ??= GetSnatches();
            Presses ??= GetPresses();
            Swings ??= GetSwings();
            Squats ??= GetSquats();
        }

        private static List<Exercise> GetCleanAndPress()
        {
            var a = new Exercise
            {
                Name = "Kettlebell Clean and Press",
                FocusArea = FocusArea.Wholebody,
                Equipment = Equipment.Kettlebell,
                Family = Family.CleanAndPress,
                ImageUrl = "https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/clean-and-press-kettlebell.gif?resize=980:*",
                Steps = new string[]
                {
                    "Stand holding two kettlebells by your thighs, knees slightly bent and legs shoulder-width apart.",
                    "In one swift movement, slightly jump off the ground and raise your arms to extend above your head.",
                    "Land softly on your feet with your knees bent as though you're doing a squat and extend your arms straight above you shoulder-width apart.",
                }
            };

            return new List<Exercise> { a };
        }

        private static List<Exercise> GetThrusters()
        {
            var a = new Exercise
            {
                Name = "Kettlebell Thrusters",
                FocusArea = FocusArea.Wholebody,
                Equipment = Equipment.Kettlebell,
                Family = Family.Thrusters,
                ImageUrl = "https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/kettlebell-swing.gif?resize=980:*",
                Steps = new string[]
                {
                    "Hold two kettlebells by their handles so the weight is resting on the back of your shoulders.",
                    "Slightly bend your knees and squat down, keeping your legs in line with your shoulders.",
                    "Drive through your legs and straighten them, extending your arms as you do to raise the kettlebells above your head.",
                    "Squat down and repeat."
                }
            };

            return new List<Exercise> { a };
        }

        private static List<Exercise> GetMovements()
        {
            var a = new Exercise
            {
                Name = "Kettlebell Farmers' Walk",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Kettlebell,
                Family = Family.Movement,
                ImageUrl = "https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/kbfarmerswalk.gif?resize=980:*",
                Steps = new string[] 
                {
                    "Hold two kettlebells by your side.",
                    "Keep your arms strong and walk short, quick steps as fast as possible.",
                    "Turn around and walk back."
                }
            };

            var b = new Exercise
            {
                Name = "Kettlebell Toe Touch with Pick Up",
                FocusArea = FocusArea.Wholebody,
                Equipment = Equipment.Kettlebell,
                Family = Family.Movement,
                ImageUrl = "",
                Steps = new string[]
                {
                    "With your legs shoulder width apart, hold a kettlebell in one hand and extend it above you.",
                    "Slide the opposite hand down your leg, keeping your arm with the kettlebell in completely straight, and another kettlebell.",
                    "Lift your body back up, raising the kettlebell to your thigh, then slowly move back down to place the kettlebell back on the floor. Return to starting position and repeat."
                }
            };

            var c = new Exercise
            {
                Name = "Kettlebell Staggered Stance Halo",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Kettlebell,
                Family = Family.Movement,
                ImageUrl = "https://media.self.com/photos/5daf3df83d6b1f0008713710/master/w_1200%2Cc_limit/Saneeta_Halo%2520in%2520Staggered%2520Stance.gif",
                Steps = new string[]
                {
                    "Hold the horns of the kettlebell with the bell facing up at chest height.",
                    "Take a big step forward with your right foot so your feet are staggered. Keep your knees soft (not locked).",
                    "Lift the bell and slowly circle it around your head in a clockwise direction.",
                    "Return to the starting position; then circle the kettlebell in the other direction, starting to the right.",
                    "Return to starting position. Both left and right sides equals 1 rep. Do 8-10 reps, then repeat with the other leg staggered forward.",
                }
            };


            return new List<Exercise> { a, b, c };
        }

        private static List<Exercise> GetSnatches()
        {
            var a = new Exercise
            {
                Name = "Kettlebell Snatch",
                FocusArea = FocusArea.Wholebody,
                Equipment = Equipment.Kettlebell,
                Family = Family.Snatch,
                ImageUrl = "https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/how-to-do-a-kettlebell-snatch.gif?resize=980:*",
                Steps = new string[]
                {
                    "Holding a kettlebell in one hand between your legs, squat down until your thighs are parallel to the floor.",
                    "Drive upwards through your hips and knees and as the kettlebell rises to shoulder height, rotate your hand and push it upwards until your arm is locked out.",
                    "Squat down and return the weight to the start position. Repeat with one arm, then swap sides."
                }
            };

            return new List<Exercise> { a };
        }

        private static List<Exercise> GetPresses()
        {
            var a = new Exercise
            {
                Name = "Alternate Kettlebell Shoulder Press",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Kettlebell,
                Family = Family.ShoulderPress,
                ImageUrl = "",
                Steps = new string[]
                {
                    "Stand with your feet shoulder-width apart holding two kettlebells at shoulder height.",
                    "Press one of the weights above your head until your arm is fully extended.",
                    "Lower and repeat with the other arm."
                }
            };

            var b = new Exercise
            {
                Name = "Alternate Kettlebell Floor Press",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Kettlebell,
                Family = Family.ChestPress,
                ImageUrl = "",
                Steps = new string[]
                {
                    "Lie on the floor holding a kettlebell in each hand.",
                    "Press the kettlebells up towards the ceiling.",
                    "Lower back to start position, one at a time."
                }
            };

            return new List<Exercise> { a, b };
        }

        private static List<Exercise> GetSwings() 
        {
            var a = new Exercise
            {
                Name = "Kettlebell Swing",
                FocusArea = FocusArea.Lowerbody,
                Equipment = Equipment.Kettlebell,
                Family = Family.Swing,
                ImageUrl = "https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/kettlebell-swing.gif?resize=980:*",
                Steps = new string[]
                {
                    "Stand with feet set wider than shoulder-width and bend your knees to grab the kettlebell with both hands.",
                    "Drive your hips, keep your back flat swing the weight up to shoulder height.",
                    "Return to the start position and repeat without losing momentum."
                }
            };

            var b = new Exercise
            {
                Name = "One Arm Kettlebell Swing",
                FocusArea = FocusArea.Lowerbody,
                Equipment = Equipment.Kettlebell,
                Family = Family.Swing,
                ImageUrl = "",
                Steps = new string[]
                {
                    "Stand with feet set wider than shoulder-width and bend your knees to grab the ketllebell with one hand.",
                    "Drive your hips, keep your back flat swing the weight up to shoulder height.",
                    "Return to the start position and repeat without losing momentum."
                }
            };

            return new List<Exercise> { a, b };
        }

        private static List<Exercise> GetSquats()
        {
            var a = new Exercise
            {
                Name = "Kettlebell Pistol Squat",
                FocusArea = FocusArea.Lowerbody,
                Equipment = Equipment.Kettlebell,
                Family = Family.Squat,
                ImageUrl = "https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/kettlebell-pistol-squat.gif?resize=980:*",
                Steps = new string[]
                {
                    "Hold one kettlebell with both hands just under your chin.",
                    "Lift one leg off the floor and squat down with the other.",
                    "Drive through the heel and bring yourself back up to standing position, without letting your leg touch the floor.",
                    "Lower back down and repeat."
                }
            };

            var b = new Exercise
            {
                Name = "Kettlebell Globlet Squat",
                FocusArea = FocusArea.Lowerbody,
                Equipment = Equipment.Kettlebell,
                Family = Family.Squat,
                ImageUrl = "https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/KBgoblet.gif?resize=980:*",
                Steps = new string[]
                {
                    "Stand with your legs slightly wider than shoulder-width apart, clasping a kettlebell in each hand in front of your chest with palms facing each other.",
                    "Bend your knees and lower yourself into a squat, keeping the kettlebells in the same position and ensuring you don't round your back by tensing your glutes throughout.",
                    "Drive back up and repeat."
                }
            };

            return new List<Exercise> { a, b };
        }



    }
}
