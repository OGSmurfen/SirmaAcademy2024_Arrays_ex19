internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split(" ").Select(e => int.Parse(e)).ToArray();
        int even = 0; int odd = 0;
        foreach(int i in arr)
        {
            if(i % 2 == 0)
            {
                even += i;
            }
            else
            {
                odd += i;
            }

            
        }

        Console.WriteLine($"{even} {odd}");
    }
}