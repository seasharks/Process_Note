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
    public partial class process_manager : Form
    {
        Dictionary<int, string> processNotes = new Dictionary<int, string>();

        public process_manager()
        {
            InitializeComponent();
            loadProcesses();
        }

        private void process_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process process = getSelectedProcess();
            showThreads(process);
            showNote(process);
            showUsage(process);
        }

        private void showNote(Process process)
        {
            if (processNotes.ContainsKey(process.Id))
                selected_process_command.Text = processNotes[process.Id];
            else selected_process_command.Text = "Note has not been added yet.";
        }

        private void enter_process_note_textbox(object sender, EventArgs e)
        {
            process_note_textbox.Text = "";
        }

        private void leave_process_note_textbox(object sender, EventArgs e)
        {
            if (process_note_textbox.Text == "")
                process_note_textbox.Text = "Enter comment here!";
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Process process = getSelectedProcess();
            string noteText = process_note_textbox.Text;
            if (processNotes.ContainsKey(process.Id))
                processNotes[process.Id] = noteText;
            else processNotes.Add(process.Id, noteText);
            selected_process_command.Text = noteText;
            process_note_textbox.Text = "Enter comment here!";
        }

        private void loadProcesses()
        {
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                if (process.ProcessName != "Idle")
                    process_listbox.Items.Add(process.Id + "\t" + process.ProcessName);
            }
        }

        private Process getSelectedProcess()
        {
            string processData = process_listbox.SelectedItem.ToString();
            int processId = Int32.Parse(processData.Substring(0, processData.IndexOf("\t")));
            return Process.GetProcessById(processId);
        }

        private void showThreads(Process process)
        {
            threads_listbox.Items.Clear();
            foreach (ProcessThread thread in process.Threads)
            { 
                    threads_listbox.Items.Add(thread.Id.ToString());
            }
        }

        private void showUsage(Process process)
        {
            PerformanceCounter process_cpu = new PerformanceCounter("Process", "% Processor Time", process.ProcessName);
            process_cpu.NextValue();
            Thread.Sleep(500);
            double process_cpu_usage = process_cpu.NextValue() / Environment.ProcessorCount;
            cpu_usage.Text = $"{process_cpu_usage:F2} %";
            double memoryU = (double)process.WorkingSet64 / 1000000;
            memory_usage.Text = $"{memoryU:F2} MB";
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
            if (processNotes.Count > 0)
            {
                DialogResult dialog = MessageBox.Show("Your notes will not be saved. Do you proceed to exit?",
                "Exit", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
