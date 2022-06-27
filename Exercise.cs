using System;

public class Exercise {
    private string _exerciseName;
    private string _muscleGroup;
    private ExerciseSet[] _sets;

    public Exercise(string exerciseName, string muscleGroup, ExerciseSet[] sets) {
        this._exerciseName = exerciseName;
        this._muscleGroup = muscleGroup;
        this._sets = sets;
    }

    public void exerciseDetails() {
        Console.WriteLine("{0} primarily works on the {1} muscle group", this._exerciseName, this._muscleGroup);
    }

    public void exerciseSetDetails() {
        int setNumber = 1;
        foreach (ExerciseSet set in _sets) {
            Console.WriteLine("Set number {0} - {1}", setNumber, set.getDetails());
            setNumber++;
        }
    }
}