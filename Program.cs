using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Zachary_Renyhart_Assignment_2._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimpleMath.Add(6, 2)); //This is doing the math for the methods below
            Console.WriteLine(SimpleMath.Add(.236M, .256M, .236M));
            Console.WriteLine(SimpleMath.Add(19.99F, 2.34F));
            Console.WriteLine(SimpleMath.Add(2.45F, 1.44F, 6.55F));

        }
    }


   

    static public class SimpleMath
    {
        static public int Add(int num1, int num2)
        {
        return num1 + num2;
        }


        static public decimal Add(decimal num1, decimal num2, decimal num3)
        {
            return num1 + num2 + num3;
        }

        static public float Add(float num1, float num2)
        {
            return num1 * num2;
        }

        static public float Add(float num1, float num2, float num3)
        {
            return (num1 * num2) * num3;
        }


    }
}
