using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* This app is related to a PHP-question from ZendExam.com
 * See related PHP-code on Github: https://github.com/fritsb/itvitae_php/blob/master/hexadecbinary.php
 * See related question on zendexam.com: http://www.zendexam.com/question/316/consider-the-use-of-bitwise-operators-on-hexadecimal-values-what-is-the-output-of-the-following-php-script/ 
 * 
 * Subjects: Hexadecimals, Binary, Bitwise operators 
 *
 * Question "Consider the use of bitwise operators on hexadecimal values. What is the output of the following code?"
 * 
 * */

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0xF0;
            int b = 0x0F;

            int c1 = a & b;  // bitwise operator AND
            int c2 = a | b;  // bitwise operator OR 
            int c3 = a ^ ( b | a ); // bitwise operators XOR + OR
            
            String output = String.Format("0x{0}, 0x{1}, 0x{2}", 
                c1.ToString("X"), c2.ToString("X"), c3.ToString("X") );
            Console.WriteLine(output);

            // STEP 1: calculate values of a and b manually, or show them on screen with ToString() method:
            // int a = 0xF0; // F = 15, 0 = 0; means (15 * 16) + 0 = 240   
            // int b = 0x0F; // 0 = 0, F = 15; means ( 0 * 16) + 15 = 15    
            // OR:  Console.WriteLine("value a: " + a.ToString() + ", b:" + b.ToString() + "");


            // STEP 2: calculate binary values
            // 240 = 128 + 64 + 32 + 16 = 11110000
            // 15  = 8 + 4 + 2 + 1      = 00001111

            // STEP 3: Use binary values with the bitwise operators 
            // int c1 = a & b; // 11110000 & 00001111 = 00000000
            // & = the bitwise AND operator; means it checks if a bit is set in both values.
            //
            // int c2 = a | b; // 11110000 | 00001111 = 11111111
            // | = the bitwise OR operator; means it checks if a bit is set in one of the values
            // 
            // int c3 = a ^ ( b | a ); // 11110000 ^ 11111111 = 00001111
            // ^ = the bitwise XOR operator; means it checks if a bit is set in one of the values, but not both
            // 

            // STEP 4: Transform binary values to normal values 
            // c1 has binary value 00000000, means 0
            // c2 has binary value 11111111, means 255 (128 + 64 + 32 + 16 + 8 + 4 + 2 + 1)
            // c3 has binary value 00001111, means 15 (8 + 4 + 2 +1)
            //

            // STEP 5: Transform values to hexadecimal values 
            // c1 has value 0, means hexadecimal 0 = in C# 0x0
            // c2 has value 255, means hexadecimal FF = in C# 0xFF ( ( 15 * 16) + 15)
            // c3 has value 15, means hexadecimal 0F = in PHP 0xF  ( (  0 * 16) + 15)  

            // STEP 6: Now check the output of the program to understand it all. 


            Console.WriteLine("Press enter to close...");
            Console.ReadLine();


            /* MORE INFORMATION:  
             * demonstrates all the bitwise operators available in C# : https://www.tutorialspoint.com/csharp/csharp_bitwise_operators.htm
             * 
             * 
             */
        }
    }
}
