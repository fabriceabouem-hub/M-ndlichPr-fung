namespace VesionKontrollsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Fab", "Dyl", 15);
            Person person2 = new Person("Siut", "WIOU", 51);

            int result = person1.CompareTo(person2);
            if (result<0)
            {
                Console.WriteLine($"{person1.Name} ist junger alt {person2.Name} ");
            }
            if (result==0)
            {
                Console.WriteLine($"{person1.Name} ist gleicher alt {person2.Name} ");
            }
            if (result>0)
            {
                Console.WriteLine($"{person1.Name} ist junger alt {person2.Name} ");
            }
        }
    }
        class Person
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
