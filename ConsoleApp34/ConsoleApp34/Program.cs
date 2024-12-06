namespace ConsoleApp29
{
    class Pogram
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var proizvedenie = 1;
            for (int i = a; i <= b; i++)
            {
                proizvedenie *= i;
                Console.WriteLine(proizvedenie);
            }
        }
    }
}