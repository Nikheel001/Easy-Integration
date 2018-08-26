using System;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
namespace CHECK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p1= new Program();
            p1.run_cmd();
        }

        private void run_cmd()
        {
            //string fileName = @"C:\Users\home\workspace\C#\CHECK\sample.py";
            string fileName = @"sample.py Readme.txt";

            Process p = new Process();
            //p.StartInfo = new ProcessStartInfo(@"C:\Program Files\Python36\python.exe", fileName)
			p.StartInfo = new ProcessStartInfo(@"python.exe", fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}