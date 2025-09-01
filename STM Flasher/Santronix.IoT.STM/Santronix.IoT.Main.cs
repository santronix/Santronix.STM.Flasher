using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Santronix.IoT.STM
{
    public class Flash
    {
        public class CommandProgressEventArgs : EventArgs
        {
            public string MessageType { get; }
            public string Message { get; }
            public int? ProgressPercent { get; }

            public CommandProgressEventArgs(string messageType, string message, int? progressPercent = null)
            {
                MessageType = messageType;
                Message = message;
                ProgressPercent = progressPercent;
            }
        }
        public class CMD
        {
            public event EventHandler<CommandProgressEventArgs> OutputReceived;
            public event EventHandler<CommandProgressEventArgs> ErrorReceived;

            public async Task<string> ExecuteCommandAsync(string command, string args = "")
            {
                try
                {
                    var psi = new ProcessStartInfo("cmd.exe", $"/c {command} {args}")
                    {
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    var ps = new Process { StartInfo = psi, EnableRaisingEvents = true };

                    ps.OutputDataReceived += (s, ea) =>
                    {
                        if (!string.IsNullOrEmpty(ea.Data))
                        {
                            int? percent = null;
                            var match = Regex.Match(ea.Data, @"(\d{1,3})%");
                            if (match.Success && int.TryParse(match.Groups[1].Value, out int p))
                            {
                                percent = Math.Min(p, 100);
                            }
                            OutputReceived?.Invoke(this, new CommandProgressEventArgs("INFO", ea.Data, percent));
                        }
                    };

                    ps.ErrorDataReceived += (s, ea) =>
                    {
                        if (!string.IsNullOrEmpty(ea.Data))
                        {
                            ErrorReceived?.Invoke(this, new CommandProgressEventArgs("ERROR", ea.Data));
                        }
                    };

                    ps.Start();
                    ps.BeginOutputReadLine();
                    ps.BeginErrorReadLine();
                    await Task.Run(() => ps.WaitForExit());

                    return ps.ExitCode == 0 ? "PASS" : $"FAIL : {ps.ExitCode}";
                }
                catch (Exception ex)
                {
                    ErrorReceived?.Invoke(this, new CommandProgressEventArgs("EXCEPTION", ex.Message));
                    return "FAIL";
                }
            }
        }
    }
}
