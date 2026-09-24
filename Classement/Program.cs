using System.Collections.Immutable;

namespace Classement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*List<int> Mylist = new List<int>()
            {
                1,2,3,4,5,6
            };
            Mylist.Add(42);
            Mylist.Add(23);
            Mylist.Sort();
            foreach(int l in Mylist)
            Console.WriteLine(l);*/

            /*Dictionary<int, string> MyDictionary = new Dictionary<int, string>()
            {
                { 2 , "Tom" },
                { 3 , " Müller"},
                { 6 , " Fabrice"}
            };
            MyDictionary.Add(4, "Schrödinger");
            foreach (var dict in MyDictionary)
            {
                Console.WriteLine(dict);
            }*/
            SortedList<int, string> MySortedList = new SortedList<int, string>()
            {
                { 2 , "Tom" },
                { 3 , " Müller"},
                { 6 , " Fabrice"}
            };
            MySortedList.Add(4, "Schrödinger");
            foreach (var dict in MySortedList)
            {
                Console.WriteLine(dict);
            }
        }
    }
}
