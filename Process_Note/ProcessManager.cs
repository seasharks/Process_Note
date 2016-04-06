using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_Note
{
    public partial class ProcessManager : Form
    {
        readonly Dictionary<int, string> _processNotes = new Dictionary<int, string>();

        public ProcessManager()
        {
            InitializeComponent();
            LoadProcesses();
        }

        private void process_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process process = GetSelectedProcess();
            process_note_textbox.Text = @"Enter comment here!";
            ShowThreads(process);
            ShowNote(process);
            ShowUsage(process);
            ShowStartTime(process);
            ShowRunningTime(process);
        }

        private void ShowNote(Process process)
        {
            if (_processNotes.ContainsKey(process.Id))
                selected_process_command.Text = _processNotes[process.Id];
            else selected_process_command.Text = @"Note has not been added yet.";
        }

        private void enter_process_note_textbox(object sender, EventArgs e)
        {
            if (process_note_textbox.Text == @"Enter comment here!")
                process_note_textbox.Text = "";
        }

        private void leave_process_note_textbox(object sender, EventArgs e)
        {
            if (process_note_textbox.Text == "")
                process_note_textbox.Text = @"Enter comment here!";
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Process process = GetSelectedProcess();
            string noteText = process_note_textbox.Text;
            if (_processNotes.ContainsKey(process.Id))
                _processNotes[process.Id] = noteText;
            else _processNotes.Add(process.Id, noteText);
            selected_process_command.Text = noteText;
            process_note_textbox.Text = @"Enter comment here!";
        }

        private void LoadProcesses()
        {
            process_listbox.Items.Clear();
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                if (process.ProcessName != "Idle")
                    process_listbox.Items.Add(process.Id + "\t" + process.ProcessName);
            }
            process_listbox.SetSelected(0, true);
        }

        private int GetProcessId()
        {
            string processData = process_listbox.SelectedItem.ToString();
            return Int32.Parse(processData.Substring(0, processData.IndexOf("\t", StringComparison.Ordinal)));
        }

        private Process GetSelectedProcess()
        {
            int processId = GetProcessId();
            try
            {
                return Process.GetProcessById(processId);
            }
            catch
            {
                LoadProcesses();
                processId = GetProcessId();
                return Process.GetProcessById(processId);
            }
        }

        private void ShowThreads(Process process)
        {
            threads_listbox.Items.Clear();
            foreach (ProcessThread thread in process.Threads)
            { 
                    threads_listbox.Items.Add(thread.Id.ToString());
            }
        }

        private void ShowUsage(Process process)
        {
            PerformanceCounter processCpu = new PerformanceCounter("Process", "% Processor Time", process.ProcessName);
            processCpu.NextValue();
            Thread.Sleep(500);
            double processCpuUsage = processCpu.NextValue() / Environment.ProcessorCount;
            cpu_usage.Text = $"{processCpuUsage:F2} %";
            double memoryU = (double)process.WorkingSet64 / 1000000;
            memory_usage.Text = $"{memoryU:F2} MB";
        }

        private void ShowStartTime(Process process)
        {
            DateTime selectedProcessStartTimeRaw = process.StartTime;
            string selectedProcessStartTime = selectedProcessStartTimeRaw.ToString("yyyy-MM-dd HH:mm:ss");
            start_time.Text = selectedProcessStartTime;
        }

        private void ShowRunningTime(Process process)
        {
            DateTime dateNow = DateTime.Now;
            DateTime selectedProcessStartTimeRaw = process.StartTime;
            TimeSpan runningTimeRaw = dateNow.Subtract(selectedProcessStartTimeRaw);
            string runningTime = runningTimeRaw.ToString("%d") + " day(s) "
                                 + runningTimeRaw.ToString(@"hh\:mm\:ss");
            running_time.Text = runningTime;
        }

        private void alwaysOnTop_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TopMost)
            {
                this.TopMost = false;
            }
            else
            {
                this.TopMost = true;
            }
        }

        private void process_manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_processNotes.Count > 0)
            {
                DialogResult dialog = MessageBox.Show(@"Your notes will not be saved. Do you proceed to exit?",
                @"Exit", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
