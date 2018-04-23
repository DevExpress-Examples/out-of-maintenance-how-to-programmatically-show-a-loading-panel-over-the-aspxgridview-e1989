using System;
using System.Collections.Generic;

public class Person {
    public static List<Person> GetDemoData() {
        List<Person> list = new List<Person>();
        list.Add(new Person() { ID = 1, FirstName = "John", LastName = "Doe" });
        list.Add(new Person() { ID = 2, FirstName = "Jane", LastName = "Doe" });
        return list;
    }

    public Person() {
    }

    private int _ID;
    public int ID {
        get { return _ID; }
        set {
            _ID = value;
        }
    }
    

    private string _FirstName;
    public string FirstName {
        get { return _FirstName; }
        set {
            _FirstName = value;
        }
    }

    private string _LastName;
    public string LastName {
        get { return _LastName; }
        set {
            _LastName = value;
        }
    }
}