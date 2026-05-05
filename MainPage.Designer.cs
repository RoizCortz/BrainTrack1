namespace BrainTrack1
{
    partial class MainPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ClearCompleted = new System.Windows.Forms.Button();
            this.DeleteTask = new System.Windows.Forms.Button();
            this.AddTask = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TaskPriority = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TaskDue = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SubjectType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TaskTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameDis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTask,
            this.colSubject,
            this.colDate,
            this.colPriority,
            this.colStatus});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(246, 136);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(764, 450);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colTask
            // 
            this.colTask.HeaderText = "Task";
            this.colTask.MinimumWidth = 6;
            this.colTask.Name = "colTask";
            this.colTask.ReadOnly = true;
            // 
            // colSubject
            // 
            this.colSubject.HeaderText = "Subject";
            this.colSubject.MinimumWidth = 6;
            this.colSubject.Name = "colSubject";
            this.colSubject.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Due Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colPriority
            // 
            this.colPriority.HeaderText = "Priority";
            this.colPriority.MinimumWidth = 6;
            this.colPriority.Name = "colPriority";
            this.colPriority.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Study Tasks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage your study schedule efficiently.\r\n";
            // 
            // SidePanel
            // 
            this.SidePanel.BackgroundImage = global::BrainTrack1.Properties.Resources.collection;
            this.SidePanel.Controls.Add(this.ClearCompleted);
            this.SidePanel.Controls.Add(this.DeleteTask);
            this.SidePanel.Controls.Add(this.AddTask);
            this.SidePanel.Controls.Add(this.Status);
            this.SidePanel.Controls.Add(this.label8);
            this.SidePanel.Controls.Add(this.TaskPriority);
            this.SidePanel.Controls.Add(this.label7);
            this.SidePanel.Controls.Add(this.TaskDue);
            this.SidePanel.Controls.Add(this.label6);
            this.SidePanel.Controls.Add(this.SubjectType);
            this.SidePanel.Controls.Add(this.label5);
            this.SidePanel.Controls.Add(this.TaskTitle);
            this.SidePanel.Controls.Add(this.label4);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(245, 586);
            this.SidePanel.TabIndex = 0;
            // 
            // ClearCompleted
            // 
            this.ClearCompleted.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearCompleted.Location = new System.Drawing.Point(140, 527);
            this.ClearCompleted.Margin = new System.Windows.Forms.Padding(2);
            this.ClearCompleted.Name = "ClearCompleted";
            this.ClearCompleted.Size = new System.Drawing.Size(92, 30);
            this.ClearCompleted.TabIndex = 14;
            this.ClearCompleted.Text = "Clear";
            this.ClearCompleted.UseVisualStyleBackColor = true;
            // 
            // DeleteTask
            // 
            this.DeleteTask.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTask.Location = new System.Drawing.Point(140, 488);
            this.DeleteTask.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteTask.Name = "DeleteTask";
            this.DeleteTask.Size = new System.Drawing.Size(92, 30);
            this.DeleteTask.TabIndex = 13;
            this.DeleteTask.Text = "Delete Task";
            this.DeleteTask.UseVisualStyleBackColor = true;
            // 
            // AddTask
            // 
            this.AddTask.BackColor = System.Drawing.Color.White;
            this.AddTask.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTask.Location = new System.Drawing.Point(140, 446);
            this.AddTask.Margin = new System.Windows.Forms.Padding(2);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(92, 30);
            this.AddTask.TabIndex = 12;
            this.AddTask.Text = "Add Task";
            this.AddTask.UseVisualStyleBackColor = false;
            this.AddTask.Click += new System.EventHandler(this.AddTask_Click);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Complete",
            "Incomplete",
            "In-Progress",
            "Due Date Passed"});
            this.Status.Location = new System.Drawing.Point(102, 362);
            this.Status.Margin = new System.Windows.Forms.Padding(2);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(92, 21);
            this.Status.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(5)))), ((int)(((byte)(48)))));
            this.label8.Location = new System.Drawing.Point(42, 362);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = " Status ";
            // 
            // TaskPriority
            // 
            this.TaskPriority.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TaskPriority.FormattingEnabled = true;
            this.TaskPriority.Items.AddRange(new object[] {
            "Urgent"});
            this.TaskPriority.Location = new System.Drawing.Point(102, 327);
            this.TaskPriority.Margin = new System.Windows.Forms.Padding(2);
            this.TaskPriority.Name = "TaskPriority";
            this.TaskPriority.Size = new System.Drawing.Size(92, 21);
            this.TaskPriority.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(5)))), ((int)(((byte)(48)))));
            this.label7.Location = new System.Drawing.Point(42, 328);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Priority";
            // 
            // TaskDue
            // 
            this.TaskDue.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.TaskDue.Location = new System.Drawing.Point(43, 288);
            this.TaskDue.Margin = new System.Windows.Forms.Padding(2);
            this.TaskDue.Name = "TaskDue";
            this.TaskDue.Size = new System.Drawing.Size(159, 20);
            this.TaskDue.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(42, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Due Date";
            // 
            // SubjectType
            // 
            this.SubjectType.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SubjectType.Location = new System.Drawing.Point(41, 216);
            this.SubjectType.Margin = new System.Windows.Forms.Padding(2);
            this.SubjectType.Multiline = true;
            this.SubjectType.Name = "SubjectType";
            this.SubjectType.Size = new System.Drawing.Size(161, 24);
            this.SubjectType.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(5)))), ((int)(((byte)(48)))));
            this.label5.Location = new System.Drawing.Point(42, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Subject";
            // 
            // TaskTitle
            // 
            this.TaskTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TaskTitle.Location = new System.Drawing.Point(41, 145);
            this.TaskTitle.Margin = new System.Windows.Forms.Padding(2);
            this.TaskTitle.Multiline = true;
            this.TaskTitle.Name = "TaskTitle";
            this.TaskTitle.Size = new System.Drawing.Size(161, 24);
            this.TaskTitle.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(42, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Task Title";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(762, 59);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(189, 28);
            this.progressBar1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(797, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Track your progress.\r\n";
            // 
            // UsernameDis
            // 
            this.UsernameDis.AutoSize = true;
            this.UsernameDis.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameDis.Location = new System.Drawing.Point(275, 9);
            this.UsernameDis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameDis.Name = "UsernameDis";
            this.UsernameDis.Size = new System.Drawing.Size(137, 34);
            this.UsernameDis.TabIndex = 7;
            this.UsernameDis.Text = "Welcome";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(179)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1011, 586);
            this.Controls.Add(this.UsernameDis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SidePanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubjectType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TaskTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker TaskDue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Button DeleteTask;
        private System.Windows.Forms.Button AddTask;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox TaskPriority;
        private System.Windows.Forms.Button ClearCompleted;
        private System.Windows.Forms.Label UsernameDis;
    }
}