namespace ZooBazarDesktopApp
{
    partial class Animal
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
            TabViewerAnimal = new TabControl();
            tabAnimalManager = new TabPage();
            dgvAnimals = new DataGridView();
            gbAnimalDeploy = new GroupBox();
            btnDeport = new Button();
            btnDeploy = new Button();
            lblLocation = new Label();
            lblAnimalNameDeploy = new Label();
            cbAnimalLocation = new ComboBox();
            lblName = new Label();
            gbZooLocation = new GroupBox();
            lblLocations = new Label();
            txtZooLocations = new TextBox();
            btnAddLocation = new Button();
            tabAnimalNew = new TabPage();
            gbNewAnimal = new GroupBox();
            numWeightNew = new NumericUpDown();
            lblWeight = new Label();
            txtColorNew = new TextBox();
            lblColor = new Label();
            dtpAgeNew = new DateTimePicker();
            btnAddAnimalNew = new Button();
            lblAgeNew = new Label();
            lblSpeciesNew = new Label();
            cbSpeciesNew = new ComboBox();
            txtNameNew = new TextBox();
            lblNameNew = new Label();
            gbSpecies = new GroupBox();
            btnAddSpecies = new Button();
            lblSpeciesInput = new Label();
            txtSpecies = new TextBox();
            dgvAnimal = new DataGridView();
            tabAnimalStaff = new TabPage();
            gbNotifficationView = new GroupBox();
            txtNotifficationView = new TextBox();
            cbNotifficationView = new ComboBox();
            gbAnimalView = new GroupBox();
            radbtnNotifficationNoView = new RadioButton();
            radbtnNotifficationView = new RadioButton();
            btnUpdateAnimalView = new Button();
            txtTaskView = new TextBox();
            lblTaskView = new Label();
            lblUpdateView = new Label();
            lblAnimalLocationView = new Label();
            lblLocationView = new Label();
            lblAnimalNameView = new Label();
            lblNameView = new Label();
            dgvAnimalView = new DataGridView();
            tabAnimalClinic = new TabPage();
            gbNotifficationCare = new GroupBox();
            txtNotifficationCare = new TextBox();
            gbAnimalCare = new GroupBox();
            lblremedyCare = new Label();
            btnUpdateAnimalCare = new Button();
            txtRemedyCare = new TextBox();
            lblAnimalLocationCare = new Label();
            lblLocationCare = new Label();
            lblAnimalNameCare = new Label();
            lblNameCare = new Label();
            dgvAnimalCare = new DataGridView();
            tabAnimalHistory = new TabPage();
            gbAnimalDeportHistory = new GroupBox();
            btnviewAnimalDeportHistory = new Button();
            lblAnimalLocationDeportHistory = new Label();
            lblLocationDeportHistory = new Label();
            lblAnimalAgeDeportHistory = new Label();
            lblAnimalDateDeportHistory = new Label();
            lblAnimalNameDeportHistory = new Label();
            lblAgeDeportHistory = new Label();
            lblDateDeportHistory = new Label();
            lblNameDeportHistory = new Label();
            dgvAnimalDeportHistory = new DataGridView();
            gbDeployHistory = new GroupBox();
            btnViewAnimalDeployHistory = new Button();
            lblAnimalLocationDeployHistory = new Label();
            lblLocationDeployHistory = new Label();
            lblAnimalAgeDeployHistory = new Label();
            lblAnimalDateDeployHistory = new Label();
            lblAnimalNameDeployHistory = new Label();
            lblAgeDeployHistory = new Label();
            lblDateDeployHistory = new Label();
            lblNameDeployHistory = new Label();
            dgvAnimalDeployHistory = new DataGridView();
            TabAnimalStatus = new TabPage();
            groupBoxesPanel = new Panel();
            TabViewerAnimal.SuspendLayout();
            tabAnimalManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            gbAnimalDeploy.SuspendLayout();
            gbZooLocation.SuspendLayout();
            tabAnimalNew.SuspendLayout();
            gbNewAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numWeightNew).BeginInit();
            gbSpecies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimal).BeginInit();
            tabAnimalStaff.SuspendLayout();
            gbNotifficationView.SuspendLayout();
            gbAnimalView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimalView).BeginInit();
            tabAnimalClinic.SuspendLayout();
            gbNotifficationCare.SuspendLayout();
            gbAnimalCare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimalCare).BeginInit();
            tabAnimalHistory.SuspendLayout();
            gbAnimalDeportHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimalDeportHistory).BeginInit();
            gbDeployHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimalDeployHistory).BeginInit();
            TabAnimalStatus.SuspendLayout();
            SuspendLayout();
            // 
            // TabViewerAnimal
            // 
            TabViewerAnimal.Controls.Add(tabAnimalManager);
            TabViewerAnimal.Controls.Add(tabAnimalNew);
            TabViewerAnimal.Controls.Add(tabAnimalStaff);
            TabViewerAnimal.Controls.Add(tabAnimalClinic);
            TabViewerAnimal.Controls.Add(tabAnimalHistory);
            TabViewerAnimal.Controls.Add(TabAnimalStatus);
            TabViewerAnimal.Location = new Point(12, 12);
            TabViewerAnimal.Name = "TabViewerAnimal";
            TabViewerAnimal.SelectedIndex = 0;
            TabViewerAnimal.Size = new Size(776, 426);
            TabViewerAnimal.TabIndex = 0;
            // 
            // tabAnimalManager
            // 
            tabAnimalManager.Controls.Add(dgvAnimals);
            tabAnimalManager.Controls.Add(gbAnimalDeploy);
            tabAnimalManager.Controls.Add(gbZooLocation);
            tabAnimalManager.Location = new Point(4, 29);
            tabAnimalManager.Name = "tabAnimalManager";
            tabAnimalManager.Padding = new Padding(3);
            tabAnimalManager.Size = new Size(768, 393);
            tabAnimalManager.TabIndex = 0;
            tabAnimalManager.Text = "Animal manager";
            tabAnimalManager.UseVisualStyleBackColor = true;
            // 
            // dgvAnimals
            // 
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(278, 6);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.Size = new Size(484, 384);
            dgvAnimals.TabIndex = 7;
            dgvAnimals.CellClick += dgvAnimals_CellClick_1;
            // 
            // gbAnimalDeploy
            // 
            gbAnimalDeploy.Controls.Add(btnDeport);
            gbAnimalDeploy.Controls.Add(btnDeploy);
            gbAnimalDeploy.Controls.Add(lblLocation);
            gbAnimalDeploy.Controls.Add(lblAnimalNameDeploy);
            gbAnimalDeploy.Controls.Add(cbAnimalLocation);
            gbAnimalDeploy.Controls.Add(lblName);
            gbAnimalDeploy.Location = new Point(6, 18);
            gbAnimalDeploy.Name = "gbAnimalDeploy";
            gbAnimalDeploy.Size = new Size(250, 194);
            gbAnimalDeploy.TabIndex = 6;
            gbAnimalDeploy.TabStop = false;
            gbAnimalDeploy.Text = "Animal deployment";
            // 
            // btnDeport
            // 
            btnDeport.Location = new Point(147, 95);
            btnDeport.Name = "btnDeport";
            btnDeport.Size = new Size(94, 29);
            btnDeport.TabIndex = 11;
            btnDeport.Text = "Deport";
            btnDeport.UseVisualStyleBackColor = true;
            btnDeport.Click += btnDeport_Click;
            // 
            // btnDeploy
            // 
            btnDeploy.Location = new Point(47, 95);
            btnDeploy.Name = "btnDeploy";
            btnDeploy.Size = new Size(94, 29);
            btnDeploy.TabIndex = 10;
            btnDeploy.Text = "Deploy";
            btnDeploy.UseVisualStyleBackColor = true;
            btnDeploy.Click += btnDeploy_Click;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(10, 64);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(66, 20);
            lblLocation.TabIndex = 9;
            lblLocation.Text = "Location";
            // 
            // lblAnimalNameDeploy
            // 
            lblAnimalNameDeploy.AutoSize = true;
            lblAnimalNameDeploy.Location = new Point(89, 38);
            lblAnimalNameDeploy.Name = "lblAnimalNameDeploy";
            lblAnimalNameDeploy.Size = new Size(99, 20);
            lblAnimalNameDeploy.TabIndex = 6;
            lblAnimalNameDeploy.Text = "Animal.Name";
            // 
            // cbAnimalLocation
            // 
            cbAnimalLocation.FormattingEnabled = true;
            cbAnimalLocation.Location = new Point(77, 61);
            cbAnimalLocation.Name = "cbAnimalLocation";
            cbAnimalLocation.Size = new Size(151, 28);
            cbAnimalLocation.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(14, 38);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // gbZooLocation
            // 
            gbZooLocation.Controls.Add(lblLocations);
            gbZooLocation.Controls.Add(txtZooLocations);
            gbZooLocation.Controls.Add(btnAddLocation);
            gbZooLocation.Location = new Point(6, 229);
            gbZooLocation.Name = "gbZooLocation";
            gbZooLocation.Size = new Size(250, 158);
            gbZooLocation.TabIndex = 5;
            gbZooLocation.TabStop = false;
            gbZooLocation.Text = "Zoo Locations ";
            // 
            // lblLocations
            // 
            lblLocations.AutoSize = true;
            lblLocations.Location = new Point(14, 43);
            lblLocations.Name = "lblLocations";
            lblLocations.Size = new Size(72, 20);
            lblLocations.TabIndex = 2;
            lblLocations.Text = "Locations";
            // 
            // txtZooLocations
            // 
            txtZooLocations.Location = new Point(119, 40);
            txtZooLocations.Name = "txtZooLocations";
            txtZooLocations.Size = new Size(125, 27);
            txtZooLocations.TabIndex = 3;
            // 
            // btnAddLocation
            // 
            btnAddLocation.Location = new Point(14, 80);
            btnAddLocation.Name = "btnAddLocation";
            btnAddLocation.Size = new Size(120, 29);
            btnAddLocation.TabIndex = 1;
            btnAddLocation.Text = "Add locations";
            btnAddLocation.UseVisualStyleBackColor = true;
            btnAddLocation.Click += btnAddLocation_Click;
            // 
            // tabAnimalNew
            // 
            tabAnimalNew.Controls.Add(gbNewAnimal);
            tabAnimalNew.Controls.Add(gbSpecies);
            tabAnimalNew.Controls.Add(dgvAnimal);
            tabAnimalNew.Location = new Point(4, 29);
            tabAnimalNew.Name = "tabAnimalNew";
            tabAnimalNew.Padding = new Padding(3);
            tabAnimalNew.Size = new Size(768, 393);
            tabAnimalNew.TabIndex = 1;
            tabAnimalNew.Text = "Animal add ";
            tabAnimalNew.UseVisualStyleBackColor = true;
            // 
            // gbNewAnimal
            // 
            gbNewAnimal.Controls.Add(numWeightNew);
            gbNewAnimal.Controls.Add(lblWeight);
            gbNewAnimal.Controls.Add(txtColorNew);
            gbNewAnimal.Controls.Add(lblColor);
            gbNewAnimal.Controls.Add(dtpAgeNew);
            gbNewAnimal.Controls.Add(btnAddAnimalNew);
            gbNewAnimal.Controls.Add(lblAgeNew);
            gbNewAnimal.Controls.Add(lblSpeciesNew);
            gbNewAnimal.Controls.Add(cbSpeciesNew);
            gbNewAnimal.Controls.Add(txtNameNew);
            gbNewAnimal.Controls.Add(lblNameNew);
            gbNewAnimal.Location = new Point(6, 6);
            gbNewAnimal.Name = "gbNewAnimal";
            gbNewAnimal.Size = new Size(330, 266);
            gbNewAnimal.TabIndex = 5;
            gbNewAnimal.TabStop = false;
            gbNewAnimal.Text = "Introduce new animal";
            // 
            // numWeightNew
            // 
            numWeightNew.Location = new Point(138, 129);
            numWeightNew.Name = "numWeightNew";
            numWeightNew.Size = new Size(150, 27);
            numWeightNew.TabIndex = 16;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(18, 132);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(56, 20);
            lblWeight.TabIndex = 14;
            lblWeight.Text = "Weight";
            // 
            // txtColorNew
            // 
            txtColorNew.Location = new Point(138, 96);
            txtColorNew.Name = "txtColorNew";
            txtColorNew.Size = new Size(151, 27);
            txtColorNew.TabIndex = 12;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(18, 99);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(45, 20);
            lblColor.TabIndex = 10;
            lblColor.Text = "Color";
            // 
            // dtpAgeNew
            // 
            dtpAgeNew.Location = new Point(80, 164);
            dtpAgeNew.Name = "dtpAgeNew";
            dtpAgeNew.Size = new Size(250, 27);
            dtpAgeNew.TabIndex = 8;
            // 
            // btnAddAnimalNew
            // 
            btnAddAnimalNew.Location = new Point(135, 195);
            btnAddAnimalNew.Name = "btnAddAnimalNew";
            btnAddAnimalNew.Size = new Size(151, 29);
            btnAddAnimalNew.TabIndex = 7;
            btnAddAnimalNew.Text = "Add animal";
            btnAddAnimalNew.UseVisualStyleBackColor = true;
            btnAddAnimalNew.Click += btnAddAnimalNew_Click;
            // 
            // lblAgeNew
            // 
            lblAgeNew.AutoSize = true;
            lblAgeNew.Location = new Point(18, 169);
            lblAgeNew.Name = "lblAgeNew";
            lblAgeNew.Size = new Size(36, 20);
            lblAgeNew.TabIndex = 7;
            lblAgeNew.Text = "Age";
            // 
            // lblSpeciesNew
            // 
            lblSpeciesNew.AutoSize = true;
            lblSpeciesNew.Location = new Point(18, 66);
            lblSpeciesNew.Name = "lblSpeciesNew";
            lblSpeciesNew.Size = new Size(59, 20);
            lblSpeciesNew.TabIndex = 7;
            lblSpeciesNew.Text = "Species";
            // 
            // cbSpeciesNew
            // 
            cbSpeciesNew.FormattingEnabled = true;
            cbSpeciesNew.Location = new Point(138, 63);
            cbSpeciesNew.Name = "cbSpeciesNew";
            cbSpeciesNew.Size = new Size(151, 28);
            cbSpeciesNew.TabIndex = 7;
            // 
            // txtNameNew
            // 
            txtNameNew.Location = new Point(138, 30);
            txtNameNew.Name = "txtNameNew";
            txtNameNew.Size = new Size(151, 27);
            txtNameNew.TabIndex = 7;
            // 
            // lblNameNew
            // 
            lblNameNew.AutoSize = true;
            lblNameNew.Location = new Point(18, 33);
            lblNameNew.Name = "lblNameNew";
            lblNameNew.Size = new Size(49, 20);
            lblNameNew.TabIndex = 7;
            lblNameNew.Text = "Name";
            // 
            // gbSpecies
            // 
            gbSpecies.Controls.Add(btnAddSpecies);
            gbSpecies.Controls.Add(lblSpeciesInput);
            gbSpecies.Controls.Add(txtSpecies);
            gbSpecies.Location = new Point(6, 278);
            gbSpecies.Name = "gbSpecies";
            gbSpecies.Size = new Size(330, 109);
            gbSpecies.TabIndex = 4;
            gbSpecies.TabStop = false;
            gbSpecies.Text = "Animal species";
            // 
            // btnAddSpecies
            // 
            btnAddSpecies.Location = new Point(18, 74);
            btnAddSpecies.Name = "btnAddSpecies";
            btnAddSpecies.Size = new Size(151, 29);
            btnAddSpecies.TabIndex = 16;
            btnAddSpecies.Text = "Add species";
            btnAddSpecies.UseVisualStyleBackColor = true;
            btnAddSpecies.Click += btnAddSpecies_Click;
            // 
            // lblSpeciesInput
            // 
            lblSpeciesInput.AutoSize = true;
            lblSpeciesInput.Location = new Point(18, 33);
            lblSpeciesInput.Name = "lblSpeciesInput";
            lblSpeciesInput.Size = new Size(59, 20);
            lblSpeciesInput.TabIndex = 6;
            lblSpeciesInput.Text = "Species";
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(138, 30);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(151, 27);
            txtSpecies.TabIndex = 6;
            // 
            // dgvAnimal
            // 
            dgvAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimal.Location = new Point(342, 16);
            dgvAnimal.Name = "dgvAnimal";
            dgvAnimal.RowHeadersWidth = 51;
            dgvAnimal.Size = new Size(420, 371);
            dgvAnimal.TabIndex = 0;
            // 
            // tabAnimalStaff
            // 
            tabAnimalStaff.Controls.Add(gbNotifficationView);
            tabAnimalStaff.Controls.Add(gbAnimalView);
            tabAnimalStaff.Controls.Add(dgvAnimalView);
            tabAnimalStaff.Location = new Point(4, 29);
            tabAnimalStaff.Name = "tabAnimalStaff";
            tabAnimalStaff.Padding = new Padding(3);
            tabAnimalStaff.Size = new Size(768, 393);
            tabAnimalStaff.TabIndex = 2;
            tabAnimalStaff.Text = "Animal staff update";
            tabAnimalStaff.UseVisualStyleBackColor = true;
            // 
            // gbNotifficationView
            // 
            gbNotifficationView.Controls.Add(txtNotifficationView);
            gbNotifficationView.Controls.Add(cbNotifficationView);
            gbNotifficationView.Location = new Point(6, 243);
            gbNotifficationView.Name = "gbNotifficationView";
            gbNotifficationView.Size = new Size(307, 144);
            gbNotifficationView.TabIndex = 8;
            gbNotifficationView.TabStop = false;
            gbNotifficationView.Text = "Notiffication";
            // 
            // txtNotifficationView
            // 
            txtNotifficationView.Location = new Point(136, 44);
            txtNotifficationView.Name = "txtNotifficationView";
            txtNotifficationView.Size = new Size(165, 27);
            txtNotifficationView.TabIndex = 1;
            // 
            // cbNotifficationView
            // 
            cbNotifficationView.FormattingEnabled = true;
            cbNotifficationView.Location = new Point(6, 43);
            cbNotifficationView.Name = "cbNotifficationView";
            cbNotifficationView.Size = new Size(114, 28);
            cbNotifficationView.TabIndex = 0;
            // 
            // gbAnimalView
            // 
            gbAnimalView.Controls.Add(radbtnNotifficationNoView);
            gbAnimalView.Controls.Add(radbtnNotifficationView);
            gbAnimalView.Controls.Add(btnUpdateAnimalView);
            gbAnimalView.Controls.Add(txtTaskView);
            gbAnimalView.Controls.Add(lblTaskView);
            gbAnimalView.Controls.Add(lblUpdateView);
            gbAnimalView.Controls.Add(lblAnimalLocationView);
            gbAnimalView.Controls.Add(lblLocationView);
            gbAnimalView.Controls.Add(lblAnimalNameView);
            gbAnimalView.Controls.Add(lblNameView);
            gbAnimalView.Location = new Point(6, 6);
            gbAnimalView.Name = "gbAnimalView";
            gbAnimalView.Size = new Size(307, 231);
            gbAnimalView.TabIndex = 7;
            gbAnimalView.TabStop = false;
            gbAnimalView.Text = "Animal view";
            // 
            // radbtnNotifficationNoView
            // 
            radbtnNotifficationNoView.AutoSize = true;
            radbtnNotifficationNoView.Location = new Point(187, 104);
            radbtnNotifficationNoView.Name = "radbtnNotifficationNoView";
            radbtnNotifficationNoView.Size = new Size(47, 24);
            radbtnNotifficationNoView.TabIndex = 17;
            radbtnNotifficationNoView.TabStop = true;
            radbtnNotifficationNoView.Text = "no";
            radbtnNotifficationNoView.UseVisualStyleBackColor = true;
            // 
            // radbtnNotifficationView
            // 
            radbtnNotifficationView.AutoSize = true;
            radbtnNotifficationView.Location = new Point(122, 104);
            radbtnNotifficationView.Name = "radbtnNotifficationView";
            radbtnNotifficationView.Size = new Size(51, 24);
            radbtnNotifficationView.TabIndex = 16;
            radbtnNotifficationView.TabStop = true;
            radbtnNotifficationView.Text = "Yes";
            radbtnNotifficationView.UseVisualStyleBackColor = true;
            radbtnNotifficationView.CheckedChanged += radbtnNotifficationView_CheckedChanged;
            // 
            // btnUpdateAnimalView
            // 
            btnUpdateAnimalView.Location = new Point(122, 175);
            btnUpdateAnimalView.Name = "btnUpdateAnimalView";
            btnUpdateAnimalView.Size = new Size(94, 29);
            btnUpdateAnimalView.TabIndex = 15;
            btnUpdateAnimalView.Text = "Update";
            btnUpdateAnimalView.UseVisualStyleBackColor = true;
            btnUpdateAnimalView.Click += btnUpdateAnimalView_Click;
            // 
            // txtTaskView
            // 
            txtTaskView.Location = new Point(122, 142);
            txtTaskView.Name = "txtTaskView";
            txtTaskView.Size = new Size(125, 27);
            txtTaskView.TabIndex = 14;
            // 
            // lblTaskView
            // 
            lblTaskView.AutoSize = true;
            lblTaskView.Location = new Point(14, 142);
            lblTaskView.Name = "lblTaskView";
            lblTaskView.Size = new Size(36, 20);
            lblTaskView.TabIndex = 12;
            lblTaskView.Text = "Task";
            // 
            // lblUpdateView
            // 
            lblUpdateView.AutoSize = true;
            lblUpdateView.Location = new Point(14, 104);
            lblUpdateView.Name = "lblUpdateView";
            lblUpdateView.Size = new Size(58, 20);
            lblUpdateView.TabIndex = 11;
            lblUpdateView.Text = "Update";
            // 
            // lblAnimalLocationView
            // 
            lblAnimalLocationView.AutoSize = true;
            lblAnimalLocationView.Location = new Point(122, 71);
            lblAnimalLocationView.Name = "lblAnimalLocationView";
            lblAnimalLocationView.Size = new Size(116, 20);
            lblAnimalLocationView.TabIndex = 10;
            lblAnimalLocationView.Text = "Animal.Location";
            // 
            // lblLocationView
            // 
            lblLocationView.AutoSize = true;
            lblLocationView.Location = new Point(14, 71);
            lblLocationView.Name = "lblLocationView";
            lblLocationView.Size = new Size(66, 20);
            lblLocationView.TabIndex = 9;
            lblLocationView.Text = "Location";
            // 
            // lblAnimalNameView
            // 
            lblAnimalNameView.AutoSize = true;
            lblAnimalNameView.Location = new Point(122, 38);
            lblAnimalNameView.Name = "lblAnimalNameView";
            lblAnimalNameView.Size = new Size(99, 20);
            lblAnimalNameView.TabIndex = 6;
            lblAnimalNameView.Text = "Animal.Name";
            // 
            // lblNameView
            // 
            lblNameView.AutoSize = true;
            lblNameView.Location = new Point(14, 38);
            lblNameView.Name = "lblNameView";
            lblNameView.Size = new Size(49, 20);
            lblNameView.TabIndex = 2;
            lblNameView.Text = "Name";
            // 
            // dgvAnimalView
            // 
            dgvAnimalView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimalView.Location = new Point(328, 6);
            dgvAnimalView.Name = "dgvAnimalView";
            dgvAnimalView.RowHeadersWidth = 51;
            dgvAnimalView.Size = new Size(434, 381);
            dgvAnimalView.TabIndex = 0;
            dgvAnimalView.CellClick += dgvAnimalView_CellClick;
            // 
            // tabAnimalClinic
            // 
            tabAnimalClinic.Controls.Add(gbNotifficationCare);
            tabAnimalClinic.Controls.Add(gbAnimalCare);
            tabAnimalClinic.Controls.Add(dgvAnimalCare);
            tabAnimalClinic.Location = new Point(4, 29);
            tabAnimalClinic.Name = "tabAnimalClinic";
            tabAnimalClinic.Padding = new Padding(3);
            tabAnimalClinic.Size = new Size(768, 393);
            tabAnimalClinic.TabIndex = 3;
            tabAnimalClinic.Text = "Animal clinic";
            tabAnimalClinic.UseVisualStyleBackColor = true;
            // 
            // gbNotifficationCare
            // 
            gbNotifficationCare.Controls.Add(txtNotifficationCare);
            gbNotifficationCare.Location = new Point(6, 255);
            gbNotifficationCare.Name = "gbNotifficationCare";
            gbNotifficationCare.Size = new Size(307, 132);
            gbNotifficationCare.TabIndex = 9;
            gbNotifficationCare.TabStop = false;
            gbNotifficationCare.Text = "Notiffication";
            // 
            // txtNotifficationCare
            // 
            txtNotifficationCare.Location = new Point(14, 44);
            txtNotifficationCare.Name = "txtNotifficationCare";
            txtNotifficationCare.Size = new Size(287, 27);
            txtNotifficationCare.TabIndex = 1;
            // 
            // gbAnimalCare
            // 
            gbAnimalCare.Controls.Add(lblremedyCare);
            gbAnimalCare.Controls.Add(btnUpdateAnimalCare);
            gbAnimalCare.Controls.Add(txtRemedyCare);
            gbAnimalCare.Controls.Add(lblAnimalLocationCare);
            gbAnimalCare.Controls.Add(lblLocationCare);
            gbAnimalCare.Controls.Add(lblAnimalNameCare);
            gbAnimalCare.Controls.Add(lblNameCare);
            gbAnimalCare.Location = new Point(6, 6);
            gbAnimalCare.Name = "gbAnimalCare";
            gbAnimalCare.Size = new Size(307, 229);
            gbAnimalCare.TabIndex = 8;
            gbAnimalCare.TabStop = false;
            gbAnimalCare.Text = "Animal Care";
            // 
            // lblremedyCare
            // 
            lblremedyCare.AutoSize = true;
            lblremedyCare.Location = new Point(17, 102);
            lblremedyCare.Name = "lblremedyCare";
            lblremedyCare.Size = new Size(63, 20);
            lblremedyCare.TabIndex = 17;
            lblremedyCare.Text = "Remedy";
            // 
            // btnUpdateAnimalCare
            // 
            btnUpdateAnimalCare.Location = new Point(122, 148);
            btnUpdateAnimalCare.Name = "btnUpdateAnimalCare";
            btnUpdateAnimalCare.Size = new Size(94, 29);
            btnUpdateAnimalCare.TabIndex = 15;
            btnUpdateAnimalCare.Text = "Update";
            btnUpdateAnimalCare.UseVisualStyleBackColor = true;
            btnUpdateAnimalCare.Click += btnUpdateAnimalCare_Click;
            // 
            // txtRemedyCare
            // 
            txtRemedyCare.Location = new Point(122, 102);
            txtRemedyCare.Name = "txtRemedyCare";
            txtRemedyCare.Size = new Size(125, 27);
            txtRemedyCare.TabIndex = 14;
            // 
            // lblAnimalLocationCare
            // 
            lblAnimalLocationCare.AutoSize = true;
            lblAnimalLocationCare.Location = new Point(122, 71);
            lblAnimalLocationCare.Name = "lblAnimalLocationCare";
            lblAnimalLocationCare.Size = new Size(116, 20);
            lblAnimalLocationCare.TabIndex = 10;
            lblAnimalLocationCare.Text = "Animal.Location";
            // 
            // lblLocationCare
            // 
            lblLocationCare.AutoSize = true;
            lblLocationCare.Location = new Point(14, 71);
            lblLocationCare.Name = "lblLocationCare";
            lblLocationCare.Size = new Size(66, 20);
            lblLocationCare.TabIndex = 9;
            lblLocationCare.Text = "Location";
            // 
            // lblAnimalNameCare
            // 
            lblAnimalNameCare.AutoSize = true;
            lblAnimalNameCare.Location = new Point(122, 38);
            lblAnimalNameCare.Name = "lblAnimalNameCare";
            lblAnimalNameCare.Size = new Size(99, 20);
            lblAnimalNameCare.TabIndex = 6;
            lblAnimalNameCare.Text = "Animal.Name";
            // 
            // lblNameCare
            // 
            lblNameCare.AutoSize = true;
            lblNameCare.Location = new Point(14, 38);
            lblNameCare.Name = "lblNameCare";
            lblNameCare.Size = new Size(49, 20);
            lblNameCare.TabIndex = 2;
            lblNameCare.Text = "Name";
            // 
            // dgvAnimalCare
            // 
            dgvAnimalCare.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimalCare.Location = new Point(338, 6);
            dgvAnimalCare.Name = "dgvAnimalCare";
            dgvAnimalCare.RowHeadersWidth = 51;
            dgvAnimalCare.Size = new Size(424, 381);
            dgvAnimalCare.TabIndex = 0;
            dgvAnimalCare.CellClick += dgvAnimalCare_CellClick;
            // 
            // tabAnimalHistory
            // 
            tabAnimalHistory.Controls.Add(gbAnimalDeportHistory);
            tabAnimalHistory.Controls.Add(dgvAnimalDeportHistory);
            tabAnimalHistory.Controls.Add(gbDeployHistory);
            tabAnimalHistory.Controls.Add(dgvAnimalDeployHistory);
            tabAnimalHistory.Location = new Point(4, 29);
            tabAnimalHistory.Name = "tabAnimalHistory";
            tabAnimalHistory.Padding = new Padding(3);
            tabAnimalHistory.Size = new Size(768, 393);
            tabAnimalHistory.TabIndex = 4;
            tabAnimalHistory.Text = "Animal history";
            tabAnimalHistory.UseVisualStyleBackColor = true;
            // 
            // gbAnimalDeportHistory
            // 
            gbAnimalDeportHistory.Controls.Add(btnviewAnimalDeportHistory);
            gbAnimalDeportHistory.Controls.Add(lblAnimalLocationDeportHistory);
            gbAnimalDeportHistory.Controls.Add(lblLocationDeportHistory);
            gbAnimalDeportHistory.Controls.Add(lblAnimalAgeDeportHistory);
            gbAnimalDeportHistory.Controls.Add(lblAnimalDateDeportHistory);
            gbAnimalDeportHistory.Controls.Add(lblAnimalNameDeportHistory);
            gbAnimalDeportHistory.Controls.Add(lblAgeDeportHistory);
            gbAnimalDeportHistory.Controls.Add(lblDateDeportHistory);
            gbAnimalDeportHistory.Controls.Add(lblNameDeportHistory);
            gbAnimalDeportHistory.Location = new Point(6, 216);
            gbAnimalDeportHistory.Name = "gbAnimalDeportHistory";
            gbAnimalDeportHistory.Size = new Size(298, 171);
            gbAnimalDeportHistory.TabIndex = 16;
            gbAnimalDeportHistory.TabStop = false;
            gbAnimalDeportHistory.Text = "Deport History";
            // 
            // btnviewAnimalDeportHistory
            // 
            btnviewAnimalDeportHistory.Location = new Point(127, 136);
            btnviewAnimalDeportHistory.Name = "btnviewAnimalDeportHistory";
            btnviewAnimalDeportHistory.Size = new Size(94, 29);
            btnviewAnimalDeportHistory.TabIndex = 15;
            btnviewAnimalDeportHistory.Text = "View more";
            btnviewAnimalDeportHistory.UseVisualStyleBackColor = true;
            // 
            // lblAnimalLocationDeportHistory
            // 
            lblAnimalLocationDeportHistory.AutoSize = true;
            lblAnimalLocationDeportHistory.Location = new Point(122, 108);
            lblAnimalLocationDeportHistory.Name = "lblAnimalLocationDeportHistory";
            lblAnimalLocationDeportHistory.Size = new Size(116, 20);
            lblAnimalLocationDeportHistory.TabIndex = 10;
            lblAnimalLocationDeportHistory.Text = "Animal.Location";
            // 
            // lblLocationDeportHistory
            // 
            lblLocationDeportHistory.AutoSize = true;
            lblLocationDeportHistory.Location = new Point(6, 108);
            lblLocationDeportHistory.Name = "lblLocationDeportHistory";
            lblLocationDeportHistory.Size = new Size(66, 20);
            lblLocationDeportHistory.TabIndex = 9;
            lblLocationDeportHistory.Text = "Location";
            // 
            // lblAnimalAgeDeportHistory
            // 
            lblAnimalAgeDeportHistory.AutoSize = true;
            lblAnimalAgeDeportHistory.Location = new Point(122, 78);
            lblAnimalAgeDeportHistory.Name = "lblAnimalAgeDeportHistory";
            lblAnimalAgeDeportHistory.Size = new Size(86, 20);
            lblAnimalAgeDeportHistory.TabIndex = 8;
            lblAnimalAgeDeportHistory.Text = "Animal.Age";
            // 
            // lblAnimalDateDeportHistory
            // 
            lblAnimalDateDeportHistory.AutoSize = true;
            lblAnimalDateDeportHistory.Location = new Point(122, 52);
            lblAnimalDateDeportHistory.Name = "lblAnimalDateDeportHistory";
            lblAnimalDateDeportHistory.Size = new Size(91, 20);
            lblAnimalDateDeportHistory.TabIndex = 7;
            lblAnimalDateDeportHistory.Text = "Animal.Date";
            // 
            // lblAnimalNameDeportHistory
            // 
            lblAnimalNameDeportHistory.AutoSize = true;
            lblAnimalNameDeportHistory.Location = new Point(122, 23);
            lblAnimalNameDeportHistory.Name = "lblAnimalNameDeportHistory";
            lblAnimalNameDeportHistory.Size = new Size(99, 20);
            lblAnimalNameDeportHistory.TabIndex = 6;
            lblAnimalNameDeportHistory.Text = "Animal.Name";
            // 
            // lblAgeDeportHistory
            // 
            lblAgeDeportHistory.AutoSize = true;
            lblAgeDeportHistory.Location = new Point(6, 78);
            lblAgeDeportHistory.Name = "lblAgeDeportHistory";
            lblAgeDeportHistory.Size = new Size(36, 20);
            lblAgeDeportHistory.TabIndex = 4;
            lblAgeDeportHistory.Text = "Age";
            // 
            // lblDateDeportHistory
            // 
            lblDateDeportHistory.AutoSize = true;
            lblDateDeportHistory.Location = new Point(6, 52);
            lblDateDeportHistory.Name = "lblDateDeportHistory";
            lblDateDeportHistory.Size = new Size(101, 20);
            lblDateDeportHistory.TabIndex = 3;
            lblDateDeportHistory.Text = "Date Left Zoo";
            // 
            // lblNameDeportHistory
            // 
            lblNameDeportHistory.AutoSize = true;
            lblNameDeportHistory.Location = new Point(6, 23);
            lblNameDeportHistory.Name = "lblNameDeportHistory";
            lblNameDeportHistory.Size = new Size(49, 20);
            lblNameDeportHistory.TabIndex = 2;
            lblNameDeportHistory.Text = "Name";
            // 
            // dgvAnimalDeportHistory
            // 
            dgvAnimalDeportHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimalDeportHistory.Location = new Point(310, 216);
            dgvAnimalDeportHistory.Name = "dgvAnimalDeportHistory";
            dgvAnimalDeportHistory.RowHeadersWidth = 51;
            dgvAnimalDeportHistory.Size = new Size(452, 171);
            dgvAnimalDeportHistory.TabIndex = 9;
            dgvAnimalDeportHistory.CellClick += dgvAnimalDeportHistory_CellClick;
            // 
            // gbDeployHistory
            // 
            gbDeployHistory.Controls.Add(btnViewAnimalDeployHistory);
            gbDeployHistory.Controls.Add(lblAnimalLocationDeployHistory);
            gbDeployHistory.Controls.Add(lblLocationDeployHistory);
            gbDeployHistory.Controls.Add(lblAnimalAgeDeployHistory);
            gbDeployHistory.Controls.Add(lblAnimalDateDeployHistory);
            gbDeployHistory.Controls.Add(lblAnimalNameDeployHistory);
            gbDeployHistory.Controls.Add(lblAgeDeployHistory);
            gbDeployHistory.Controls.Add(lblDateDeployHistory);
            gbDeployHistory.Controls.Add(lblNameDeployHistory);
            gbDeployHistory.Location = new Point(6, 6);
            gbDeployHistory.Name = "gbDeployHistory";
            gbDeployHistory.Size = new Size(298, 204);
            gbDeployHistory.TabIndex = 8;
            gbDeployHistory.TabStop = false;
            gbDeployHistory.Text = "Deploy History";
            // 
            // btnViewAnimalDeployHistory
            // 
            btnViewAnimalDeployHistory.Location = new Point(127, 167);
            btnViewAnimalDeployHistory.Name = "btnViewAnimalDeployHistory";
            btnViewAnimalDeployHistory.Size = new Size(94, 29);
            btnViewAnimalDeployHistory.TabIndex = 15;
            btnViewAnimalDeployHistory.Text = "View more";
            btnViewAnimalDeployHistory.UseVisualStyleBackColor = true;
            // 
            // lblAnimalLocationDeployHistory
            // 
            lblAnimalLocationDeployHistory.AutoSize = true;
            lblAnimalLocationDeployHistory.Location = new Point(122, 132);
            lblAnimalLocationDeployHistory.Name = "lblAnimalLocationDeployHistory";
            lblAnimalLocationDeployHistory.Size = new Size(116, 20);
            lblAnimalLocationDeployHistory.TabIndex = 10;
            lblAnimalLocationDeployHistory.Text = "Animal.Location";
            // 
            // lblLocationDeployHistory
            // 
            lblLocationDeployHistory.AutoSize = true;
            lblLocationDeployHistory.Location = new Point(14, 132);
            lblLocationDeployHistory.Name = "lblLocationDeployHistory";
            lblLocationDeployHistory.Size = new Size(66, 20);
            lblLocationDeployHistory.TabIndex = 9;
            lblLocationDeployHistory.Text = "Location";
            // 
            // lblAnimalAgeDeployHistory
            // 
            lblAnimalAgeDeployHistory.AutoSize = true;
            lblAnimalAgeDeployHistory.Location = new Point(122, 98);
            lblAnimalAgeDeployHistory.Name = "lblAnimalAgeDeployHistory";
            lblAnimalAgeDeployHistory.Size = new Size(86, 20);
            lblAnimalAgeDeployHistory.TabIndex = 8;
            lblAnimalAgeDeployHistory.Text = "Animal.Age";
            // 
            // lblAnimalDateDeployHistory
            // 
            lblAnimalDateDeployHistory.AutoSize = true;
            lblAnimalDateDeployHistory.Location = new Point(122, 68);
            lblAnimalDateDeployHistory.Name = "lblAnimalDateDeployHistory";
            lblAnimalDateDeployHistory.Size = new Size(91, 20);
            lblAnimalDateDeployHistory.TabIndex = 7;
            lblAnimalDateDeployHistory.Text = "Animal.Date";
            // 
            // lblAnimalNameDeployHistory
            // 
            lblAnimalNameDeployHistory.AutoSize = true;
            lblAnimalNameDeployHistory.Location = new Point(122, 38);
            lblAnimalNameDeployHistory.Name = "lblAnimalNameDeployHistory";
            lblAnimalNameDeployHistory.Size = new Size(99, 20);
            lblAnimalNameDeployHistory.TabIndex = 6;
            lblAnimalNameDeployHistory.Text = "Animal.Name";
            // 
            // lblAgeDeployHistory
            // 
            lblAgeDeployHistory.AutoSize = true;
            lblAgeDeployHistory.Location = new Point(14, 98);
            lblAgeDeployHistory.Name = "lblAgeDeployHistory";
            lblAgeDeployHistory.Size = new Size(36, 20);
            lblAgeDeployHistory.TabIndex = 4;
            lblAgeDeployHistory.Text = "Age";
            // 
            // lblDateDeployHistory
            // 
            lblDateDeployHistory.AutoSize = true;
            lblDateDeployHistory.Location = new Point(14, 68);
            lblDateDeployHistory.Name = "lblDateDeployHistory";
            lblDateDeployHistory.Size = new Size(87, 20);
            lblDateDeployHistory.TabIndex = 3;
            lblDateDeployHistory.Text = "Date at zoo";
            // 
            // lblNameDeployHistory
            // 
            lblNameDeployHistory.AutoSize = true;
            lblNameDeployHistory.Location = new Point(14, 38);
            lblNameDeployHistory.Name = "lblNameDeployHistory";
            lblNameDeployHistory.Size = new Size(49, 20);
            lblNameDeployHistory.TabIndex = 2;
            lblNameDeployHistory.Text = "Name";
            // 
            // dgvAnimalDeployHistory
            // 
            dgvAnimalDeployHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimalDeployHistory.Location = new Point(310, 6);
            dgvAnimalDeployHistory.Name = "dgvAnimalDeployHistory";
            dgvAnimalDeployHistory.RowHeadersWidth = 51;
            dgvAnimalDeployHistory.Size = new Size(452, 204);
            dgvAnimalDeployHistory.TabIndex = 0;
            dgvAnimalDeployHistory.CellClick += dgvAnimalDeployHistory_CellClick;
            // 
            // TabAnimalStatus
            // 
            TabAnimalStatus.Controls.Add(groupBoxesPanel);
            TabAnimalStatus.Location = new Point(4, 29);
            TabAnimalStatus.Name = "TabAnimalStatus";
            TabAnimalStatus.Padding = new Padding(3);
            TabAnimalStatus.Size = new Size(768, 393);
            TabAnimalStatus.TabIndex = 5;
            TabAnimalStatus.Text = "Animal Status";
            TabAnimalStatus.UseVisualStyleBackColor = true;
            TabAnimalStatus.Click += TabAnimalStatus_Click;
            TabAnimalStatus.Enter += TabAnimalStatus_Enter_1;
            // 
            // groupBoxesPanel
            // 
            groupBoxesPanel.Location = new Point(6, 6);
            groupBoxesPanel.Name = "groupBoxesPanel";
            groupBoxesPanel.Size = new Size(756, 381);
            groupBoxesPanel.TabIndex = 0;
            // 
            // Animal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabViewerAnimal);
            Name = "Animal";
            Text = "Animal";
            TabViewerAnimal.ResumeLayout(false);
            tabAnimalManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            gbAnimalDeploy.ResumeLayout(false);
            gbAnimalDeploy.PerformLayout();
            gbZooLocation.ResumeLayout(false);
            gbZooLocation.PerformLayout();
            tabAnimalNew.ResumeLayout(false);
            gbNewAnimal.ResumeLayout(false);
            gbNewAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numWeightNew).EndInit();
            gbSpecies.ResumeLayout(false);
            gbSpecies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimal).EndInit();
            tabAnimalStaff.ResumeLayout(false);
            gbNotifficationView.ResumeLayout(false);
            gbNotifficationView.PerformLayout();
            gbAnimalView.ResumeLayout(false);
            gbAnimalView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimalView).EndInit();
            tabAnimalClinic.ResumeLayout(false);
            gbNotifficationCare.ResumeLayout(false);
            gbNotifficationCare.PerformLayout();
            gbAnimalCare.ResumeLayout(false);
            gbAnimalCare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimalCare).EndInit();
            tabAnimalHistory.ResumeLayout(false);
            gbAnimalDeportHistory.ResumeLayout(false);
            gbAnimalDeportHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimalDeportHistory).EndInit();
            gbDeployHistory.ResumeLayout(false);
            gbDeployHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimalDeployHistory).EndInit();
            TabAnimalStatus.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabViewerAnimal;
        private TabPage tabAnimalManager;
        private TabPage tabAnimalNew;
        private TextBox txtZooLocations;
        private Label lblLocations;
        private Button btnAddLocation;
        private TabPage tabAnimalStaff;
        private DataGridView dgvAnimal;
        private DataGridView dgvAnimalView;
        private TabPage tabAnimalClinic;
        private DataGridView dgvAnimalCare;
        private TabPage tabAnimalHistory;
        private DataGridView dgvAnimalDeployHistory;
        private GroupBox gbSpecies;
        private GroupBox gbNewAnimal;
        private Label lblSpeciesInput;
        private TextBox txtSpecies;
        private TextBox txtNameNew;
        private Label lblNameNew;
        private Button btnAddAnimalNew;
        private Label lblAgeNew;
        private Label lblSpeciesNew;
        private ComboBox cbSpeciesNew;
        private GroupBox gbAnimalDeploy;
        private Label lblName;
        private GroupBox gbZooLocation;
        private Label lblLocation;
        private Label lblAnimalNameDeploy;
        private ComboBox cbAnimalLocation;
        private Button btnDeploy;
        private GroupBox gbAnimalView;
        private Label lblUpdateView;
        private Label lblAnimalLocationView;
        private Label lblAnimalNameView;
        private Label lblNameView;
        private GroupBox gbNotifficationView;
        private Button btnUpdateAnimalView;
        private TextBox txtTaskView;
        private Label lblTaskView;
        private TextBox txtNotifficationView;
        private ComboBox cbNotifficationView;
        private RadioButton radbtnNotifficationView;
        private GroupBox gbAnimalCare;
        private Button btnUpdateAnimalCare;
        private TextBox txtRemedyCare;
        private Label lblAnimalNameCare;
        private Label lblNameCare;
        private GroupBox gbNotifficationCare;
        private TextBox txtNotifficationCare;
        private DataGridView dgvAnimalDeportHistory;
        private GroupBox gbDeployHistory;
        private Button btnViewAnimalDeployHistory;
        private Label lblAnimalLocationDeployHistory;
        private Label lblLocationDeployHistory;
        private Label lblAnimalAgeDeployHistory;
        private Label lblAnimalNameDeployHistory;
        private Label lblAgeDeployHistory;
        private Label lblNameDeployHistory;
        private Button btnDeport;
        private GroupBox gbAnimalDeportHistory;
        private Button btnviewAnimalDeportHistory;
        private Label lblAnimalLocationDeportHistory;
        private Label lblLocationDeportHistory;
        private Label lblAnimalAgeDeportHistory;
        private Label lblAnimalNameDeportHistory;
        private Label lblAgeDeportHistory;
        private Label lblNameDeportHistory;
        private Label lblremedyCare;
        private DateTimePicker dtpAgeNew;
        private TextBox txtColorNew;
        private Label lblColor;
        private Label lblWeight;
        private Button btnAddSpecies;
        private NumericUpDown numWeightNew;
        private Label lblLocationView;
        private Label lblAnimalDateDeportHistory;
        private Label lblDateDeportHistory;
        private Label lblAnimalDateDeployHistory;
        private Label lblDateDeployHistory;
        private Label lblAnimalLocationCare;
        private Label lblLocationCare;
        private RadioButton radbtnNotifficationNoView;
        private TabPage TabAnimalStatus;
        private Panel groupBoxesPanel;
        private DataGridView dgvAnimals;
    }
}