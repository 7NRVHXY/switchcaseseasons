namespace switchcaseseasons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = "winter";
            switch (season)
            {
                case "winter":
                    Console.WriteLine("november , december , january");
                    break;
                case "spring":
                    Console.WriteLine("february , march , april");
                    break;
                case "summer":
                    Console.WriteLine("may , june , july");
                    break;
                case "autumn":
                    Console.WriteLine("august , september , october");
                    break;





            }
        }
    }
}