﻿using Dolgov_Task_1._2;
using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _1._2._4._VALIDATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "text.txt";
            string text = FileReader.ReadFile(fileName);

            string separators = @"([!?.])";

            string[] arrFromText = Regex.Split(text, separators);

            StringBuilder result = new StringBuilder();
            FindFirstLetter(arrFromText, result);

            Console.WriteLine(result.ToString());
        }

        private static void FindFirstLetter(string[] arrFromText, StringBuilder result)
        {
            for (int i = 0; i < arrFromText.Length; i++)
            {
                for (int j = 0; j < arrFromText[i].Length; j++)
                {
                    if (arrFromText[i][j] != ' ')
                    {
                        result.Append(arrFromText[i][j].ToString().ToUpper());
                        result.Append(arrFromText[i].Substring(j + 1));
                        break;
                    }
                    else
                        result.Append(arrFromText[i][j]);
                }
            }
        }
    }
}
