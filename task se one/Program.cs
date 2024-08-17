namespace task_se_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("number of small carpes:");
            int smaalCarpets = int.Parse(Console.ReadLine());
            Console.WriteLine("number of larg carpes:");
            int largCarpets = int.Parse(Console.ReadLine());
            Console.WriteLine("price per small carpets: $25");
            Console.WriteLine("price per larg carpets: $35");
            int cost = (smaalCarpets * 25) + (largCarpets * 35);
            Console.WriteLine($"cost:{cost}");
            Console.WriteLine("tax:$6.6");
            double tax = 6.0 / 100 * cost ;
            double totalEstimate = tax + cost;
            Console.WriteLine($"total estimate:${totalEstimate}");
            Console.WriteLine("this estimate is valid for 30 days");

        }
    }
}
