namespace ZooBazarDesktopApp.UserControls
{
    partial class TasksUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            monthCalendar1 = new MonthCalendar();
            textBox3 = new TextBox();
            btnAddTask = new Button();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label14 = new Label();
            radioButton9 = new RadioButton();
            radioButton10 = new RadioButton();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 46);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 96);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 290);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Location:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(651, 39);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 3;
            label4.Text = "Assigned Employees:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(651, 387);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 4;
            label5.Text = "Notes/Comments:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 475);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 5;
            label6.Text = "Due date:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddTask);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(monthCalendar1);
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1103, 762);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Assign tasks";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(22, 328);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "area1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(275, 328);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 24);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "area2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(24, 396);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(67, 24);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "area3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(275, 396);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(67, 24);
            radioButton4.TabIndex = 9;
            radioButton4.TabStop = true;
            radioButton4.Text = "area4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 13);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1123, 807);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1115, 774);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Task";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(radioButton10);
            tabPage2.Controls.Add(radioButton9);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1115, 774);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Update Task";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 134);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(369, 128);
            textBox2.TabIndex = 11;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(651, 69);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(436, 268);
            checkedListBox1.TabIndex = 12;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(129, 475);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(651, 419);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(436, 263);
            textBox3.TabIndex = 14;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.OldLace;
            btnAddTask.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnAddTask.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnAddTask.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTask.ForeColor = Color.DarkGreen;
            btnAddTask.Location = new Point(433, 708);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(201, 31);
            btnAddTask.TabIndex = 41;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(127, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(313, 28);
            comboBox1.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 30);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 30;
            label7.Text = "Select task:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(505, 30);
            label14.Name = "label14";
            label14.Size = new Size(130, 20);
            label14.TabIndex = 32;
            label14.Text = "Choose operation:";
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(703, 28);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(121, 24);
            radioButton9.TabIndex = 33;
            radioButton9.TabStop = true;
            radioButton9.Text = "Update status";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(907, 26);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(162, 24);
            radioButton10.TabIndex = 34;
            radioButton10.TabStop = true;
            radioButton10.Text = "Change information";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // TasksUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Location = new Point(140, 40);
            Name = "TasksUC";
            Size = new Size(1151, 840);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private MonthCalendar monthCalendar1;
        private CheckedListBox checkedListBox1;
        private Button btnAddTask;
        private Label label7;
        private ComboBox comboBox1;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private Label label14;
    }
}
