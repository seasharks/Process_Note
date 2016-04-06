namespace Process_Note
{
    partial class process_manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.process_listbox = new System.Windows.Forms.ListBox();
            this.cpu_usage_title = new System.Windows.Forms.Label();
            this.memory_usage_title = new System.Windows.Forms.Label();
            this.running_time_title = new System.Windows.Forms.Label();
            this.start_time_title = new System.Windows.Forms.Label();
            this.cpu_usage = new System.Windows.Forms.Label();
            this.memory_usage = new System.Windows.Forms.Label();
            this.running_time = new System.Windows.Forms.Label();
            this.start_time = new System.Windows.Forms.Label();
            this.process_note_textbox = new System.Windows.Forms.TextBox();
            this.selected_process_note_title = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.threads_listbox = new System.Windows.Forms.ListBox();
            this.Threads = new System.Windows.Forms.Label();
            this.current_processes_title = new System.Windows.Forms.Label();
            this.selected_process_command = new System.Windows.Forms.Label();
            this.alwaysOnTop_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // process_listbox
            // 
            this.process_listbox.FormattingEnabled = true;
            this.process_listbox.Location = new System.Drawing.Point(15, 45);
            this.process_listbox.Name = "process_listbox";
            this.process_listbox.Size = new System.Drawing.Size(289, 290);
            this.process_listbox.TabIndex = 0;
            this.process_listbox.SelectedIndexChanged += new System.EventHandler(this.process_listbox_SelectedIndexChanged);
            // 
            // cpu_usage_title
            // 
            this.cpu_usage_title.AutoSize = true;
            this.cpu_usage_title.Location = new System.Drawing.Point(329, 358);
            this.cpu_usage_title.Name = "cpu_usage_title";
            this.cpu_usage_title.Size = new System.Drawing.Size(61, 13);
            this.cpu_usage_title.TabIndex = 1;
            this.cpu_usage_title.Text = "CPU usage";
            // 
            // memory_usage_title
            // 
            this.memory_usage_title.AutoSize = true;
            this.memory_usage_title.Location = new System.Drawing.Point(329, 381);
            this.memory_usage_title.Name = "memory_usage_title";
            this.memory_usage_title.Size = new System.Drawing.Size(76, 13);
            this.memory_usage_title.TabIndex = 2;
            this.memory_usage_title.Text = "Memory usage";
            // 
            // running_time_title
            // 
            this.running_time_title.AutoSize = true;
            this.running_time_title.Location = new System.Drawing.Point(329, 404);
            this.running_time_title.Name = "running_time_title";
            this.running_time_title.Size = new System.Drawing.Size(69, 13);
            this.running_time_title.TabIndex = 3;
            this.running_time_title.Text = "Running time";
            // 
            // start_time_title
            // 
            this.start_time_title.AutoSize = true;
            this.start_time_title.Location = new System.Drawing.Point(329, 427);
            this.start_time_title.Name = "start_time_title";
            this.start_time_title.Size = new System.Drawing.Size(51, 13);
            this.start_time_title.TabIndex = 4;
            this.start_time_title.Text = "Start time";
            // 
            // cpu_usage
            // 
            this.cpu_usage.AutoSize = true;
            this.cpu_usage.Location = new System.Drawing.Point(417, 358);
            this.cpu_usage.Name = "cpu_usage";
            this.cpu_usage.Size = new System.Drawing.Size(102, 13);
            this.cpu_usage.TabIndex = 5;
            this.cpu_usage.Text = "no process selected";
            // 
            // memory_usage
            // 
            this.memory_usage.AutoSize = true;
            this.memory_usage.Location = new System.Drawing.Point(417, 381);
            this.memory_usage.Name = "memory_usage";
            this.memory_usage.Size = new System.Drawing.Size(102, 13);
            this.memory_usage.TabIndex = 6;
            this.memory_usage.Text = "no process selected";
            // 
            // running_time
            // 
            this.running_time.AutoSize = true;
            this.running_time.Location = new System.Drawing.Point(417, 404);
            this.running_time.Name = "running_time";
            this.running_time.Size = new System.Drawing.Size(102, 13);
            this.running_time.TabIndex = 7;
            this.running_time.Text = "no process selected";
            // 
            // start_time
            // 
            this.start_time.AutoSize = true;
            this.start_time.Location = new System.Drawing.Point(417, 427);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(102, 13);
            this.start_time.TabIndex = 8;
            this.start_time.Text = "no process selected";
            // 
            // process_note_textbox
            // 
            this.process_note_textbox.Location = new System.Drawing.Point(15, 420);
            this.process_note_textbox.Name = "process_note_textbox";
            this.process_note_textbox.Size = new System.Drawing.Size(208, 20);
            this.process_note_textbox.TabIndex = 11;
            this.process_note_textbox.Text = "Enter comment here!";
            // 
            // selected_process_note_title
            // 
            this.selected_process_note_title.AutoSize = true;
            this.selected_process_note_title.Location = new System.Drawing.Point(12, 358);
            this.selected_process_note_title.Name = "selected_process_note_title";
            this.selected_process_note_title.Size = new System.Drawing.Size(123, 13);
            this.selected_process_note_title.TabIndex = 12;
            this.selected_process_note_title.Text = "Selected process\'s note:";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(229, 419);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 20);
            this.save_button.TabIndex = 13;
            this.save_button.TabStop = false;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // threads_listbox
            // 
            this.threads_listbox.FormattingEnabled = true;
            this.threads_listbox.Location = new System.Drawing.Point(332, 45);
            this.threads_listbox.Name = "threads_listbox";
            this.threads_listbox.Size = new System.Drawing.Size(289, 290);
            this.threads_listbox.TabIndex = 14;
            // 
            // Threads
            // 
            this.Threads.AutoSize = true;
            this.Threads.Location = new System.Drawing.Point(457, 22);
            this.Threads.Name = "Threads";
            this.Threads.Size = new System.Drawing.Size(49, 13);
            this.Threads.TabIndex = 15;
            this.Threads.Text = "Threads ";
            // 
            // current_processes_title
            // 
            this.current_processes_title.AutoSize = true;
            this.current_processes_title.Location = new System.Drawing.Point(106, 22);
            this.current_processes_title.Name = "current_processes_title";
            this.current_processes_title.Size = new System.Drawing.Size(92, 13);
            this.current_processes_title.TabIndex = 16;
            this.current_processes_title.Text = "Current processes";
            // 
            // selected_process_command
            // 
            this.selected_process_command.AutoSize = true;
            this.selected_process_command.Location = new System.Drawing.Point(12, 390);
            this.selected_process_command.Name = "selected_process_command";
            this.selected_process_command.Size = new System.Drawing.Size(102, 13);
            this.selected_process_command.TabIndex = 17;
            this.selected_process_command.Text = "no process selected";
            // 
            // alwaysOnTop_checkBox
            // 
            this.alwaysOnTop_checkBox.AutoSize = true;
            this.alwaysOnTop_checkBox.Location = new System.Drawing.Point(15, 459);
            this.alwaysOnTop_checkBox.Name = "alwaysOnTop_checkBox";
            this.alwaysOnTop_checkBox.Size = new System.Drawing.Size(98, 17);
            this.alwaysOnTop_checkBox.TabIndex = 18;
            this.alwaysOnTop_checkBox.Text = "Always On Top";
            this.alwaysOnTop_checkBox.UseVisualStyleBackColor = true;
            this.alwaysOnTop_checkBox.CheckedChanged += new System.EventHandler(this.alwaysOnTop_checkBox_CheckedChanged);
            // 
            // process_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 488);
            this.Controls.Add(this.alwaysOnTop_checkBox);
            this.Controls.Add(this.selected_process_command);
            this.Controls.Add(this.current_processes_title);
            this.Controls.Add(this.Threads);
            this.Controls.Add(this.threads_listbox);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.selected_process_note_title);
            this.Controls.Add(this.process_note_textbox);
            this.Controls.Add(this.start_time);
            this.Controls.Add(this.running_time);
            this.Controls.Add(this.memory_usage);
            this.Controls.Add(this.cpu_usage);
            this.Controls.Add(this.start_time_title);
            this.Controls.Add(this.running_time_title);
            this.Controls.Add(this.memory_usage_title);
            this.Controls.Add(this.cpu_usage_title);
            this.Controls.Add(this.process_listbox);
            this.Name = "process_manager";
            this.Text = "Process Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox process_listbox;
        private System.Windows.Forms.Label cpu_usage_title;
        private System.Windows.Forms.Label memory_usage_title;
        private System.Windows.Forms.Label running_time_title;
        private System.Windows.Forms.Label start_time_title;
        private System.Windows.Forms.Label cpu_usage;
        private System.Windows.Forms.Label memory_usage;
        private System.Windows.Forms.Label running_time;
        private System.Windows.Forms.Label start_time;
        private System.Windows.Forms.TextBox process_note_textbox;
        private System.Windows.Forms.Label selected_process_note_title;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ListBox threads_listbox;
        private System.Windows.Forms.Label Threads;
        private System.Windows.Forms.Label current_processes_title;
        private System.Windows.Forms.Label selected_process_command;
        private System.Windows.Forms.CheckBox alwaysOnTop_checkBox;
    }
}

