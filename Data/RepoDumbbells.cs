using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wurqout.ViewModels;

namespace Wurqout.Data
{
    public class RepoDumbbells
    {

        // Properties

        private static List<Exercise> Extensions { get; set; }

        private static List<Exercise> DeadLifts { get; set; }

        private static List<Exercise> Movement { get; set; }

        private static List<Exercise> Compound { get; set; }

        private static List<Exercise> Crunches { get; set; }

        private static List<Exercise> Presses { get; set; }

        private static List<Exercise> Raises { get; set; }

        private static List<Exercise> Lunges { get; set; }

        private static List<Exercise> Shrugs { get; set; }

        private static List<Exercise> Swings { get; set; }

        private static List<Exercise> Cleans { get; set; }

        private static List<Exercise> Squats { get; set; }

        private static List<Exercise> Curls { get; set; }

        private static List<Exercise> Rows { get; set; }

        // Methods: static

        public static List<Exercise> Fetch()
        {
            Initialize();

            var exercises = new List<Exercise>();
            exercises.AddRange(Extensions);
            exercises.AddRange(DeadLifts);
            exercises.AddRange(Compound);
            exercises.AddRange(Movement);
            exercises.AddRange(Crunches);
            exercises.AddRange(Presses);
            exercises.AddRange(Raises);
            exercises.AddRange(Lunges);
            exercises.AddRange(Shrugs);
            exercises.AddRange(Swings);
            exercises.AddRange(Cleans);
            exercises.AddRange(Squats);
            exercises.AddRange(Curls);
            exercises.AddRange(Rows);
            return exercises;
        }

        // Methods: private

        private static void Initialize()
        {
            Extensions ??= GetExtension();
            DeadLifts ??= GetDeadlift();
            Compound ??= GetCompound();
            Movement ??= GetMovement();
            Crunches ??= GetCrunches();
            Presses ??= GetPress();
            Raises ??= GetRaises();
            Lunges ??= GetLunge();
            Shrugs ??= GetShrug();
            Swings ??= GetSwing();
            Cleans ??= GetClean();
            Squats ??= GetSquat();
            Curls ??= GetCurl();
            Rows ??= GetRow();
        }

        private static List<Exercise> GetCompound()
        {
            var a = new Exercise
            {
                Name = "Dumbbell Curl and Press",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.CurlAndPress,
                ImageUrl = "https://media.self.com/photos/5daa31c8f11ed20008c03d3e/master/w_1200%2Cc_limit/Denise_Basic-Biceps-Curl-and-Overhead-Press.gif",
                Steps = new string[]
                {
                    "Hold the dumbbells in front of your body, palms facing up.",
                    "Curl the dumbbells to your shoulders.",
                    "Rotate the weights so your palms are away, and press the weights up and overhead.",
                    "Slowly reverse the motion to bring arms back to start.",
                }
            };

            var b = new Exercise
            {
                Name = "Dumbbell Hammer Curl and Press",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.CurlAndPress,
                ImageUrl = "https://media.self.com/photos/5daa352ff16166000998cacc/master/w_1200%2Cc_limit/Denise_Hammer-Curl%2520to-Overhead-Press.gif",
                Steps = new string[]
                {
                    "Hold a dumbbell in each hand, arms relaxed by your sides, and palms facing each other.",
                    "Curl the weights to your shoulders.",
                    "Then, with your palms still facing in, press the weights overhead, keeping the weights directly over the shoulders.",
                    "Reverse the motion to bring your arms back down to the starting position."
                }
            };

            var c = new Exercise
            {
                Name = "Dumbbell Hammer Curl to Press to Tricep Extension",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.CurlAndPress,
                ImageUrl = "https://media.self.com/photos/5daa32117fbb6300088cf5d3/master/w_1200%2Cc_limit/Denise_Basic%2520Biceps-Curl-Overhead-Press-Triceps-Extension.gif",
                Steps = new string[]
                {
                    "Hold the dumbbells in front of your body, palms facing each other.",
                    "Curl the dumbbells to your shoulders.",
                    "Now press the weights overhead.",
                    "With your arms over your head, press the weights together.",
                    "With your elbows locked in place, bend at the elbows to lower the dumbbells behind your head.",
                    "Raise your arms back up, straightening them completely at the top.",
                    "Keep your upper arms pressed close to your ears.",
                    "Slowly reverse the motion to return to start."
                }
            };

            return new List<Exercise> { a, b, c };
        }

        private static List<Exercise> GetSquat()
        {
            var a = new Exercise
            {
                Name = "Dumbbell Globlet Squat",
                FocusArea = FocusArea.Lowerbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Squat,
                ImageUrl = "https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/goblet-squat.gif?resize=980:*",
                Steps = new string[]
                {
                    "Stand with feet set wider than shoulder-width and hold a dumbbell with both hands in front of your chest.",
                    "Sit back into a squat, then drive back up and repeat."
                }
            };
            return new List<Exercise> { a };
        }

        private static List<Exercise> GetClean()
        {
            var a = new Exercise
            {
                Name = "Dumbbell Clean",
                FocusArea = FocusArea.Wholebody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Clean,
                ImageUrl = "https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/dumbell-clean.gif?resize=980:*",
                Steps = new string[]
                {
                    "Flip your wrists so they face forwards and bring the weights to your shoulders, slightly jumping as you do.",
                    "Slowly straighten your legs to stand.",
                    "Then lower the weights down to your thigh before moving into squat position and repeating."
                }
            };


            return new List<Exercise> { a };
        }

        private static List<Exercise> GetRow()
        {
            var a = new Exercise
            {
                Name = "Dumbbell Bent-Over Row",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Row,
                ImageUrl = "https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/bent-row.gif?resize=980:*",
                Steps = new string[]
                {
                    "Keep your core tight and your back straight as you row the weights up to your chest.",
                    "Lower and repeat."
                }
            };

            var b = new Exercise
            {
                Name = "Dumbbell Upright Row",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Row,
                ImageUrl = "",
            };

            var c = new Exercise
            {
                Name = "Single Arm Row",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Row,
                ImageUrl = "https://www.mensjournal.com/wp-content/uploads/mf/dumbbellrow.jpg?w=800"
            };

            return new List<Exercise> { a, b, c };
        }

        private static List<Exercise> GetDeadlift()
        {
            var a = new Exercise
            {
                Name = "Dumbbell Stiff Leg Deadlift",
                FocusArea = FocusArea.Lowerbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.DeadLift,
                ImageUrl = "https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/stiffy-dumbbell.gif?resize=980:*",
                Steps = new string[]
                {
                    "Lower the dumbbells to the top of your feet, as far as you can go by extending through your waist, then slowly return to the starting position.",
                }
            };

            return new List<Exercise> { a };
        }

        private static List<Exercise> GetSwing()
        {
            var a = new Exercise
            {
                Name = "Dumbbell Single-Arm Swing",
                FocusArea = FocusArea.Core,
                Equipment = Equipment.Dumbbell,
                Family = Family.Swing,
                ImageUrl = "https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/one-arm-swing.gif?resize=980:*",
                Steps = new string[] 
                {
                    "Sink into a squat and swing the dumbbell through your legs before immediately driving yourself forward, bringing the weight up towards your head as you straighten your legs.",
                    "Repeat this movement, then swap sides."
                }
            };

            return new List<Exercise> { a };
        }

        private static List<Exercise> GetPress()
        {
            var a = new Exercise
            {
                Name = "Dumbbell Press",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.ChestPress,
                ImageUrl = "https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/bench-press-dumbell.gif?resize=980:*",
                Steps = new string[]
                {
                    "Lie on a flat bench holding two dumbbells over your chest with an overhand grip.",
                    "Push up until your arms are straight, then lower under control."
                }
            };

            var b = new Exercise
            {
                Name = "Renegade Row with Push-Up",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.ChestPress,
                ImageUrl = "https://media.self.com/photos/5ced7ee8ae57156f10d6367d/master/w_1200%2Cc_limit/dumbbells-alternating-push-up-row-Amanda_112.gif",
                Steps = new string[]
                {
                    "Start in a high plank holding a dumbbell in each hand on the floor, hands shoulder-width apart, shoulders stacked directly above your wrists, legs extended behind you wider than hip-width apart (it'll help with stability), and your core and glutes engaged. This is the starting position.",
                    "Pull your right elbow back to do a row, raising the dumbbell toward your chest and keeping your elbow close to your torso. Keep your abs and butt tight to prevent your hips from rocking.",
                    "Lower the weight back down to the starting position.",
                    "Bend your elbows and lower your chest to the floor to do a push-up.",
                    "Push back up to plank position.",
                    "Then, pull your left elbow back to do a row, raising the dumbbell toward your chest and keeping your elbow close to your torso. Keep your abs and butt tight to prevent your hips from rocking.",
                    "Lower the weight back down to the starting position.",
                    "Do another push-up. This is 1 rep.",
                }
            };

            var c = new Exercise
            {
                Name = "Dumbbell Shoulder Press",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.ShoulderPress,
                ImageUrl = "https://media.self.com/photos/5ced7f53bf20ff47b5dd15ef/master/w_1200%2Cc_limit/dumbbell-alternating-single-arm-overhead-press-Rachel_058.gif",
                Steps = new string[]
                {
                    "Stand with your feet about hip-width apart. Hold a weight in each hand and rest them at shoulder height, with your palms facing forward and your elbows bent. This is the starting position.",
                    "Press one dumbbell overhead, straightening your elbow completely. Make sure to keep your core engaged and hips tucked under to avoid arching your lower back as you lift your arm.",
                    "Slowly bend your elbow to lower the weight back down to the starting position.",
                    "Repeat this movement with the other arm. This is 1 rep."
                }
            };

            return new List<Exercise> { a, b, c };
        }

        private static List<Exercise> GetCurl()
        {
            var a = new Exercise
            {
                Name = "Cross Body Hammer Curl",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Curl,
                ImageUrl = "https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/hammer-curl.gif?resize=980:*",
                Steps = new string[]
                {
                    "One at a time, curl each weight up towards your opposing shoulder.",
                    "Return under control to the start position and repeat on the other side."
                }
            };

            var b = new Exercise
            {
                Name = "Dumbbell Hammer Curl",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Curl,
                ImageUrl = "https://www.mensjournal.com/wp-content/uploads/mf/30-best-arm-exercises-hammer-curl.jpg?w=800",
            };

            var c = new Exercise
            {
                Name = "Dumbbell Curl",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Curl,
                ImageUrl = "https://www.mensjournal.com/wp-content/uploads/mf/dumbbell_curl_main.jpg?w=800",
            };

            var d = new Exercise
            {
                Name = "Dumbbell Wide-Grip Bicep Curl",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Curl,
                ImageUrl = "https://media.self.com/photos/5da9dcc3f16166000998caad/master/w_1200%2Cc_limit/Denise_Wide-Grip%2520Biceps%2520Curl.gif",
                Steps = new string[]
                {
                    "Stand with your legs shoulder-width apart.",
                    "Hold a dumbbell in each hand, and hold your arms wide at your sides with your elbows pushing in toward your ribs, palms facing up.",
                    "Perform a wide-grip biceps curl by bending at the elbow.",
                }
            };

            var e = new Exercise
            {
                Name = "Dumbbell Close-Grip to Wide-Grip",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Curl,
                ImageUrl = "https://media.self.com/photos/5daa34587fbb6300088cf5d7/master/w_1200%2Cc_limit/Denise_Close-Grip-to-Wide-Grip-Burnout.gif",
                Steps = new string[]
                {
                }
            };

            var f = new Exercise
            {
                Name = "Dumbbell Cross-Body Curls",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Curl,
                ImageUrl = "https://media.self.com/photos/5daa3302f11ed20008c03d42/master/w_1200%2Cc_limit/Denise_Cross-Body-Curls.gif",
                Steps = new string[]
                {
                    "Start with your arms at your sides, holding a dumbbell in each hand.",
                    "Keeping your palms facing each other, make a circle with your right hand from your right shoulder to your left shoulder, then to your left hip, then to your right hip, drawing a C as the weight crosses the body.",
                }
            };

            var g = new Exercise
            {
                Name = "Dumbbell Hammer Curl in Plank",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Curl,
                ImageUrl = "https://media.self.com/photos/5daa3175f16166000998cac0/master/w_1200%2Cc_limit/Denise_Hammer-Biceps-Curls-in-Plank.gif",
                Steps = new string[]
                {
                    "Slowly walk your hands out to a high plank position while holding the dumbbells.",
                    "Without moving your torso, curl the dumbbell in your right hand up toward your ear. Keep your thumb facing up and your palms facing each other.",
                    "Repeat on the left, and continue alternating sides.",
                    "Keep your core tight and hips stable.",
                    "Make sure your feet are at least shoulder-width apart or wider to help stabilize your hips. You can also lower your knees to the ground for a modified plank."
                }
            };


            return new List<Exercise> { a, b, c, d, e, f, g };
        }

        private static List<Exercise> GetCrunches()
        {
            var a = new Exercise("Dumbbell Russian Twists")
            {
                FocusArea = FocusArea.Core,
                Equipment = Equipment.Dumbbell,
                Family = Family.Crunch,
                ImageUrl = "https://media.self.com/photos/5ced7e4af3a7281461479954/master/w_1200%2Cc_limit/russian-twist-dumbbell-Amanda_048.gif",
                Steps = new string[]
                {
                    "Sit with your knees bent out in front of you, feet flexed, and heels on the floor.",
                    "Hold one dumbbell in front of your chest, and lean your torso back until you feel your abdominal muscles engage.",
                    "Slowly twist your torso from right to left. Remember to keep your core tight (and breathe!) throughout."
                }
            };
            
            return new List<Exercise> { a };
        }

        private static List<Exercise> GetMovement()
        {
            var a = new Exercise
            {
                Name = "Farmers' Walk",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Movement,
                ImageUrl = "https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/walk.gif?resize=980:*",
            };

            // This doesn't work as expected, removed until
            // I come up with a nice solution.
            var b = new Exercise
            {
                Name = "Dumbbell Step-Ups",
                FocusArea = FocusArea.Lowerbody,
                Equipment = Equipment.Dumbbell & Equipment.Box,
                Family = Family.Movement,
                ImageUrl = "https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/dumbbell-step-up.gif?resize=980:*",
            };

            var c = new Exercise
            {
                Name = "Dumbbell Wood-chop",
                FocusArea = FocusArea.Core,
                Equipment = Equipment.Dumbbell,
                Family = Family.Movement,
                ImageUrl = "https://media.self.com/photos/5ced8291f3a728b43f479956/master/w_1200%2Cc_limit/dumbbell-chopper-Rachel_038.gif",
                Steps = new string[]
                {
                    "Stand with your feet wider than hip-width apart, core engaged, holding a dumbbell by your left leg.",
                    "Raise your arms diagonally in front of your body to the upper right of your reach, allowing your torso and toes to naturally rotate to the right as you twist.",
                    "Now “chop” the weight down to the left, bringing it across the front of your body and aiming for your left ankle, allowing your torso and toes to naturally rotate in that direction. Focus on keeping your lower body stable and rotating from your core. This is 1 rep.",
                    "Do all your reps on one side, and then switch sides and repeat."
                }
            };


            return new List<Exercise> { a, c };
        }

        private static List<Exercise> GetRaises()
        {
            var a = new Exercise
            {
                Name = "Dumbbell Scaption",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Raise,
                ImageUrl = "https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/Dumbell-scaption.gif?resize=980:*",
                Steps = new string[]
                {
                    "Arc the weights up to your sides keeping your arms straight at all times until you feel a strong stretch across your shoulders.",
                    "Return slowly to the start position."
                }
            };

            var b = new Exercise
            {
                Name = "Single Dumbbell Shoulder Raise",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Raise,
                ImageUrl = "",
                Steps = new string[]
                {
                    "Place one hand on either side of a dumbbell and let it hang between your legs.",
                    "Lift the dumbbell directly above your head, then lower it back down and repeat."
                }
            };

            var c = new Exercise
            {
                Name = "Dumbbell Calf Raise",
                FocusArea = FocusArea.Lowerbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Raise,
                ImageUrl = "",
                Steps = new string[]
                {
                    "Stand upright holding two dumbbells by your sides.",
                    "Place the balls of your feet on an exercise step or weight plate with your heels touching the floor.",
                    "With your toes pointing forwards, raise your heels off the floor and contract your calves.",
                    "Slowly return to the starting position."
                }
            };

            var d = new Exercise
            {
                Name = "Dumbbell Front Raise",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Raise,
                ImageUrl = ""
            };

            var e = new Exercise
            {
                Name = "Dumbbell Lateral Raise",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Raise,
                ImageUrl = ""
            };

            var f = new Exercise
            {
                Name = "Dumbbell Bentover Lateral Raise",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Raise,
                ImageUrl = "https://www.mensjournal.com/wp-content/uploads/mf/bentoverlateralraisemain.jpg?w=800"
            };

            var g = new Exercise
            {
                Name = "Dumbbell Single-Leg Reverse Fly",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Raise,
                ImageUrl = "https://media.self.com/photos/5ced83afae57157ef0d6367f/master/w_1200%2Cc_limit/dumbbell-one-leg-reverse-fly-Cookie_059.gif",
                Steps = new string[]
                {
                    "Stand with your feet about hip-width apart. Hold a weight in each hand with your arms resting along the sides of your legs, palms facing in.",
                    "Lift your right leg straight out behind you and hinge forward at the hips until your torso is parallel to the floor. (Depending on your hip mobility and hamstring flexibility, you may not be able to bend so far over.) Gaze at the ground a few inches in front of your left foot to keep your neck in a comfortable position. The weights should be hanging down toward the floor.",
                    "With a slight bend in your elbows, slowly lift the weights up and out to the sides until they're in line with your shoulders.",
                    "Then, lower them back down with control. This is 1 rep."
                }
            };

            var h = new Exercise
            {
                Name = "Dumbbell Rear-Delt Fly",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Raise,
                ImageUrl = "https://media.self.com/photos/5e5e825f8c28dd00081cc421/master/w_1200%2Cc_limit/dumbbell-bent-over-fly-Cookie_060.gif",
                Steps = new string[]
                {
                    "Stand with your feet about hip-width apart. Hold a dumbbell in each hand with your arms resting along the sides of your legs, palms facing in.",
                    "Bend your knees slightly and hinge over at your hips, making sure to keep your back straight.",
                    "With a slight bend in your elbows, slowly lift the weights up and out to the sides until they’re in line with your shoulders.",
                    "Lower them back down with control. This is 1 rep."
                }
            };

            return new List<Exercise> { a, b, c, d, e, f, g, h };
        }

        private static List<Exercise> GetLunge()
        {
            var a = new Exercise
            {
                Name = "Dumbbell Lunge",
                FocusArea = FocusArea.Lowerbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Lunge,
                ImageUrl = "",
                Steps = new string[]
                {
                    "Stand with dumbbells at your side and palms facing your body.",
                    "Lunge forward as far as you can with your right leg, bending your trailing knee so it almost brushes the floor.",
                    "Use the heel of your right foot to push your upper body back to the starting position.",
                    "Repeat with the opposite leg."
                }
            };

            var b = new Exercise
            {
                Name = "Dumbbell Reverse Lunge with Twist",
                FocusArea = FocusArea.Lowerbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Lunge,
                ImageUrl = "https://media.self.com/photos/5c390e80b3947e5b05c8f967/master/w_1200%2Cc_limit/reverse-lunge-twist-cookie.gif",
                Steps = new string[]
                {
                    "Stand with your feet shoulder-width apart. Hold one dumbbell at your chest with both hands, gripping it on each end. This is the starting position.",
                    "Step back (about 2 feet) with your right foot, landing on the ball of your right foot and keeping your heel off the floor.",
                    "Bend both knees to create two 90-degree angles with your legs. Your chest should be upright and your torso should be leaning slightly forward so that your back is flat and not arched or rounded forward. Your right quad should be parallel to the floor and your right knee should be above your right foot. Your butt and core should be engaged.",
                    "Slowly rotate your torso to the left. You should feel a nice stretch in your midback.",
                    "Twist back to center, and then push through the heel of your left foot to return to the starting position.",
                    "Repeat on the other side, stepping back with your left foot, lowering into a lunge, and then slowly rotating your torso to the right.",
                    "Twist back to center, and then push through the heel of your right foot to return to the starting position. That's 1 rep."

                }
            };

            return new List<Exercise> { a, b };
        }

        private static List<Exercise> GetExtension()
        {
            var a = new Exercise
            {
                Name = "Dumbbell Overhead Tricep Extension",
                FocusArea = FocusArea.Lowerbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Extension,
                ImageUrl = "https://media.self.com/photos/5daa32d0f11ed20008c03d40/master/w_1200%2Cc_limit/Denise_Triceps-Overhead-Press.gif",
                Steps = new string[]
                {
                    "Hold a dumbbell in each hand. Extend your arms overhead, and press the weights together.",
                    "With your elbows locked in place, bend at the elbows to lower the dumbbells behind your head.",
                    "Raise your arms back up, straightening them completely at the top.",
                    "Keep your upper arms and elbows close to your ears."
                }
            };

            var b = new Exercise
            {
                Name = "Dumbbell Lying Tricep Extension",
                FocusArea = FocusArea.Lowerbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Extension,
                ImageUrl = "https://www.mensjournal.com/wp-content/uploads/mf/30-best-arm-exercises-lying-triceps-extension.jpg",
            };

            var c = new Exercise
            {
                Name = "Dumbbell Tricep Extension in Plank",
                FocusArea = FocusArea.Upperbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Extension,
                ImageUrl = "https://media.self.com/photos/5daa349d5c250800081afa6b/master/w_1200%2Cc_limit/Denise_Triceps-Kickback-in-Plank.gif",
                Steps = new string[]
                {
                    "With dumbbells in your hands, walk your body out to high plank position.",
                    "Once in a plank, raise your right elbow to your rib cage, arm bent.",
                    "Straighten your arm to perform a kickback.",
                    "Repeat on the left side.",
                    "Continue the movement, alternating sides.",
                    "Keep your hips as stable as possible. You can modify this move by dropping your knees to the floor."
                }
            };

            return new List<Exercise> { a, b, c };
        }

        private static List<Exercise> GetShrug()
        {
            var a = new Exercise
            {
                Name = "Dumbbell Shrugs",
                FocusArea = FocusArea.Lowerbody,
                Equipment = Equipment.Dumbbell,
                Family = Family.Shrug,
                ImageUrl = "",
            };

            return new List<Exercise> { a };
        }



    }
}
