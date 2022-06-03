namespace Cards
{
    internal class Program
    {
        private static readonly Random random = new Random();
        static void Main(string[] args)
        {
                       
           Card card = new Card((Values)random.Next(4), (Suits)random.Next(1, 14));
           Console.WriteLine(card.Name);


        }
    }
}