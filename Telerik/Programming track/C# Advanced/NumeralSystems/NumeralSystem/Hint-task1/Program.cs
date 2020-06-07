using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hint_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var hint = new string[]
{
    "200", "303", "315", "52", "301", "241", "302", "321", "52", "244", "253", "251",
    "253", "312", "311", "52", "244", "303", "245", "311", "52", "312", "252", "253",
    "311", "52", "302", "313", "301", "245", "310", "241", "300", "52", "311", "321",
    "311", "312", "245", "301", "52", "252", "241", "314", "245", "143", "52", "201",
    "311", "52", "312", "252", "245", "310", "245", "52", "241", "302", "52", "241",
    "304", "304", "310", "303", "304", "310", "253", "241", "312", "245", "52", "242",
    "313", "253", "300", "312", "113", "253", "302", "52", "250", "313", "302", "243",
    "312", "253", "303", "302", "241", "300", "253", "312", "321", "143", "21", "14",
    "215", "312", "310", "253", "302", "251", "114", "214", "245", "304", "300", "241",
    "243", "245", "52", "243", "241", "302", "52", "311", "253","301", "304", "300",
    "253", "250", "321", "52", "312", "252", "253", "302", "251", "311", "52", "241",
    "52", "300", "303", "312", "112", "52", "254", "313", "311", "312", "52", "242",
    "245", "52", "243", "241", "310", "245", "250", "313", "300", "52", "253", "302",
    "52", "315", "252", "241", "312", "52", "303", "310","244", "245", "310", "52",
    "321", "303", "313", "52", "310", "245", "304", "300", "241", "243", "245", "21",
    "14", "220", "252", "253", "302", "255", "52", "241", "242", "303", "313", "312",
    "52", "312", "252", "245", "52", "244", "241", "312", "241", "52", "312", "321",
    "304", "245", "311", "52", "303", "250", "52", "312", "252", "245", "52", "312",
    "252", "310", "245", "245", "52", "302", "313", "301", "242", "245", "310", "311",
    "52", "241", "302", "244", "52", "312", "252", "245", "52", "310", "245", "311",
    "313", "300", "312", "52", "113", "52", "252", "303", "315", "52", "301", "313",
    "243", "252", "52", "253", "311", "52", "122", "234", "130", "120", "52", "110",
    "52", "122", "234", "130", "120", "52", "110", "52", "122", "234", "130", "120", "143"
};
            //int FirstSysBase = int.Parse(Console.ReadLine());
            //string number = Console.ReadLine();
            //int SecSysBase = int.Parse(Console.ReadLine());
            ulong[] dec = new ulong[hint.Length];
            char[] sam = new char[hint.Length];
            for (int i = 0; i < hint.Length; i++)
            {
                dec[i]= ConvertToDecimalFromOtherNumSystem(hint[i], 6);
                sam[i] = (char)dec[i];
            }
            Console.WriteLine(string.Join(" ",dec));
            Console.WriteLine(string.Join(" ",sam));
            //ulong DecimalNumber = ConvertToDecimalFromOtherNumSystem(hint[1], FirstSysBase);
            //Console.WriteLine(ConvertFromDecimalToAnotherNumSystem(DecimalNumber, SecSysBase);

        }
        static ulong ConvertToDecimalFromOtherNumSystem(string number, int NumBase)
        {
            ulong DecimalNumber = 0;

            foreach (var digit in number)
            {
                int digitvalue;
                if (char.IsDigit(digit))
                {
                    digitvalue = digit - '0';
                }
                else
                {
                    digitvalue = digit - 'A' + 10;
                }
                DecimalNumber = DecimalNumber * (ulong)NumBase + (ulong)digitvalue;

            }
            return DecimalNumber;
        }

        static string ConvertFromDecimalToAnotherNumSystem(ulong number, int NumBase)
        {
            string ConvertedNumber = "";
            string HexDigits = "0123456789ABCDEF";
            do
            {
                ulong value = number % (ulong)NumBase;
                number /= (ulong)NumBase;
                char digit = HexDigits[(int)value];
                ConvertedNumber = digit + ConvertedNumber;
            } while (number > 0);
            return ConvertedNumber;
        }
    }
}
