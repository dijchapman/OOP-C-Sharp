using System;
using System.Collections.Generic;

namespace workout_OOP {
    class Program {
        static void Main(string[] args) {
            Client peterParker = new Client("Peter", "Parker");
            Trainer tonyStark = new Trainer("Tony", "Stark");
            peterParker.aboutMe();
            tonyStark.aboutMe();

            Exercise benchPress = new Exercise("Bench Press", "Chest");
            benchPress.exerciseDetails();
        }
    }
}