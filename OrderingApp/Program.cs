namespace OrderingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var code = new string[6] { "F1", "F2", "F3", "F4", "F5", "F6" };
            var menu = new string[6]
            {
                "Burger",
                "Hotdog",
                "Fish & Chips",
                "Ham & Egg",
                "Chicken",
                "Finish transaction"
            };

            var price = new decimal[6] { 10.00m, 8.00m, 15.00m, 7.00m, 10.00m, 0 };

            for (int i = 0; i < code.Length; i++)
            {
                Console.WriteLine(code[i]  + menu[i] + price[i]  );
            }

            Console.ReadKey();
        }
    }
}