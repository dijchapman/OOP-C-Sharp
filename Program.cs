using System;
using System.Collections.Generic;

namespace workout_OOP {
    class Program {
        static void Main(string[] args) {
            Client peterParker = new Client("Peter", "Parker");
            Trainer tonyStark = new Trainer("Tony", "Stark");
            // peterParker.aboutMe();
            // tonyStark.aboutMe();

            ExerciseSet[] sets = new ExerciseSet[3];
            sets[0] = new ExerciseSet(8, 145, "lb", 3);
            sets[1] = new ExerciseSet(6, 165, "lb", 4);
            sets[2] = new ExerciseSet(4, 185, "lb", 5);
            Exercise benchPress = new Exercise("Bench Press", "Chest", sets);
            // benchPress.exerciseDetails();
            // benchPress.exerciseSetDetails();

            Exercise[] exercisesAddToWorkout = new Exercise[5];
            exercisesAddToWorkout[0] = benchPress;
            exercisesAddToWorkout[1] = benchPress;
            exercisesAddToWorkout[2] = benchPress;
            exercisesAddToWorkout[3] = benchPress;
            exercisesAddToWorkout[4] = benchPress;

            DateTime workoutDate = new DateTime(2022, 6, 30);
            Workout workout = new Workout(peterParker, tonyStark, workoutDate, 60, exercisesAddToWorkout);
            workout.workoutDetails();
            workout.performWorkout();
        }
    }
}