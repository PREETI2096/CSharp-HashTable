namespace Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Hashtable Program");
            HashTable<string> hashtable = new HashTable<string>(5);
            hashtable.Add("Preeti");
            hashtable.Add("Usha");
            hashtable.Add("priya");
            hashtable.Add("smriti");
            hashtable.Add("sakshi");
        }
    }
}