namespace S04_list;

class Program
{
    static void Main(string[] args)
    {
        List<string> stringCollection = new List<string>();

        stringCollection.Add("Hello");
        stringCollection.Add("World");
        stringCollection.Add("Paradise");

        stringCollection.RemoveAt(0);

        stringCollection.Remove("Paradise");

        stringCollection[0] = "Heaven";

        foreach (string element in stringCollection)
        {
            Console.WriteLine(element);
        }
    }
}
