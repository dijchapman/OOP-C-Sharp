using System;

public abstract class Person {
    private string _firstName;
    private string _lastName;

    
    public Person(string firstName, string lastName) {
        this._firstName = firstName;
        this._lastName = lastName;
    }

    public string FullName {
        get {
            return string.Format("{0} {1}", this._firstName, this._lastName);
        }
    }

    public abstract void aboutMe();
}