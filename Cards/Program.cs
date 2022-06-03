namespace Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
           
            Suits suit = (Suits)random.Next(4);
            Values value = (Values)random.Next(1, 14);

            Console.WriteLine($"Twoja karta to {value} {suit}");


        }
    }
}