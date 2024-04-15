namespace ZooBazarDesktopApp.UserControls
{
    partial class AnimalsUC
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panelUpdate = new Panel();
            lblUpdateemployee = new Label();
            gbAddBook = new GroupBox();
            dtpAge = new DateTimePicker();
            dtpLastFeedTime = new DateTimePicker();
            dataGridViewAnimals = new DataGridView();
            lblLastFeedTime = new Label();
            chkIsSick = new CheckBox();
            txtLocation = new TextBox();
            txtColor = new TextBox();
            lblLocation = new Label();
            lblsick = new Label();
            lblColor = new Label();
            lblWeight = new Label();
            lblGender = new Label();
            txtGender = new TextBox();
            label1 = new Label();
            lblSpecies = new Label();
            txtSpecies = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            btnDelete = new Button();
            btnAddAnimal = new Button();
            btnUpdateAnimal = new Button();
            tabPage2 = new TabPage();
            txtWeight = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panelUpdate.SuspendLayout();
            gbAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimals).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1132, 775);
            tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(panelUpdate);
            tabPage1.Controls.Add(gbAddBook);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1124, 742);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Animals";
            // 
            // panelUpdate
            // 
            panelUpdate.BackColor = Color.DarkGreen;
            panelUpdate.Controls.Add(lblUpdateemployee);
            panelUpdate.Location = new Point(6, 6);
            panelUpdate.Name = "panelUpdate";
            panelUpdate.Size = new Size(1108, 28);
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
            lblUpdateemployee.Size = new Size(74, 23);
            lblUpdateemployee.TabIndex = 0;
            lblUpdateemployee.Text = "Animals";
            // 
            // gbAddBook
            // 
            gbAddBook.BackColor = Color.White;
            gbAddBook.Controls.Add(dtpAge);
            gbAddBook.Controls.Add(dtpLastFeedTime);
            gbAddBook.Controls.Add(dataGridViewAnimals);
            gbAddBook.Controls.Add(lblLastFeedTime);
            gbAddBook.Controls.Add(chkIsSick);
            gbAddBook.Controls.Add(txtLocation);
            gbAddBook.Controls.Add(txtColor);
            gbAddBook.Controls.Add(txtWeight);
            gbAddBook.Controls.Add(lblLocation);
            gbAddBook.Controls.Add(lblsick);
            gbAddBook.Controls.Add(lblColor);
            gbAddBook.Controls.Add(lblWeight);
            gbAddBook.Controls.Add(lblGender);
            gbAddBook.Controls.Add(txtGender);
            gbAddBook.Controls.Add(label1);
            gbAddBook.Controls.Add(lblSpecies);
            gbAddBook.Controls.Add(txtSpecies);
            gbAddBook.Controls.Add(lblName);
            gbAddBook.Controls.Add(txtName);
            gbAddBook.Controls.Add(btnDelete);
            gbAddBook.Controls.Add(btnAddAnimal);
            gbAddBook.Controls.Add(btnUpdateAnimal);
            gbAddBook.Location = new Point(6, 6);
            gbAddBook.Name = "gbAddBook";
            gbAddBook.Size = new Size(1108, 726);
            gbAddBook.TabIndex = 0;
            gbAddBook.TabStop = false;
            gbAddBook.Text = "Add Book";
            // 
            // dtpAge
            // 
            dtpAge.Location = new Point(210, 231);
            dtpAge.Name = "dtpAge";
            dtpAge.Size = new Size(250, 27);
            dtpAge.TabIndex = 64;
            // 
            // dtpLastFeedTime
            // 
            dtpLastFeedTime.CustomFormat = "Custom";
            dtpLastFeedTime.Location = new Point(809, 284);
            dtpLastFeedTime.Name = "dtpLastFeedTime";
            dtpLastFeedTime.Size = new Size(250, 27);
            dtpLastFeedTime.TabIndex = 63;
            // 
            // dataGridViewAnimals
            // 
            dataGridViewAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnimals.Location = new Point(27, 348);
            dataGridViewAnimals.Name = "dataGridViewAnimals";
            dataGridViewAnimals.RowHeadersWidth = 51;
            dataGridViewAnimals.Size = new Size(1068, 230);
            dataGridViewAnimals.TabIndex = 62;
            // 
            // lblLastFeedTime
            // 
            lblLastFeedTime.AutoSize = true;
            lblLastFeedTime.Location = new Point(703, 287);
            lblLastFeedTime.Name = "lblLastFeedTime";
            lblLastFeedTime.Size = new Size(100, 20);
            lblLastFeedTime.TabIndex = 58;
            lblLastFeedTime.Text = "LastFeedTime";
            // 
            // chkIsSick
            // 
            chkIsSick.AutoSize = true;
            chkIsSick.Location = new Point(809, 177);
            chkIsSick.Name = "chkIsSick";
            chkIsSick.Size = new Size(57, 24);
            chkIsSick.TabIndex = 57;
            chkIsSick.Text = "Sick";
            chkIsSick.UseVisualStyleBackColor = true;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(809, 225);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(163, 27);
            txtLocation.TabIndex = 56;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(809, 122);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(163, 27);
            txtColor.TabIndex = 55;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(703, 232);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(66, 20);
            lblLocation.TabIndex = 53;
            lblLocation.Text = "Location";
            // 
            // lblsick
            // 
            lblsick.AutoSize = true;
            lblsick.Location = new Point(703, 178);
            lblsick.Name = "lblsick";
            lblsick.Size = new Size(70, 20);
            lblsick.TabIndex = 52;
            lblsick.Text = "Animal is";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(703, 125);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(48, 20);
            lblColor.TabIndex = 51;
            lblColor.Text = "Color:";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(703, 73);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(59, 20);
            lblWeight.TabIndex = 50;
            lblWeight.Text = "Weight:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(107, 291);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(60, 20);
            lblGender.TabIndex = 49;
            lblGender.Text = "Gender:";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(210, 284);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(163, 27);
            txtGender.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 236);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 47;
            label1.Text = "Age:";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(106, 182);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(62, 20);
            lblSpecies.TabIndex = 45;
            lblSpecies.Text = "Species:";
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(210, 175);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(163, 27);
            txtSpecies.TabIndex = 44;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(106, 129);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 43;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(210, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(163, 27);
            txtName.TabIndex = 42;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.OldLace;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnDelete.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnDelete.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.DarkGreen;
            btnDelete.Location = new Point(444, 635);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(201, 31);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.BackColor = Color.OldLace;
            btnAddAnimal.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnAddAnimal.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnAddAnimal.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAnimal.ForeColor = Color.DarkGreen;
            btnAddAnimal.Location = new Point(64, 635);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(201, 31);
            btnAddAnimal.TabIndex = 40;
            btnAddAnimal.Text = "Add";
            btnAddAnimal.UseVisualStyleBackColor = false;
            btnAddAnimal.Click += btnAddAnimal_Click;
            // 
            // btnUpdateAnimal
            // 
            btnUpdateAnimal.BackColor = Color.OldLace;
            btnUpdateAnimal.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnUpdateAnimal.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnUpdateAnimal.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateAnimal.ForeColor = Color.DarkGreen;
            btnUpdateAnimal.Location = new Point(836, 635);
            btnUpdateAnimal.Name = "btnUpdateAnimal";
            btnUpdateAnimal.Size = new Size(201, 31);
            btnUpdateAnimal.TabIndex = 39;
            btnUpdateAnimal.Text = "Update";
            btnUpdateAnimal.UseVisualStyleBackColor = false;
            btnUpdateAnimal.Click += btnUpdateAnimal_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1124, 742);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Health Status";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(809, 70);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(163, 27);
            txtWeight.TabIndex = 54;
            // 
            // AnimalsUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Location = new Point(140, 40);
            Name = "AnimalsUC";
            Size = new Size(1151, 781);
            Load += AnimalsUC_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panelUpdate.ResumeLayout(false);
            panelUpdate.PerformLayout();
            gbAddBook.ResumeLayout(false);
            gbAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimals).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panelUpdate;
        private Label lblUpdateemployee;
        private GroupBox gbAddBook;
        private Button btnUpdateAnimal;
        private TabPage tabPage2;
        private Button btnDelete;
        private Button btnAddAnimal;
        private DataGridView dataGridViewAnimals;
        private TextBox txtLastFeedTime;
        private Label lblLastFeedTime;
        private CheckBox chkIsSick;
        private TextBox txtLocation;
        private TextBox txtColor;
        private Label lblLocation;
        private Label lblsick;
        private Label lblColor;
        private Label lblWeight;
        private Label lblGender;
        private TextBox txtGender;
        private Label label1;
        private Label lblSpecies;
        private TextBox txtSpecies;
        private Label lblName;
        private TextBox txtName;
        private DateTimePicker dtpLastFeedTime;
        private DateTimePicker dtpAge;
        private TextBox txtWeight;
    }
}
