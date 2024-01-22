using System;

public static class PersonProcesor

{

    public static Person FindOldestPerson(Person[] people)
    {
        if (people == null || people.Length == 0)
            return null;

        Person oldestPerson = people[0];

         foreach (var person in people)
        {
            if (person.Age > oldestPerson.Age)
            {
                oldestPerson = person;
            }
        }

        return oldestPerson;
    }
        }
        
    

