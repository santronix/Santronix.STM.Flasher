using STM_Flasher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Santronix.IoT.STM.Flash;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace STM_Flasher
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer loopTimer;
        private TimeSpan elapsed;
        private TimeSpan totalElapsed;
        private Boolean stopLoop = false;
        private int failCount = 0;
        private int passCount = 0;

        List<TestActivity> activities;
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;
        }

        private void buttonScanPort_Click(object sender, EventArgs e)
        {
            comboBoxPort.Items.Clear();
            comboBoxPort.Text = string.Empty;
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            comboBoxPort.Items.AddRange(ports);

            if (ports.Length > 0)
                comboBoxPort.SelectedIndex = 0;
            textBoxLog.AppendText($"Found {ports.Length} COM ports.{Environment.NewLine}");
            textBoxLog.AppendText($"{Environment.NewLine}");
        }

        private async void buttonFlash_Click(object sender, EventArgs e)
        {
            int loops = 0;
            elapsed = new TimeSpan();
            totalElapsed = new TimeSpan();
            if (comboBoxPort.SelectedItem == null)
            {
                textBoxLog.AppendText($"Please select a COM port first.{Environment.NewLine}");
                return;
            }

            if (String.IsNullOrEmpty(textBoxFlashFile.Text))
            {
                textBoxLog.AppendText($"Please select a Flash file port first.{Environment.NewLine}");
                return;
            }

            if (String.IsNullOrEmpty(textBoxTestplan.Text))
            {
                textBoxLog.AppendText($"Testplan need to be loaded first and should have at least one activity.{Environment.NewLine}");
                return;
            }

            // Load and parse XML
            XDocument doc = XDocument.Load(textBoxTestplan.Text);

            activities = doc.Descendants("TestActivity")
                .Select(x => new TestActivity
                {
                    Id = (int)x.Element("Id"),
                    Name = (string)x.Element("Name"),
                    Command = (string)x.Element("Command")
                })
                .ToList();

            // Example: print to console (you can bind to grid/list instead)
            foreach (var activity in activities)
            {
                textBoxLog.AppendText($"{activity.Id}: {activity.Name} -> {activity.Command}{Environment.NewLine}");
            }

            textBoxLog.AppendText($"Loaded {activities.Count} Test Activities!{Environment.NewLine}");

            buttonFlash.Enabled = false;
            checkBoxLoop.Enabled = false;
            textBoxLoopCount.Enabled = false;
            buttonScanPort.Enabled = false;
            comboBoxPort.Enabled = false;
            buttonStop.Enabled = true;
            textBoxFlashFile.Enabled = false;
            buttonBrowse.Enabled = false;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();

            loopTimer = new System.Windows.Forms.Timer();
            loopTimer.Interval = 1000;
            loopTimer.Tick += LoopTimer_Tick;
            loopTimer.Start();
            string selectedPort = comboBoxPort.SelectedItem.ToString();

            int loopCount = 1;
            if (checkBoxLoop.Checked)
            {
                loopCount = int.Parse(textBoxLoopCount.Text);
            }
                
            if (loopCount > 0)
            {
                passCount = 0;
                failCount = 0;
                labelLoopExecuted.Text = "Loop Executed : 0";
                labelLoopPass.Text = "PASS : 0";
                labelLoopFail.Text = "FAIL : 0";
                for (int i = 0; i < loopCount; i++)
                {
                    if (stopLoop)
                        break;
                    textBoxLog.AppendText($"Starting flashing on {selectedPort}...{Environment.NewLine}");
                    Boolean error = false;
                    var executor = new CMD();
                    executor.OutputReceived += (s, ea) =>
                    {
                        AppendOutput("INFO", ea.Message);
                        if (ea.ProgressPercent.HasValue)
                        {
                            this.Invoke((MethodInvoker)(() =>
                            {
                                progressBarFlash.Value = Math.Min(ea.ProgressPercent.Value, 100);

                            }));
                        }
                    };

                    executor.ErrorReceived += (s, ea) =>
                    {
                        AppendOutput("ERROR", ea.Message);
                    };

                    foreach(TestActivity ta in activities)
                    {
                        String command = ta.Command;
                        command = command.Replace("{selectedPort}", selectedPort).Replace("{flashFile}", textBoxFlashFile.Text);
                        String testName = ta.Name;
                        textBoxLog.AppendText("#### COMMAND : " + command + $"{Environment.NewLine}");

                        String result = await executor.ExecuteCommandAsync(command, "");
                        if (result != null && !result.Equals("PASS"))
                        {
                            setFail(result);
                            error = true;
                            break;
                        }
                        Thread.Sleep(500);
                    }

                    if (checkBoxLoop.Checked)
                    {
                        loops++;
                        labelLoopExecuted.Text = "Loop Executed : " + loops;
                        elapsed = TimeSpan.FromMilliseconds(0);
                    }
                    if (!error)
                    {
                        setPass();
                        textBoxLog.AppendText($"Flashing process completed.{Environment.NewLine}");
                        textBoxLog.AppendText($"OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO{Environment.NewLine}");
                        textBoxLog.AppendText($"OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO{Environment.NewLine}");
                        textBoxLog.AppendText($"OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO{Environment.NewLine}");
                        textBoxLog.AppendText($"OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO{Environment.NewLine}");
                        textBoxLog.AppendText($"{Environment.NewLine}");
                        textBoxLog.AppendText($"{Environment.NewLine}");
                        textBoxLog.AppendText($"{Environment.NewLine}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Loop count should be more than 0");
            }

            timer.Stop();
            loopTimer.Stop();
            MessageBox.Show($"Flashing Process Completed in {totalElapsed} seconds");
            
            buttonFlash.Enabled = true;
            checkBoxLoop.Enabled = true;
            textBoxLoopCount.Enabled = true;
            buttonScanPort.Enabled = true;
            comboBoxPort.Enabled = true;
            textBoxFlashFile.Enabled = true;
            buttonBrowse.Enabled = true;
            buttonStop.Enabled = false;
        }

        private void setFail(string status)
        {
            labelStatus.Text = "FAIL";
            labelStatus.ForeColor = Color.Red;
            textBoxLog.AppendText(status + Environment.NewLine);
            failCount++;
            if (checkBoxLoop.Checked)
            {
                labelLoopFail.Text = "FAIL : " + failCount;
            }
        }

        private void setPass()
        {
            labelStatus.Text = "PASS";
            labelStatus.ForeColor = Color.Green;
            passCount++;
            if (checkBoxLoop.Checked)
            {
                labelLoopPass.Text = "PASS : " + passCount;
            }
        }


        private void AppendOutput(string type, string text)
        {
            if (textBoxLog.InvokeRequired)
            {
                textBoxLog.Invoke(new Action(() => AppendOutput(type, text)));
            }
            else
            {
                // Console.ForegroundColor = ConsoleColor.Red;
                //Console.ResetColor();
                if (type.Equals("ERROR") || type.Equals("FAIL"))
                {
                    textBoxLog.ForeColor = Color.Red;
                    textBoxLog.ResetText();
                }
                textBoxLog.AppendText($"{DateTime.Now:T} - {type} - {text}{Environment.NewLine}");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        { 
            totalElapsed = totalElapsed.Add(TimeSpan.FromSeconds(1));
            labelTotal.Text = "TOTAL : " + totalElapsed.ToString(@"hh\:mm\:ss");
        }

        private void LoopTimer_Tick(object sender, EventArgs e)
        {
            elapsed = elapsed.Add(TimeSpan.FromSeconds(1));
            labelCycle.Text = "CYCLE : " + elapsed.ToString(@"hh\:mm\:ss");
        }

        private void checkBoxLoop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLoop.Checked)
            {
                textBoxLoopCount.Enabled = true;
                textBoxLoopCount.Visible = true;
                labelLoopCount.Visible = true;
                labelLoopExecuted.Visible = true;
                labelLoopFail.Visible = true;
                labelLoopPass.Visible = true;
                labelLoopCount.Visible = true;
            }
            else
            {
                textBoxLoopCount.Enabled = false;
                textBoxLoopCount.Visible = false;
                labelLoopExecuted.Visible = false;
                labelLoopFail.Visible = false;
                labelLoopPass.Visible = false;
                labelLoopCount.Visible = false;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stopLoop = true;
            timer.Stop();
            buttonStop.Enabled = false;
            MessageBox.Show("The process will stop after current task is completed");
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select a Flash File";
                ofd.Filter = "STM32 Flash Files (*.hex;*.bin)|*.hex;*.bin";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBoxFlashFile.Text = ofd.FileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to clear the log?", "Confirm", MessageBoxButtons.YesNo);
        }

        private void buttonClearLog_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to clear the log?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                textBoxLog.Clear();
            }
        }

        private void buttonExportLog_Click(object sender, EventArgs e)
        {
            if (textBoxLog.Text.Length > 0)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    sfd.FileName = "TextBoxOutput.txt";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(sfd.FileName, textBoxLog.Text);
                        MessageBox.Show("Log file exported successfully!", "Success");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nothing to save", "Duh!");
            }
        }

        private void buttonTestplanBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.Title = "Select Test Plan XML File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    textBoxTestplan.Text = filePath;
                }
            }
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by : Santosh Ambekar (SANTRONIX)\n @SANTRONIX", "Credits", MessageBoxButtons.OK);
        }
    }
}
