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
            string targetFile;

            string strTarget = Convert.ToString(args[0]);

            Console.WriteLine("Target File to Covert: " + strTarget);
            targetFile = strTarget;

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
