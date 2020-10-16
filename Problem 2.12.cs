using System.Collections.Generic;
using System;
using System.Linq;

namespace Kaspersky.SafeBoard
{
    public class Program
    {
        private static Dictionary<string, int> DataType = new Dictionary<string, int> ()
        {
            ["None"] = 0,
            ["First"] = 1,
            ["Second"] = 2,
            ["Third"] = 3,
            ["Fourth"] = 4
        };
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)){
                string[] sep_input = input.Split(',');
                Console.WriteLine("Input data types:");
                foreach (string Key in DataType.Keys){
                    Console.WriteLine(Key + "(" +DataType[Key].ToString() + ")-" + sep_input.Count(str => str==Key || str==DataType[Key].ToString()));
                    sep_input = sep_input.Where(str => str != Key && str!=DataType[Key].ToString()).ToArray();
                }
                if (sep_input.Length != 0){
                    Console.WriteLine("Errors:\nNot valid input strings: "+ string.Join(",", sep_input));
                }
            }
            else{
                Console.WriteLine("No data");
            }

          
        }
    }
}
