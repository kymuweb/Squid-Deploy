using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace TentacleService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class TentacleService : ITentacleService
    {
        public string RunTfsToEnv(string folder, string environmet)
        {
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;

            // TODO: Include here the command you want to execute in the remote machine
            string command = "ipconfig";

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;

            // *** Redirect the output ***
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            process = Process.Start(processInfo);
            process.WaitForExit();

            // *** Read the streams ***
            // Warning: This approach can lead to deadlocks
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            exitCode = process.ExitCode;            

            File.WriteAllText("C:/TentacleService/TentacleWinService/bin/Debug/TentacleService_output.log", output);
            File.WriteAllText("C:/TentacleService/TentacleWinService/bin/Debug/TentacleService_error.log", error);
            File.WriteAllText("C:/TentacleService/TentacleWinService/bin/Debug/TentacleService_exit.log", exitCode.ToString());

            process.Close();

            if (exitCode == 1)
            {
                //return exitCode.ToString();
                return command + Environment.NewLine + error;
            }
            else
            {
                return "1";
            }

        }
    }
}
