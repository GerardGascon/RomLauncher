using System.Diagnostics;
using System;
using System.IO;

namespace RomExecuter{
    class Program{
        static void Main(string[] args){
            string appliactionPath = Path.GetDirectoryName(System.AppContext.BaseDirectory);
            string[] lines = System.IO.File.ReadAllLines(appliactionPath + @"\emulatorPath.csv");

            DirectoryInfo di = new DirectoryInfo(appliactionPath);
            appliactionPath = di.Parent.FullName + @"\out\rom.bin";
            Process.Start(@lines[0], appliactionPath);
        }
    }
}
