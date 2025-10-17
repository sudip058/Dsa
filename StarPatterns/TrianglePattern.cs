namespace StarPatterns;
/*
 
   *
  ***
 *****
*******
 
 */
public class TrianglePattern
{
    public static void Pattern()
    {
        int sizeOfTriangel = 10;
        for (int i = 0; i<=sizeOfTriangel; i++)
        {
            for (int j = sizeOfTriangel; j > i; j--)
            {
                Console.Write(" ");
            }

            for (int k = 1 ; k < i + i ; k++)
            {
                Console.Write("*");
            }
            
            Console.WriteLine();
        }
    }
}