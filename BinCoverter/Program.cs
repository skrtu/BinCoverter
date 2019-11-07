using System;
using System.Collections.Generic;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Media;
using System.IO;

namespace BinCoverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // C:\Users\3kthe\source\repos\T1181Target\T1181Target\bin\x64\Release\T1181Target.exe
            string targetFile;

            Console.WriteLine("Target File to Covert:");
            targetFile = Console.ReadLine();

            string strBlob = BinaryCovert(targetFile);
            Console.WriteLine("\n" + strBlob + "\n");

            Console.ReadKey();
        }

        public static string BinaryCovert(string targetFile)
        {
            byte[] fileBuffer = File.ReadAllBytes(targetFile);
            string b64StringFile = Convert.ToBase64String(fileBuffer);

            byte[] bBlob = Convert.FromBase64String(b64StringFile);

            string stringBlob = string.Join("", bBlob);

            return stringBlob;
        }
    }
}
