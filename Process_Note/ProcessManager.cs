using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_Note
{
    public partial class process_manager : Form
    {
        public process_manager()
        {
            InitializeComponent();
            loadProcesses();
        }

        private void process_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process process = getSelectedProcess();
            showThreads(process);
        }

        private void save_button_Click(object sender, EventArgs e)
        {

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

        private void alwaysOnTop_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (alwaysOnTop_checkBox.Checked)
            {
                
            }
        }
    }
}
