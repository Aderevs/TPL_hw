namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] bigArr = new int[1_000_000];
            Random rnd = new Random();
            Parallel.For(0, bigArr.Length, (int i) => bigArr[i] = rnd.Next());
            ParallelQuery<int> odd = from element in bigArr.AsParallel()
                                         where element % 2 != 0
                                         select element;
            foreach (var item in odd)
            {
                Console.WriteLine(item);
                Thread.Sleep(10);
            }
        }
    }
}
