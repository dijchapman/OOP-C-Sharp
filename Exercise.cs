using System;

public class Exercise {
    private string _exerciseName;
    private string _muscleGroup;

    public Exercise(string exerciseName, string muscleGroup) {
        this._exerciseName = exerciseName;
        this._muscleGroup = muscleGroup;
    }

    public void exerciseDetails() {
        Console.WriteLine("{0} primarily works on the {1} muscle group", this._exerciseName, this._muscleGroup);
    }
}