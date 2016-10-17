using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class CriptoCS
    {
        static void Main(string[] args)
        {
            string firstAsString = Console.ReadLine();
            char sing = char.Parse(Console.ReadLine());
            string secondAsString = Console.ReadLine();

            BigInteger first = FirstToDecimal(firstAsString);
            BigInteger second = AnyToDecimal(secondAsString, 7);

            BigInteger result = 0;

            if (sing == '+')
            {
                result = checked(first + second);
            }
            else
            {
                result = checked(first - second);
            }

            Console.WriteLine(DecimalToAny(result, 9));
        }

        private static string ConvertAnyToAny(string number, uint fromBase, uint toBase)


        {


            return DecimalToAny(AnyToDecimal(number, fromBase), toBase);


        }





        private static BigInteger AnyToDecimal(string number, uint baseSystem)


        {


            BigInteger result = 0;


            


            for (int i = 0; i < number.Length; i++)


            {


                BigInteger CurrentNumber = (uint)(char.IsDigit(number[i]) ? number[i] - '0' : number[i] - 'A' + 10);


                int pow = number.Length - i - 1;


                result = CurrentNumber + result * baseSystem;


            }





            return result;

        }
        private static BigInteger  FirstToDecimal(string number)


        {

            uint baseSystem = 26;
            BigInteger result = 0;


            for (int i = 0; i < number.Length; i++)
            {
                BigInteger CurrentNumber = (uint)(number[i] - 'a');
                result = CurrentNumber + result * baseSystem;
            }


            //for (int i = number.Length - 1; i >= 0; i--)


            //{


            //    BigInteger CurrentNumber = (uint)(number[i] - 'a');


            //    int pow = number.Length - i - 1;


            //    result += CurrentNumber * Pow(baseSystem, pow);


            //}





            return result;


        }






        private static string DecimalToAny(BigInteger number, uint baseSystem)


        {


            StringBuilder result = new StringBuilder();





            do


            {


                int numberToAdd = (int)(number % baseSystem);


                result.Insert(0, (char)(numberToAdd <= 9 ? numberToAdd + '0' : 'A' + numberToAdd - 10));


                number /= baseSystem;


            } while (number > 0);





            return result.ToString();


        }

        static BigInteger Pow(BigInteger num, int pow)
        {
            BigInteger result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }

            return result;
        }

    }
}
