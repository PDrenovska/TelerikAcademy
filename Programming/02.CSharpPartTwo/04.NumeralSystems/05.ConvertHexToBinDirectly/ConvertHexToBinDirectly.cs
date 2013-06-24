﻿/* Write a program to convert hexadecimal numbers to binary numbers (directly). */
using System;

class ConvertHexToBinDirectly
{
    static void Main()
    {
        string hexNumber = "A4";
        string binNumber = "";
        Console.Write("The heximal number {0} in binary numeral system is: ", hexNumber);

        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch (hexNumber[i])
            {
                case '0':
                    binNumber = "0000";
                    break;
                case '1':
                    binNumber = "0001";
                    break;
                case '2':
                    binNumber = "0010";
                    break;
                case '3':
                    binNumber = "0011";
                    break;
                case '4':
                    binNumber = "0100";
                    break;
                case '5':
                    binNumber = "0101";
                    break;
                case '6':
                    binNumber = "0110";
                    break;
                case '7':
                    binNumber = "0111";
                    break;
                case '8':
                    binNumber = "1000";
                    break;
                case '9':
                    binNumber = "1001";
                    break;
                case 'A':
                    binNumber = "1010";
                    break;
                case 'B':
                    binNumber = "1011";
                    break;
                case 'C':
                    binNumber = "1100";
                    break;
                case 'D':
                    binNumber = "1101";
                    break;
                case 'E':
                    binNumber = "1110";
                    break;
                case 'F':
                    binNumber = "1111";
                    break;
                default:
                    Console.WriteLine("The result is wrong! Please enter a correct hexadecimal number!");
                    break;
            }
            Console.Write(binNumber);
        }
        Console.WriteLine();
    }
}

