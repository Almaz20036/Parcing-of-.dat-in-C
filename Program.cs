using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace parcing_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Specify the input file path
            string inputFile = "../../../blockchain/input.dat";

            // Open the input file and read the long string
            string longString;
            using (StreamReader reader = new StreamReader( inputFile))
            {
                longString = reader.ReadToEnd().Trim();
            }

            // Split the long string into individual strings by spaces
            string[] strings = longString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Skip the first letter of the first string
            strings[0] = strings[0].Substring(1);

            // Create a new CSV file and write the strings to it
            string outputFile = "../../../csv/output.csv";
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                string[] stringNames = { "magic_bytes", "size", "version", "previous_block", "merkle_root", "time", "bits", "nonce", "tx_count", "transaction_data" };
                for (int i = 0; i < strings.Length; i++)
                {
                    writer.WriteLine($"{stringNames[i]}: {strings[i]}");
                }
            }
        }
    }
}