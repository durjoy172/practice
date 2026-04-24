namespace practice 
{ 
        internal class Program
        {
            static void Main(string[] args)
            {
                Person[] people = {
                    new Person{Name="alice",Age=30},
                    new Person{Name="Bob",Age=25},
                    new Person{Name="Charlie",Age=35}
                };
                PersonSorter sorter = new PersonSorter();
                sorter.Sort(people, CompareByAge);
                foreach(Person person in people)
                {
                    Console.WriteLine($"Name: {person.Name}, Age:{person.Age}");
                }

            }
            static int CompareByAge(Person person1, Person person2)
            {
                return person1.Age.CompareTo(person2.Age);
            }
        }
    }

 