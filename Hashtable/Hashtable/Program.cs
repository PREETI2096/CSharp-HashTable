namespace Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Hashtable Program");
            HashTable<string> hashtable = new HashTable<string>(2);
            hashtable.Add("Preeti");
            hashtable.Add("isha");
            hashtable.Display();
        }
    }
}