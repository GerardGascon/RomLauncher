using System.Diagnostics;
using System;
using System.IO;

namespace RomLauncher{
	class Program{
		static void Main(){
			string appliactionPath = Path.GetDirectoryName(AppContext.BaseDirectory);
			string[] lines = File.ReadAllLines(appliactionPath + @"\emulatorPath.txt");

            DeleteBlastem();

			DirectoryInfo di = new DirectoryInfo(appliactionPath);
			appliactionPath = di.Parent.FullName + @"\out\rom.bin";
			Process.Start(@lines[0], appliactionPath);
		}

        static void DeleteBlastem(){
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + "$RD /S /Q \""+ @"%LOCALAPPDATA%\blastem" + "\"");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            process = Process.Start(processInfo);
            process.WaitForExit();

            // *** Read the streams ***
            // Warning: This approach can lead to deadlocks, see Edit #2
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            exitCode = process.ExitCode;

            Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
            Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
            Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");
            process.Close();
        }

    }
}