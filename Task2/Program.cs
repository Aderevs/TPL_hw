namespace Task2
{
    internal class Program
    {
        static void Method1()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Doing first method");
                Thread.Sleep(300);
            }
        }
        static void Method2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Doing second method");
                Thread.Sleep(300);
            }
        }
        static void Main(string[] args)
        {

            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = 2;

            Parallel.Invoke(options, Method1, Method2);

            Console.WriteLine("The main stream is completed");
        }
    }
}
