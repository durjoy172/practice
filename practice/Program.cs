namespace practice
{
    public delegate int Comparison<T>(T x, T y);


    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    public class PersonSorter
    {
        public void Sort(Person[] people, Comparison<Person> comparison)
        {
            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (comparison(people[i], people[j]) > 0)
                    {
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }


                }
            }
        }
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
}
 