namespace AdminTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddUser = new Button();
            btnEditUser = new Button();
            btnDeleteUser = new Button();
            TBView = new TabControl();
            TbUsers = new TabPage();
            GpboxUser = new GroupBox();
            ListUsers = new ListBox();
            TbGame = new TabPage();
            GpboxGame = new GroupBox();
            listGames = new ListBox();
            btnAddGame = new Button();
            btnEditGame = new Button();
            btnDeleteGame = new Button();
            TbAnalytics = new TabPage();
            GpboxAnalytics = new GroupBox();
            lblAverageRating = new Label();
            dataGridView3 = new DataGridView();
            lblLoginCount = new Label();
            lblReviewCount = new Label();
            TBView.SuspendLayout();
            TbUsers.SuspendLayout();
            GpboxUser.SuspendLayout();
            TbGame.SuspendLayout();
            GpboxGame.SuspendLayout();
            TbAnalytics.SuspendLayout();
            GpboxAnalytics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(21, 28);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(94, 29);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(21, 63);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(94, 29);
            btnEditUser.TabIndex = 1;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(21, 98);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(94, 29);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // TBView
            // 
            TBView.Controls.Add(TbUsers);
            TBView.Controls.Add(TbGame);
            TBView.Controls.Add(TbAnalytics);
            TBView.Location = new Point(23, 50);
            TBView.Name = "TBView";
            TBView.SelectedIndex = 0;
            TBView.Size = new Size(745, 419);
            TBView.TabIndex = 5;
            // 
            // TbUsers
            // 
            TbUsers.Controls.Add(GpboxUser);
            TbUsers.Location = new Point(4, 29);
            TbUsers.Name = "TbUsers";
            TbUsers.Padding = new Padding(3);
            TbUsers.Size = new Size(737, 386);
            TbUsers.TabIndex = 0;
            TbUsers.Text = "Users";
            TbUsers.UseVisualStyleBackColor = true;
            // 
            // GpboxUser
            // 
            GpboxUser.Controls.Add(ListUsers);
            GpboxUser.Controls.Add(btnDeleteUser);
            GpboxUser.Controls.Add(btnAddUser);
            GpboxUser.Controls.Add(btnEditUser);
            GpboxUser.Location = new Point(19, 23);
            GpboxUser.Name = "GpboxUser";
            GpboxUser.Size = new Size(364, 332);
            GpboxUser.TabIndex = 5;
            GpboxUser.TabStop = false;
            GpboxUser.Text = "User Management";
            // 
            // ListUsers
            // 
            ListUsers.FormattingEnabled = true;
            ListUsers.Location = new Point(21, 133);
            ListUsers.Name = "ListUsers";
            ListUsers.Size = new Size(296, 184);
            ListUsers.TabIndex = 5;
            // 
            // TbGame
            // 
            TbGame.Controls.Add(GpboxGame);
            TbGame.Location = new Point(4, 29);
            TbGame.Name = "TbGame";
            TbGame.Padding = new Padding(3);
            TbGame.Size = new Size(737, 386);
            TbGame.TabIndex = 1;
            TbGame.Text = "Game";
            TbGame.UseVisualStyleBackColor = true;
            // 
            // GpboxGame
            // 
            GpboxGame.Controls.Add(listGames);
            GpboxGame.Controls.Add(btnAddGame);
            GpboxGame.Controls.Add(btnEditGame);
            GpboxGame.Controls.Add(btnDeleteGame);
            GpboxGame.Location = new Point(34, 35);
            GpboxGame.Name = "GpboxGame";
            GpboxGame.Size = new Size(364, 332);
            GpboxGame.TabIndex = 5;
            GpboxGame.TabStop = false;
            GpboxGame.Text = "Game Management";
            // 
            // listGames
            // 
            listGames.FormattingEnabled = true;
            listGames.Location = new Point(30, 131);
            listGames.Name = "listGames";
            listGames.Size = new Size(288, 184);
            listGames.TabIndex = 3;
            // 
            // btnAddGame
            // 
            btnAddGame.Location = new Point(30, 26);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(94, 29);
            btnAddGame.TabIndex = 0;
            btnAddGame.Text = "Add Game";
            btnAddGame.UseVisualStyleBackColor = true;
            // 
            // btnEditGame
            // 
            btnEditGame.Location = new Point(30, 61);
            btnEditGame.Name = "btnEditGame";
            btnEditGame.Size = new Size(94, 29);
            btnEditGame.TabIndex = 1;
            btnEditGame.Text = "Edit Game";
            btnEditGame.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGame
            // 
            btnDeleteGame.Location = new Point(30, 96);
            btnDeleteGame.Name = "btnDeleteGame";
            btnDeleteGame.Size = new Size(109, 29);
            btnDeleteGame.TabIndex = 2;
            btnDeleteGame.Text = "Delete Game";
            btnDeleteGame.UseVisualStyleBackColor = true;
            // 
            // TbAnalytics
            // 
            TbAnalytics.Controls.Add(GpboxAnalytics);
            TbAnalytics.Location = new Point(4, 29);
            TbAnalytics.Name = "TbAnalytics";
            TbAnalytics.Padding = new Padding(3);
            TbAnalytics.Size = new Size(737, 386);
            TbAnalytics.TabIndex = 2;
            TbAnalytics.Text = "Analytics";
            TbAnalytics.UseVisualStyleBackColor = true;
            // 
            // GpboxAnalytics
            // 
            GpboxAnalytics.Controls.Add(lblAverageRating);
            GpboxAnalytics.Controls.Add(dataGridView3);
            GpboxAnalytics.Controls.Add(lblLoginCount);
            GpboxAnalytics.Controls.Add(lblReviewCount);
            GpboxAnalytics.Location = new Point(19, 20);
            GpboxAnalytics.Name = "GpboxAnalytics";
            GpboxAnalytics.Size = new Size(466, 326);
            GpboxAnalytics.TabIndex = 2;
            GpboxAnalytics.TabStop = false;
            GpboxAnalytics.Text = "Analytics Display";
            // 
            // lblAverageRating
            // 
            lblAverageRating.AutoSize = true;
            lblAverageRating.Location = new Point(18, 105);
            lblAverageRating.Name = "lblAverageRating";
            lblAverageRating.Size = new Size(111, 20);
            lblAverageRating.TabIndex = 4;
            lblAverageRating.Text = "Average Rating";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(18, 138);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(300, 188);
            dataGridView3.TabIndex = 3;
            // 
            // lblLoginCount
            // 
            lblLoginCount.AutoSize = true;
            lblLoginCount.Location = new Point(18, 35);
            lblLoginCount.Name = "lblLoginCount";
            lblLoginCount.Size = new Size(122, 20);
            lblLoginCount.TabIndex = 0;
            lblLoginCount.Text = "User Login Count";
            // 
            // lblReviewCount
            // 
            lblReviewCount.AutoSize = true;
            lblReviewCount.Location = new Point(18, 71);
            lblReviewCount.Name = "lblReviewCount";
            lblReviewCount.Size = new Size(142, 20);
            lblReviewCount.TabIndex = 1;
            lblReviewCount.Text = "Game Review Count";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 575);
            Controls.Add(TBView);
            Name = "Form1";
            Text = "Game-Review-Admin-Tool(GRAT)";
            TBView.ResumeLayout(false);
            TbUsers.ResumeLayout(false);
            GpboxUser.ResumeLayout(false);
            TbGame.ResumeLayout(false);
            GpboxGame.ResumeLayout(false);
            TbAnalytics.ResumeLayout(false);
            GpboxAnalytics.ResumeLayout(false);
            GpboxAnalytics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddUser;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private TabControl TBView;
        private TabPage TbUsers;
        private TabPage TbGame;
        private GroupBox GpboxGame;
        private Button btnAddGame;
        private DataGridView dataGridView2;
        private Button btnEditGame;
        private Button btnDeleteGame;
        private TabPage TbAnalytics;
        private Label lblLoginCount;
        private GroupBox GpboxAnalytics;
        private DataGridView dataGridView3;
        private Label lblReviewCount;
        private ListBox ListUsers;
        private GroupBox GpboxUser;
        private ListBox listGames;
        private Label lblAverageRating;
    }
}
