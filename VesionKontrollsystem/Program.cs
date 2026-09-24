namespace VesionKontrollsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person [] personen = new Person[]
            {
                  person1 ("Fab", "Dyl", 15),
                  person2 ("Siut", "WIOU", 10)
            };
            Array.Sort(personen);
            foreach (Person p in personen)
            {
                Console.WriteLine($"{p.Name} : {p.Alt}");
            }
        }
    }
        class Person : IComparable<Person>
        {
            public string Name {get; set;}
            public string Vorname {get; set;}
            public int Alt {get; set;}
            public Person(string name, string vorname, int alt)
            {
                Name = name;
                Vorname = vorname;
                Alt = alt;
            }
            public int CompareTo(Person other)
            {
                if(other == null) return 1;
               {
                  return Alt.CompareTo(other.Alt) ;
               }
            }
        }
}
