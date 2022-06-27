using System;

public class Workout {
    private Client _client;
    private Trainer _trainer;
    private DateTime _dateAndTime;
    private int _duration;
    private Exercise[] _exercises;

    public Workout(Client c, Trainer t, DateTime dateTime, int duration, Exercise[] exercises) {
        this._client = c;
        this._trainer = t;
        this._dateAndTime = dateTime;
        this._duration = duration;
        this._exercises = exercises;
    }

    public void workoutDetails() {
        Console.WriteLine("{0} will have a session with {1} on {2}, which will last {3} minutes", _client.FullName, _trainer.FullName, _dateAndTime, _duration);
    }

    public void performWorkout() {
        greetClient();
        generalWarmup();
        specificWarmup();
        startExercises();
        cooldownRoutine();
        goodbyeToClient();
    }

    protected void greetClient() {
        Console.WriteLine("Hello {0}, my name is {1} and I will be your personal trainer today.", _client.FullName, _trainer.FullName);
    }

    protected void generalWarmup() {
        Console.WriteLine("To start, we will perform a 10 minute walk at a moderate speed.");
    }

    protected void specificWarmup() {
        Console.WriteLine("Now we will perform specific stretches to prepare for the workout.");
    }

    protected void startExercises() {
        Console.WriteLine("We will start performing the prescribed exercises for the session.");
        foreach (Exercise exercise in _exercises) {
            exercise.exerciseDetails();
            exercise.exerciseSetDetails();
            Console.WriteLine();
        }
    }

    protected void cooldownRoutine() {
        Console.WriteLine("After the exercises, we will perform specific soft tissue foam rolling stretches.");
        Console.WriteLine("To finish, we will perform a 5 minute walk at a moderate speed.");
    }

    protected void goodbyeToClient() {
        Console.WriteLine("Goodbye {0}, I hope you enjoyed your workout and I hope to see you soon!", _client.FullName);
    }
}