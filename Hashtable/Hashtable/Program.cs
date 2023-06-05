namespace Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Hashtable Program");
            HashTable<string> hashtable = new HashTable<string>(4);
            hashtable.Add("Preeti");
            hashtable.Add("isha");
            hashtable.Add("priya");
            hashtable.Add("Swati");
            hashtable.Display();
            hashtable.Search("nisha");
            hashtable.Delete("Preeti");
           
        }
    }
}