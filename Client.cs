using System;

public class Client : Person {
    public Client(string firstName, string lastName) : base(firstName, lastName) {

    }

    public override void aboutMe() {
        Console.WriteLine("My name is {0}, I am a client wanting to workout.", FullName);
    }
}