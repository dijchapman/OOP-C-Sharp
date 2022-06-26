using System;

public class Trainer : Person {
    public Trainer(string firstName, string lastName) : base(firstName, lastName) {
        
    }

    public override void aboutMe() {
        Console.WriteLine("My name is {0}, I am a personal trainer wanting to help my client.", FullName);
    }
}