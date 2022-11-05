using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CommandWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> outPutVal = new List<string>();
            string selectedRadio = "";
            if (radDate.Checked)
            {
                outPutVal = ExecuteCommand("/c date", "");
                selectedRadio = radDate.Text;
            }
            else
                if (radTime.Checked)
                {
                    outPutVal = ExecuteCommand("/c time", "");
                    selectedRadio = radTime.Text;
                }
                else
                    if (radWhoAmI.Checked)
                    {
                        outPutVal = ExecuteCommand("/c whoami", "");
                        selectedRadio = radWhoAmI.Text;
                    }
                    else
                        if (radWhoAmIGroup.Checked)
                        {
                            outPutVal = ExecuteCommand("/c whoami /groups", "");
                            selectedRadio = radWhoAmIGroup.Text;
                        }
                        else
                            if (radWhoAmIUser.Checked)
                            {
                                outPutVal = ExecuteCommand("/c whoami /user", "");
                                selectedRadio = radWhoAmIUser.Text;
                            }
                            else
                                if (radVersion.Checked)
                                {
                                    outPutVal = ExecuteCommand("/c ver", "");
                                    selectedRadio = radVersion.Text;
                                }
                                    else
                                        if (radSystemInfo.Checked)
                                        {
                                            outPutVal = ExecuteCommand("/c systeminfo", "");
                                            selectedRadio = radSystemInfo.Text;
                                        }
                                        else
                                            if (radTaskList.Checked)
                                            {
                                                outPutVal = ExecuteCommand("/c tasklist", "");
                                                selectedRadio = radTaskList.Text;
                                            }
                                            else
                                                if (radTaskListSort.Checked)
                                                {
                                                    outPutVal = ExecuteCommand("/c tasklist | sort", "");
                                                    selectedRadio = radTaskListSort.Text;
                                                }
                                                else
                                                    if (radTaskSVC.Checked)
                                                    {
                                                        outPutVal = ExecuteCommand("/c tasklist /svc", "");
                                                        selectedRadio = radTaskSVC.Text;
                                                    }
                                                    else
                                                        if (radIpConfig.Checked)
                                                        {
                                                            outPutVal = ExecuteCommand("/c ipconfig /all", "");
                                                            selectedRadio = radIpConfig.Text;
                                                        }
                                                        else
                                                            if (radNetStat.Checked)
                                                            {
                                                                outPutVal = ExecuteCommand("/c netstat -ano", "");
                                                                selectedRadio = radNetStat.Text;
                                                            }
                                                            else
                                                                if (radSchTasks.Checked)
                                                                {
                                                                    outPutVal = ExecuteCommand("/c schtasks", "");
                                                                    selectedRadio = radSchTasks.Text;
                                                                }
                                                                else
                                                                    if (radAutoruns.Checked)
                                                                    {
                                                                        outPutVal = ExecuteCommand("/c autorunsc *", "");
                                                                        selectedRadio = radAutoruns.Text;
                                                                    }
                                                                    else
                                                                        if (radHandle.Checked)
                                                                        {
                                                                            outPutVal = ExecuteCommand("/c handle -a", "");
                                                                            selectedRadio = radHandle.Text;
                                                                        }
                                                                        else
                                                                            if (radlstDLL.Checked)
                                                                            {
                                                                                outPutVal = ExecuteCommand("/c listdlls -r", "");
                                                                                selectedRadio = radlstDLL.Text;
                                                                            }
                                                                                else
                                                                                    if (radProcessExplorer.Checked)
                                                                                    {
                                                                                        outPutVal = ExecuteCommand("/c procexp", "");
                                                                                        selectedRadio = radProcessExplorer.Text;
                                                                                    }
                                                                                    else
                                                                                        if (radProcessMonitor.Checked)
                                                                                        {
                                                                                            outPutVal = ExecuteCommand("/c procmon", "");
                                                                                            selectedRadio = radProcessMonitor.Text;
                                                                                        }
                                                                                        else
                                                                                            if (radPsList.Checked)
                                                                                            {
                                                                                                outPutVal = ExecuteCommand("/c pslist exp", "");
                                                                                                selectedRadio = radPsList.Text;
                                                                                            }
                                                                                            else
                                                                                                if (radPsInfo.Checked)
                                                                                                {
                                                                                                    outPutVal = ExecuteCommand("/c psinfo \\* notepad", "");
                                                                                                    selectedRadio = radPsInfo.Text;
                                                                                                }
                                                                                                else
                                                                                                    if (radAccessCHK.Checked)
                                                                                                    {
                                                                                                        outPutVal = ExecuteCommand("/c accesschk -a", "");
                                                                                                        selectedRadio = radAccessCHK.Text;
                                                                                                    }
                                                                                                    else
                                                                                                        if (radAccessEnum.Checked)
                                                                                                        {
                                                                                                            outPutVal = ExecuteCommand("/c accessenum", "");
                                                                                                            selectedRadio = radAccessEnum.Text;
                                                                                                        }
                                                                                                        else
                                                                                                            if (radShareEnum.Checked)
                                                                                                            {
                                                                                                                outPutVal = ExecuteCommand("/c shareenum", "");
                                                                                                                selectedRadio = radShareEnum.Text;
                                                                                                            }
                                                                                                            else
                                                                                                                if (radTCPView.Checked)
                                                                                                                {
                                                                                                                    outPutVal = ExecuteCommand("/c tcpview", "");
                                                                                                                    selectedRadio = radTCPView.Text;
                                                                                                                }
                                                                                                                else
                                                                                                                    if (radPsFile.Checked)
                                                                                                                    {
                                                                                                                        outPutVal = ExecuteCommand("/c psfile \\computer -u abc -p password", "");
                                                                                                                        selectedRadio = radPsFile.Text;
                                                                                                                    }


            WriteCommandOutput("Command Name :" + selectedRadio);
            WriteCommandOutput("Execution Time :" + DateTime.Now.ToString());
            foreach (string item in outPutVal)
            {
                richTextBox1.Text += item + "\n";
                WriteCommandOutput(item);
            }
        }

        public List<string> ExecuteCommand(string commandName, string parameter)
        {

            List<string> outputData = new List<string>();
            try
            {
                StringBuilder output = new StringBuilder();
                StringBuilder error = new StringBuilder();

                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = commandName;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.CreateNoWindow = true;


                    using (AutoResetEvent outputWaitHandle = new AutoResetEvent(false))
                    using (AutoResetEvent errorWaitHandle = new AutoResetEvent(false))
                    {
                        process.OutputDataReceived += (sender, e) =>
                        {
                            if (e.Data == null)
                            {
                                outputWaitHandle.Set();
                            }
                            else
                            {
                                output.AppendLine(e.Data);
                            }
                        };
                        process.ErrorDataReceived += (sender, e) =>
                        {
                            if (e.Data == null)
                            {
                                errorWaitHandle.Set();
                            }
                            else
                            {
                                error.AppendLine(e.Data);
                            }
                        };

                        process.Start();

                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();

                        if (process.WaitForExit(3000) &&
                            outputWaitHandle.WaitOne(3000) &&
                            errorWaitHandle.WaitOne(3000))
                        {
                            outputData.Add(output.ToString());
                        }
                        else
                        {
                            outputData.Add(output.ToString());
                        }
                    }
                }
            }
            catch
            {

            }

            //
            return outputData;
        }

        public void WriteCommandOutput(string output)
        {
            using (StreamWriter sw = File.AppendText("output.log"))
            {
                sw.WriteLine(output);
                sw.Close();
            }
        }
    }
}
