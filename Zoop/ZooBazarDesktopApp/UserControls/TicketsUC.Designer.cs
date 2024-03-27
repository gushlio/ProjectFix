namespace ZooBazarDesktopApp.UserControls
{
    partial class TicketsUC
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
            TabControl tabControl1;
            tabPage1 = new TabPage();
            panelUpdate = new Panel();
            lblUpdateemployee = new Label();
            panelEmployees = new Panel();
            lblEmployees = new Label();
            gbAddBook = new GroupBox();
            comboBox1 = new ComboBox();
            label12 = new Label();
            textBox1 = new TextBox();
            label11 = new Label();
            checkedCategoryTicket = new CheckedListBox();
            label10 = new Label();
            btnApply = new Button();
            gbBooks = new GroupBox();
            btnDisplay = new Button();
            btnClear = new Button();
            RemainingTickets = new ListBox();
            CurrentPrices = new ListBox();
            tabControl1 = new TabControl();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panelUpdate.SuspendLayout();
            panelEmployees.SuspendLayout();
            gbAddBook.SuspendLayout();
            gbBooks.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1145, 773);
            tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(panelUpdate);
            tabPage1.Controls.Add(panelEmployees);
            tabPage1.Controls.Add(gbAddBook);
            tabPage1.Controls.Add(gbBooks);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1137, 740);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tickets";
            // 
            // panelUpdate
            // 
            panelUpdate.BackColor = Color.DarkGreen;
            panelUpdate.Controls.Add(lblUpdateemployee);
            panelUpdate.Location = new Point(6, 6);
            panelUpdate.Name = "panelUpdate";
            panelUpdate.Size = new Size(1115, 28);
            panelUpdate.TabIndex = 14;
            // 
            // lblUpdateemployee
            // 
            lblUpdateemployee.AutoSize = true;
            lblUpdateemployee.BackColor = Color.DarkGreen;
            lblUpdateemployee.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblUpdateemployee.ForeColor = Color.White;
            lblUpdateemployee.Location = new Point(3, 3);
            lblUpdateemployee.Name = "lblUpdateemployee";
            lblUpdateemployee.Size = new Size(100, 23);
            lblUpdateemployee.TabIndex = 0;
            lblUpdateemployee.Text = "Ticket type";
            // 
            // panelEmployees
            // 
            panelEmployees.BackColor = Color.DarkGreen;
            panelEmployees.Controls.Add(lblEmployees);
            panelEmployees.Location = new Point(6, 347);
            panelEmployees.Name = "panelEmployees";
            panelEmployees.Size = new Size(1115, 28);
            panelEmployees.TabIndex = 16;
            // 
            // lblEmployees
            // 
            lblEmployees.AutoSize = true;
            lblEmployees.BackColor = Color.DarkGreen;
            lblEmployees.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblEmployees.ForeColor = Color.White;
            lblEmployees.Location = new Point(3, 3);
            lblEmployees.Name = "lblEmployees";
            lblEmployees.Size = new Size(49, 23);
            lblEmployees.TabIndex = 0;
            lblEmployees.Text = "View";
            // 
            // gbAddBook
            // 
            gbAddBook.BackColor = Color.White;
            gbAddBook.Controls.Add(comboBox1);
            gbAddBook.Controls.Add(label12);
            gbAddBook.Controls.Add(textBox1);
            gbAddBook.Controls.Add(label11);
            gbAddBook.Controls.Add(checkedCategoryTicket);
            gbAddBook.Controls.Add(label10);
            gbAddBook.Controls.Add(btnApply);
            gbAddBook.Location = new Point(6, 6);
            gbAddBook.Name = "gbAddBook";
            gbAddBook.Size = new Size(1121, 335);
            gbAddBook.TabIndex = 0;
            gbAddBook.TabStop = false;
            gbAddBook.Text = "Add Book";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "50", "100", "150", "200", "250", "300" });
            comboBox1.Location = new Point(866, 165);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 28);
            comboBox1.TabIndex = 46;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(657, 173);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(159, 20);
            label12.TabIndex = 45;
            label12.Text = "Set Amount Of Tickets:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(866, 57);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 27);
            textBox1.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(657, 64);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(69, 20);
            label11.TabIndex = 42;
            label11.Text = "Set Price:";
            // 
            // checkedCategoryTicket
            // 
            checkedCategoryTicket.FormattingEnabled = true;
            checkedCategoryTicket.Items.AddRange(new object[] { "Adult", "Kid", "Elderly" });
            checkedCategoryTicket.Location = new Point(78, 123);
            checkedCategoryTicket.Margin = new Padding(2);
            checkedCategoryTicket.Name = "checkedCategoryTicket";
            checkedCategoryTicket.Size = new Size(149, 70);
            checkedCategoryTicket.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(78, 64);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(134, 20);
            label10.TabIndex = 40;
            label10.Text = "Select Ticket Type: ";
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.OldLace;
            btnApply.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnApply.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnApply.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApply.ForeColor = Color.DarkGreen;
            btnApply.Location = new Point(439, 275);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(201, 31);
            btnApply.TabIndex = 39;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // gbBooks
            // 
            gbBooks.BackColor = Color.White;
            gbBooks.Controls.Add(btnDisplay);
            gbBooks.Controls.Add(btnClear);
            gbBooks.Controls.Add(RemainingTickets);
            gbBooks.Controls.Add(CurrentPrices);
            gbBooks.Location = new Point(6, 347);
            gbBooks.Name = "gbBooks";
            gbBooks.Size = new Size(1121, 383);
            gbBooks.TabIndex = 15;
            gbBooks.TabStop = false;
            gbBooks.Text = "empl";
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.OldLace;
            btnDisplay.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnDisplay.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnDisplay.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisplay.ForeColor = Color.DarkGreen;
            btnDisplay.Location = new Point(787, 274);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(201, 31);
            btnDisplay.TabIndex = 41;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.OldLace;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnClear.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnClear.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.DarkGreen;
            btnClear.Location = new Point(115, 274);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(201, 31);
            btnClear.TabIndex = 40;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // RemainingTickets
            // 
            RemainingTickets.FormattingEnabled = true;
            RemainingTickets.Location = new Point(686, 51);
            RemainingTickets.Margin = new Padding(2);
            RemainingTickets.Name = "RemainingTickets";
            RemainingTickets.Size = new Size(390, 204);
            RemainingTickets.TabIndex = 9;
            // 
            // CurrentPrices
            // 
            CurrentPrices.FormattingEnabled = true;
            CurrentPrices.Location = new Point(16, 51);
            CurrentPrices.Margin = new Padding(2);
            CurrentPrices.Name = "CurrentPrices";
            CurrentPrices.Size = new Size(390, 204);
            CurrentPrices.TabIndex = 8;
            // 
            // TicketsUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Location = new Point(140, 40);
            Name = "TicketsUC";
            Size = new Size(1151, 779);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panelUpdate.ResumeLayout(false);
            panelUpdate.PerformLayout();
            panelEmployees.ResumeLayout(false);
            panelEmployees.PerformLayout();
            gbAddBook.ResumeLayout(false);
            gbAddBook.PerformLayout();
            gbBooks.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private Panel panelUpdate;
        private Label lblUpdateemployee;
        private Panel panelEmployees;
        private Label lblEmployees;
        private GroupBox gbAddBook;
        private Button btnApply;
        private GroupBox gbBooks;
        private ComboBox comboBox1;
        private Label label12;
        private TextBox textBox1;
        private Label label11;
        private CheckedListBox checkedCategoryTicket;
        private Label label10;
        private Button btnDisplay;
        private Button btnClear;
        private ListBox RemainingTickets;
        private ListBox CurrentPrices;
    }
}
