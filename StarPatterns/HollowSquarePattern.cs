namespace StarPatterns;

/*
 
* * * * * 
*       *
*       *
*       *
*       *
*       *
* * * * *
 
 */
public class HollowSquarePattern
{
    public static void Pattern()
    {
        // int n = 5;
        // for (int i = 0; i <= n; i++)
        // {
        //     if (i == 0)
        //     {
        //         for (int j = 0; j < n; j++)
        //         {
        //             Console.Write("* ");
        //         }
        //         Console.WriteLine();
        //         continue;
        //     }
        //
        //     for (int j = 0; j <= n; j++)
        //     {
        //         if (j == 0)
        //         {
        //             Console.Write('*');
        //             continue;
        //         }
        //         Console.Write(' ');
        //         if (j == n)
        //         {
        //             Console.Write("  *");
        //             Console.WriteLine();
        //         }
        //     }
        //     if (i == n)
        //     {
        //         for (int j = 0; j < n; j++)
        //         {
        //             Console.Write("* ");
        //         }
        //         Console.WriteLine();
        //     }
        // }
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                bool isBorder = (i == 0 || i == n - 1 || j == 0 || j == n - 1);
                if (isBorder)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}