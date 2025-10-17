namespace StarPatterns;
/*
 
*   
*   *   
*   *   *   
*   *   *   *

*/
public class TrianglePattern2
{
    public static void Pattern()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < i ; j++)
            {
                Console.Write("*   ");
            }
            Console.WriteLine();
        }
    }
}