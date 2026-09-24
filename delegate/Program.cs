namespace Notion_deleg;

delegate int Rechnendelegate(int a, int b);// delegate deklarieren
internal class Program
{
    static void Main(string[] args)
    {
        
        Rechnendelegate rechner = Rechnen.Addieren;// delgateTyp zuweisen
        int ergebnis = rechner(6,9); // Variable erstellen und Methode zuweisen
        Console.WriteLine(ergebnis);
    }
}
 public class Rechnen
 {
    public static int Addieren(int x, int y)
    {
        return x + y;
    }
    public static int Subtrahieren(int x, int y)
    {
        return x + y;
    }
 }
    
   

