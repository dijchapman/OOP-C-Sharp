using System;

public class ExerciseSet {
    private int _reps;
    private int _weight;
    private string _weightMeasurement = "lb"; // either pounds (lb) or kilograms (kg)
    private int _rpe;

    public ExerciseSet(int reps, int weight, string weightM, int rpe) {
        this._reps = reps;
        this._weight = weight;
        this._weightMeasurement = weightM;
        this._rpe = rpe;
    }

    public string getDetails() {
        return String.Format("This set will be completed with {0} reps, using {1} {2} with a target RPE of {3}", _reps, _weight, _weightMeasurement, _rpe);
    }
}