using System;
using System.Collections.Generic;

namespace workout_OOP {
    class Program {
        static void Main(string[] args) {
            Client peterParker = new Client("Peter", "Parker");
            Trainer tonyStark = new Trainer("Tony", "Stark");
            // peterParker.aboutMe();
            // tonyStark.aboutMe();

            DateTime workoutDateTime = new DateTime(2022, 6, 30, 10, 30, 0);
            Workout workout = new Workout(peterParker, tonyStark, workoutDateTime, 60);
            workout.workoutDetails();
            workout.performWorkout();

            Exercise benchPress = new Exercise("Bench Press", "Chest");
            // benchPress.exerciseDetails();
        }
    }
}