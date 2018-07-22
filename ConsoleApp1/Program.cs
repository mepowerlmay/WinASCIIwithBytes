using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string value = "100011001000";

            //Convert.ToByte(value, 2);

         string result =    BinaryStringToHexString(value);


            Console.WriteLine(result);
            Console.ReadLine();
       //     BitConverter.GetBytes(value);

        }

        public static string BinaryStringToHexString(string binary)
        {
            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

            // TODO: check all 1's or 0's... Will throw otherwise

            int mod4Len = binary.Length % 8;
            if (mod4Len != 0)
            {
                // pad to length multiple of 8
                binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < binary.Length; i += 8)
            {
                string eightBits = binary.Substring(i, 8);             


                try
                {
                    byte tempbyte = Convert.ToByte(eightBits, 2);                    

                  //  Console.WriteLine("   Converted '{0}' to {1}.", eightBits, 2);
                }
                catch (FormatException)
                {
                    Console.WriteLine("   '{0}' is not in the correct format for a base {1} byte value.",
                                      eightBits, 2);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("   '{0}' is outside the range of the Byte type.", eightBits);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("   '{0}' is invalid in base {1}.", eightBits, 2);
                }


                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }

            return result.ToString();
        }
    }
}
