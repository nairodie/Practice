internal class Program
{
    private static void Main(string[] args)
    {
        var a  = "Stress";
        //Console.WriteLine(a[3]);

        foreach(char item in a)
        {
            if (item.ToString() == "s" || item.ToString() == "S")
            {
                Console.WriteLine(item);
            }
        }
    }
}