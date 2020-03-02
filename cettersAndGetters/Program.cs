using System;

namespace cettersAndGetters
{
    class Program
    {

        class Person
        {
            class Movie
            {
                string title;
                string director;
                string ratings;
                int userRating;
            }
            string name;
            string gender;
            int age;
            string id;

            public Person(string _name, string _gender, int _age, string _id)
            {
                Name = _name;
                Gender = _gender;
                Age = _age;
                Id = _id;
                
            }

            public string Name
            {
                get { return name; }
                set
                {
                    if (value == "male" || value == "female")
                    {
                        gender = value;
                    }
                    else
                    {

                    }

                }
            }

            public string Gender
            {
                get { return gender; }
                set
                {
                    if (value == "male" || value == "female")
                    {
                        gender = value;
                    }
                    else
                    {
                        gender = "undefined";
                    }
                }
            }

            public int Age
            {
                get { return age; }
                set
                {

                }
            }

            

            public string Id
            {
                get { return id; }
                set
                {
                    if (value.Length == 11)
                    {
                        id = value;
                    }
                    else
                    {
                        id = "undefined";
                    }

                    
                    



                    static void Main (string[] args)
                    {
                        Person newPerson = new Person("John", "male", -34, "39185815865");
                       Console.WriteLine($"a new person {newPerson.Name}");
                       newPerson.Name = "Johanna";
                       Console.WriteLine($"a new person {newPerson.Name}");
                       newPerson.Gender = "Fairy";
                        Console.WriteLine($"Gender: {newPerson.Gender}");
                        Console.WriteLine($" Age:  {newPerson.Age}");

                    }
                }
            }
        }