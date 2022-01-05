using System.Diagnostics;
using System;
using System.IO;

namespace RomLauncher{
	class Program{
		static void Main(){
			string appliactionPath = Path.GetDirectoryName(AppContext.BaseDirectory);
			string[] lines = File.ReadAllLines(appliactionPath + @"\emulatorPath.txt");

			System.Diagnostics.Process.Start(appliactionPath + @"\delete-blastem.bat");

			DirectoryInfo di = new DirectoryInfo(appliactionPath);
			appliactionPath = di.Parent.FullName + @"\out\rom.bin";
			Process.Start(@lines[0], appliactionPath);
		}
	}
}