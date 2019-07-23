using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaSimpleArraySum
{
    class Program
    {
        static int SimpleArraySum(int[] ar)
        {
            int hasil = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                hasil = ar[i] + hasil;
            }
            return hasil;
        }    
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable(""), true);

        int arCount = Convert.ToInt32(Console.ReadLine());
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = SimpleArraySum(ar);

        Console.WriteLine(result);
        Console.ReadLine();

        //textWriter.Flush();
        //textWriter.Close();
        }
    }
}
