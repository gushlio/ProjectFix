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
            groupBox2 = new GroupBox();
            buttonAddTickets = new Button();
            txtQuantityToAdd = new TextBox();
            label12 = new Label();
            groupBox1 = new GroupBox();
            label11 = new Label();
            buttonEditPrice = new Button();
            txtNewPrice = new TextBox();
            cmbTicketType = new ComboBox();
            label10 = new Label();
            gbBooks = new GroupBox();
            dataGridViewTickets = new DataGridView();
            tabControl1 = new TabControl();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panelUpdate.SuspendLayout();
            panelEmployees.SuspendLayout();
            gbAddBook.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            gbBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(3, 2);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(753, 552);
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
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(745, 524);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tickets";
            // 
            // panelUpdate
            // 
            panelUpdate.BackColor = Color.DarkGreen;
            panelUpdate.Controls.Add(lblUpdateemployee);
            panelUpdate.Location = new Point(5, 4);
            panelUpdate.Margin = new Padding(3, 2, 3, 2);
            panelUpdate.Name = "panelUpdate";
            panelUpdate.Size = new Size(727, 21);
            panelUpdate.TabIndex = 14;
            // 
            // lblUpdateemployee
            // 
            lblUpdateemployee.AutoSize = true;
            lblUpdateemployee.BackColor = Color.DarkGreen;
            lblUpdateemployee.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblUpdateemployee.ForeColor = Color.White;
            lblUpdateemployee.Location = new Point(3, 2);
            lblUpdateemployee.Name = "lblUpdateemployee";
            lblUpdateemployee.Size = new Size(83, 19);
            lblUpdateemployee.TabIndex = 0;
            lblUpdateemployee.Text = "Ticket type";
            // 
            // panelEmployees
            // 
            panelEmployees.BackColor = Color.DarkGreen;
            panelEmployees.Controls.Add(lblEmployees);
            panelEmployees.Location = new Point(5, 260);
            panelEmployees.Margin = new Padding(3, 2, 3, 2);
            panelEmployees.Name = "panelEmployees";
            panelEmployees.Size = new Size(727, 21);
            panelEmployees.TabIndex = 16;
            // 
            // lblEmployees
            // 
            lblEmployees.AutoSize = true;
            lblEmployees.BackColor = Color.DarkGreen;
            lblEmployees.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblEmployees.ForeColor = Color.White;
            lblEmployees.Location = new Point(3, 2);
            lblEmployees.Name = "lblEmployees";
            lblEmployees.Size = new Size(41, 19);
            lblEmployees.TabIndex = 0;
            lblEmployees.Text = "View";
            // 
            // gbAddBook
            // 
            gbAddBook.BackColor = Color.White;
            gbAddBook.Controls.Add(groupBox2);
            gbAddBook.Controls.Add(groupBox1);
            gbAddBook.Controls.Add(cmbTicketType);
            gbAddBook.Controls.Add(label10);
            gbAddBook.Location = new Point(5, 4);
            gbAddBook.Margin = new Padding(3, 2, 3, 2);
            gbAddBook.Name = "gbAddBook";
            gbAddBook.Padding = new Padding(3, 2, 3, 2);
            gbAddBook.Size = new Size(727, 251);
            gbAddBook.TabIndex = 0;
            gbAddBook.TabStop = false;
            gbAddBook.Text = "Add Book";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonAddTickets);
            groupBox2.Controls.Add(txtQuantityToAdd);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(388, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(153, 115);
            groupBox2.TabIndex = 51;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update Ticket Quantity";
            // 
            // buttonAddTickets
            // 
            buttonAddTickets.Location = new Point(6, 72);
            buttonAddTickets.Name = "buttonAddTickets";
            buttonAddTickets.Size = new Size(141, 37);
            buttonAddTickets.TabIndex = 47;
            buttonAddTickets.Text = "Add Tickets";
            buttonAddTickets.UseVisualStyleBackColor = true;
            buttonAddTickets.Click += buttonAddTickets_Click;
            // 
            // txtQuantityToAdd
            // 
            txtQuantityToAdd.Location = new Point(46, 44);
            txtQuantityToAdd.Name = "txtQuantityToAdd";
            txtQuantityToAdd.Size = new Size(52, 23);
            txtQuantityToAdd.TabIndex = 46;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(31, 27);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 45;
            label12.Text = "Ticket Amount:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(buttonEditPrice);
            groupBox1.Controls.Add(txtNewPrice);
            groupBox1.Location = new Point(212, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(141, 115);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit Ticket Price";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(43, 27);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 42;
            label11.Text = "Set Price:";
            // 
            // buttonEditPrice
            // 
            buttonEditPrice.Location = new Point(6, 72);
            buttonEditPrice.Name = "buttonEditPrice";
            buttonEditPrice.Size = new Size(129, 37);
            buttonEditPrice.TabIndex = 49;
            buttonEditPrice.Text = "Update Price";
            buttonEditPrice.UseVisualStyleBackColor = true;
            buttonEditPrice.Click += buttonEditPrice_Click;
            // 
            // txtNewPrice
            // 
            txtNewPrice.Location = new Point(43, 44);
            txtNewPrice.Margin = new Padding(2, 2, 2, 2);
            txtNewPrice.Name = "txtNewPrice";
            txtNewPrice.Size = new Size(55, 23);
            txtNewPrice.TabIndex = 43;
            // 
            // cmbTicketType
            // 
            cmbTicketType.FormattingEnabled = true;
            cmbTicketType.Location = new Point(24, 78);
            cmbTicketType.Name = "cmbTicketType";
            cmbTicketType.Size = new Size(132, 23);
            cmbTicketType.TabIndex = 48;
            cmbTicketType.SelectedIndexChanged += cmbTicketType_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 51);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(105, 15);
            label10.TabIndex = 40;
            label10.Text = "Select Ticket Type: ";
            // 
            // gbBooks
            // 
            gbBooks.BackColor = Color.White;
            gbBooks.Controls.Add(dataGridViewTickets);
            gbBooks.Location = new Point(5, 260);
            gbBooks.Margin = new Padding(3, 2, 3, 2);
            gbBooks.Name = "gbBooks";
            gbBooks.Padding = new Padding(3, 2, 3, 2);
            gbBooks.Size = new Size(727, 250);
            gbBooks.TabIndex = 15;
            gbBooks.TabStop = false;
            gbBooks.Text = "empl";
            // 
            // dataGridViewTickets
            // 
            dataGridViewTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTickets.Location = new Point(6, 26);
            dataGridViewTickets.Name = "dataGridViewTickets";
            dataGridViewTickets.RowHeadersWidth = 51;
            dataGridViewTickets.Size = new Size(715, 210);
            dataGridViewTickets.TabIndex = 0;
            // 
            // TicketsUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Location = new Point(140, 40);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TicketsUC";
            Size = new Size(1480, 738);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panelUpdate.ResumeLayout(false);
            panelUpdate.PerformLayout();
            panelEmployees.ResumeLayout(false);
            panelEmployees.PerformLayout();
            gbAddBook.ResumeLayout(false);
            gbAddBook.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private Panel panelUpdate;
        private Label lblUpdateemployee;
        private Panel panelEmployees;
        private Label lblEmployees;
        private GroupBox gbAddBook;
        private GroupBox gbBooks;
        private Label label12;
        private TextBox txtNewPrice;
        private Label label11;
        private Label label10;
        private ComboBox cmbTicketType;
        private GroupBox groupBox1;
        private Button buttonEditPrice;
        private GroupBox groupBox2;
        private Button buttonAddTickets;
        private TextBox txtQuantityToAdd;
        private DataGridView dataGridViewTickets;
    }
}
