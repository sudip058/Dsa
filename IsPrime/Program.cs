namespace IsPrime;

class Program
{
    static void Main(string[] args)
    {
        int num;
        int flag = 0;
        int temp = 0;

        Console.Write("Enter a number:");
        num = int.Parse(Console.ReadLine());

        for (int i = 2; i < num && flag == 0; i++)
        {
            if (num % i == 0)
            {
                flag = 1;
                temp = i;
            }
        }

        if (flag == 0)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine($"Not Prime , divided by {temp}");
        }
        
    }
}