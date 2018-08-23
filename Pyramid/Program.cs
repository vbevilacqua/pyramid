using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Pyramid
{
    public static class Program
    {
        private static int result = 0;
        private static int lastColumn = 0;

        public static void Main(string[] args)
        {
            var result = GetSum(GetInput());

            Console.WriteLine("The Maximum Sum Is:  " + result);
            //Console.ReadKey();
        }

        public static string[] GetSum(string input)
        {
            return TransformInputToArray(input);
        }

        private static string GetInput()
        {
            const string input = @"
            215
            192 124
            117 269 442
            218 836 347 235
            320 805 522 417 345
            229 601 728 835 133 124
            248 202 277 433 207 263 257
            359 464 504 528 516 716 871 182
            461 441 426 656 863 560 380 171 923
            381 348 573 533 448 632 387 176 975 449
            223 711 445 645 245 543 931 532 937 541 444
            330 131 333 928 376 733 017 778 839 168 197 197
            131 171 522 137 217 224 291 413 528 520 227 229 928
            223 626 034 683 839 052 627 310 713 999 629 817 410 121
            924 622 911 233 325 139 721 218 253 223 107 233 230 124 233";
// 215 + 192 + 269 + 836 + 805 + 728 + 433  + 528 + 863 + 632 + 931 + 778 + 413 + 310 + 253 = 8186
            return input;
        }

        private static string[] TransformInputToArray(string input)
        {
            return input.Split(new[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
        }

        private static int[,] TransformTo2Darray(this string[] arrayOfRowsByNewlines)
        {
            var tableHolder = new int[arrayOfRowsByNewlines.Length, arrayOfRowsByNewlines.Length + 1];

            for (var row = 0; row < arrayOfRowsByNewlines.Length; row++)
            {
                var eachCharactersInRow = arrayOfRowsByNewlines[row].ExtractNumber();

                for (var column = 0; column < eachCharactersInRow.Length; column++)
                    tableHolder[row, column] = eachCharactersInRow[column];
            }
            return tableHolder;
        }
    }
}
