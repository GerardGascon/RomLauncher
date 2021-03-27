using System.Diagnostics;
using System;
using System.IO;

namespace RomExecuter{
    class Program{
        static void Main(string[] args){
            string appliactionPath = Path.GetDirectoryName(System.AppContext.BaseDirectory);
            DirectoryInfo di = new DirectoryInfo(appliactionPath);
            appliactionPath = di.Parent.FullName + @"\out\rom.bin";
            Process.Start(
                @"C:\sgdk\emulators\Regen0972\Regen.exe", 
                appliactionPath
            );
        }
    }
}
