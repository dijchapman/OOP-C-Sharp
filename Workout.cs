using System;

public class Workout {
    private Client _client;
    private Trainer _trainer;
    private DateTime _dateAndTime;
    private int _duration;

    public Workout(Client c, Trainer t, DateTime dateTime, int duration) {
        this._client = c;
        this._trainer = t;
        this._dateAndTime = dateTime;
        this._duration = duration;
    }

    public void workoutDetails() {
        Console.WriteLine("{0} will have a session with {1} on {2}, which will last {3} minutes", _client.FullName, _trainer.FullName, _dateAndTime, _duration);
    }
}