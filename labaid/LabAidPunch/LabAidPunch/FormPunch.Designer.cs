namespace LabAidPunch
{
    partial class FormPunch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPunch));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonIn = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.comboLabs = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelhomeP = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.panelSuccess = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punchedIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punchedOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.labelAdminSuccess = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAPass = new System.Windows.Forms.TextBox();
            this.textBoxALogin = new System.Windows.Forms.TextBox();
            this.labelAdmPass = new System.Windows.Forms.Label();
            this.labelAdmUser = new System.Windows.Forms.Label();
            this.labeladminTitle = new System.Windows.Forms.Label();
            this.panelATimeSheet = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.studID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clockIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clockOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelReport = new System.Windows.Forms.Label();
            this.textBoxIDZ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelSuccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAdmin.SuspendLayout();
            this.panelATimeSheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(350, 71);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxID.MaxLength = 6;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(304, 46);
            this.textBoxID.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(350, 143);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(304, 46);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonIn
            // 
            this.buttonIn.BackColor = System.Drawing.Color.LightGreen;
            this.buttonIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIn.Location = new System.Drawing.Point(310, 300);
            this.buttonIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(182, 83);
            this.buttonIn.TabIndex = 4;
            this.buttonIn.Text = "Clock In";
            this.buttonIn.UseVisualStyleBackColor = false;
            this.buttonIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.BackColor = System.Drawing.Color.IndianRed;
            this.buttonOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOut.Location = new System.Drawing.Point(538, 300);
            this.buttonOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(182, 83);
            this.buttonOut.TabIndex = 5;
            this.buttonOut.Text = "Clock Out";
            this.buttonOut.UseVisualStyleBackColor = false;
            this.buttonOut.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelSuccess
            // 
            this.labelSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuccess.Location = new System.Drawing.Point(285, 388);
            this.labelSuccess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(448, 189);
            this.labelSuccess.TabIndex = 8;
            this.labelSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboLabs
            // 
            this.comboLabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLabs.FormattingEnabled = true;
            this.comboLabs.Items.AddRange(new object[] {
            "BU205",
            "BU207",
            "BU210",
            "CC101"});
            this.comboLabs.Location = new System.Drawing.Point(350, 208);
            this.comboLabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboLabs.Name = "comboLabs";
            this.comboLabs.Size = new System.Drawing.Size(302, 55);
            this.comboLabs.TabIndex = 9;
            this.comboLabs.SelectedIndexChanged += new System.EventHandler(this.comboLabs_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 47);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lab Number";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelLogin.Controls.Add(this.labelSuccess);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.buttonOut);
            this.panelLogin.Controls.Add(this.textBoxID);
            this.panelLogin.Controls.Add(this.comboLabs);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.buttonIn);
            this.panelLogin.Location = new System.Drawing.Point(376, 9);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(764, 745);
            this.panelLogin.TabIndex = 12;
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.groupBox1);
            this.panelHome.Controls.Add(this.pictureBox3);
            this.panelHome.Controls.Add(this.label6);
            this.panelHome.Controls.Add(this.labelHome);
            this.panelHome.Location = new System.Drawing.Point(374, 6);
            this.panelHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(764, 745);
            this.panelHome.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Controls.Add(this.textBoxIDZ);
            this.groupBox1.Controls.Add(this.labelhomeP);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(98, 195);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(598, 286);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // labelhomeP
            // 
            this.labelhomeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhomeP.Location = new System.Drawing.Point(3, 45);
            this.labelhomeP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelhomeP.Name = "labelhomeP";
            this.labelhomeP.Size = new System.Drawing.Size(586, 206);
            this.labelhomeP.TabIndex = 2;
            this.labelhomeP.Text = "Please swipe your ID for your punch! If the punch is unsuccessful please use the " +
    "menu on the left to login!";
            this.labelhomeP.Click += new System.EventHandler(this.labelhomeP_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(513, 551);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(246, 189);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 47);
            this.label6.TabIndex = 1;
            this.label6.Text = "Welcome!";
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.Location = new System.Drawing.Point(74, 18);
            this.labelHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(615, 61);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "Lab Aid Clocking System";
            // 
            // panelSuccess
            // 
            this.panelSuccess.Controls.Add(this.pictureBox2);
            this.panelSuccess.Controls.Add(this.label5);
            this.panelSuccess.Controls.Add(this.dataGridView1);
            this.panelSuccess.Controls.Add(this.label4);
            this.panelSuccess.Location = new System.Drawing.Point(375, 8);
            this.panelSuccess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSuccess.Name = "panelSuccess";
            this.panelSuccess.Size = new System.Drawing.Size(764, 745);
            this.panelSuccess.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(524, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 47);
            this.label5.TabIndex = 2;
            this.label5.Text = "Time log history";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.Lab,
            this.punchedIn,
            this.punchedOut,
            this.date});
            this.dataGridView1.Location = new System.Drawing.Point(0, 200);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 540);
            this.dataGridView1.TabIndex = 1;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "ID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // Lab
            // 
            this.Lab.HeaderText = "Lab";
            this.Lab.Name = "Lab";
            this.Lab.ReadOnly = true;
            // 
            // punchedIn
            // 
            this.punchedIn.HeaderText = "Punched In";
            this.punchedIn.Name = "punchedIn";
            this.punchedIn.ReadOnly = true;
            // 
            // punchedOut
            // 
            this.punchedOut.HeaderText = "Punched Out";
            this.punchedOut.Name = "punchedOut";
            this.punchedOut.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 47);
            this.label4.TabIndex = 0;
            this.label4.Text = "Successful Punch!";
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Navy;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(0, 115);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(352, 206);
            this.HomeButton.TabIndex = 13;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // buttonStudent
            // 
            this.buttonStudent.BackColor = System.Drawing.Color.Navy;
            this.buttonStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudent.ForeColor = System.Drawing.Color.White;
            this.buttonStudent.Location = new System.Drawing.Point(0, 331);
            this.buttonStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(352, 206);
            this.buttonStudent.TabIndex = 14;
            this.buttonStudent.Text = "Student Login";
            this.buttonStudent.UseVisualStyleBackColor = false;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.Navy;
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonAdmin.Location = new System.Drawing.Point(0, 546);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(352, 206);
            this.buttonAdmin.TabIndex = 15;
            this.buttonAdmin.Text = "Admin Login";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.SteelBlue;
            this.panelAdmin.Controls.Add(this.labelAdminSuccess);
            this.panelAdmin.Controls.Add(this.button1);
            this.panelAdmin.Controls.Add(this.textBoxAPass);
            this.panelAdmin.Controls.Add(this.textBoxALogin);
            this.panelAdmin.Controls.Add(this.labelAdmPass);
            this.panelAdmin.Controls.Add(this.labelAdmUser);
            this.panelAdmin.Controls.Add(this.labeladminTitle);
            this.panelAdmin.Location = new System.Drawing.Point(378, 3);
            this.panelAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(764, 743);
            this.panelAdmin.TabIndex = 16;
            this.panelAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelAdminSuccess
            // 
            this.labelAdminSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminSuccess.Location = new System.Drawing.Point(64, 498);
            this.labelAdminSuccess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdminSuccess.Name = "labelAdminSuccess";
            this.labelAdminSuccess.Size = new System.Drawing.Size(618, 48);
            this.labelAdminSuccess.TabIndex = 6;
            this.labelAdminSuccess.Click += new System.EventHandler(this.labelAdminSuccess_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(276, 365);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 95);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxAPass
            // 
            this.textBoxAPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAPass.Location = new System.Drawing.Point(318, 257);
            this.textBoxAPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAPass.Name = "textBoxAPass";
            this.textBoxAPass.PasswordChar = '*';
            this.textBoxAPass.Size = new System.Drawing.Size(254, 48);
            this.textBoxAPass.TabIndex = 4;
            // 
            // textBoxALogin
            // 
            this.textBoxALogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxALogin.Location = new System.Drawing.Point(318, 186);
            this.textBoxALogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxALogin.Name = "textBoxALogin";
            this.textBoxALogin.Size = new System.Drawing.Size(254, 48);
            this.textBoxALogin.TabIndex = 3;
            // 
            // labelAdmPass
            // 
            this.labelAdmPass.AutoSize = true;
            this.labelAdmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmPass.Location = new System.Drawing.Point(56, 257);
            this.labelAdmPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdmPass.Name = "labelAdmPass";
            this.labelAdmPass.Size = new System.Drawing.Size(224, 47);
            this.labelAdmPass.TabIndex = 2;
            this.labelAdmPass.Text = "Password :";
            // 
            // labelAdmUser
            // 
            this.labelAdmUser.AutoSize = true;
            this.labelAdmUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmUser.Location = new System.Drawing.Point(51, 194);
            this.labelAdmUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdmUser.Name = "labelAdmUser";
            this.labelAdmUser.Size = new System.Drawing.Size(233, 47);
            this.labelAdmUser.TabIndex = 1;
            this.labelAdmUser.Text = "Username :";
            // 
            // labeladminTitle
            // 
            this.labeladminTitle.AutoSize = true;
            this.labeladminTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.labeladminTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeladminTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladminTitle.Location = new System.Drawing.Point(136, 37);
            this.labeladminTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeladminTitle.Name = "labeladminTitle";
            this.labeladminTitle.Size = new System.Drawing.Size(486, 63);
            this.labeladminTitle.TabIndex = 0;
            this.labeladminTitle.Text = "Administrator Login";
            // 
            // panelATimeSheet
            // 
            this.panelATimeSheet.BackColor = System.Drawing.Color.SteelBlue;
            this.panelATimeSheet.Controls.Add(this.dataGridView2);
            this.panelATimeSheet.Controls.Add(this.labelReport);
            this.panelATimeSheet.Location = new System.Drawing.Point(380, 3);
            this.panelATimeSheet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelATimeSheet.Name = "panelATimeSheet";
            this.panelATimeSheet.Size = new System.Drawing.Size(765, 737);
            this.panelATimeSheet.TabIndex = 17;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studID,
            this.DateAdmin,
            this.clockIn,
            this.clockOut,
            this.labAdmin});
            this.dataGridView2.Location = new System.Drawing.Point(4, 106);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(771, 625);
            this.dataGridView2.TabIndex = 1;
            // 
            // studID
            // 
            this.studID.HeaderText = "Student ID";
            this.studID.Name = "studID";
            this.studID.ReadOnly = true;
            // 
            // DateAdmin
            // 
            this.DateAdmin.HeaderText = "Date";
            this.DateAdmin.Name = "DateAdmin";
            this.DateAdmin.ReadOnly = true;
            // 
            // clockIn
            // 
            this.clockIn.HeaderText = "Clocked In";
            this.clockIn.Name = "clockIn";
            this.clockIn.ReadOnly = true;
            // 
            // clockOut
            // 
            this.clockOut.HeaderText = "Clocked Out";
            this.clockOut.Name = "clockOut";
            this.clockOut.ReadOnly = true;
            // 
            // labAdmin
            // 
            this.labAdmin.HeaderText = "Lab #";
            this.labAdmin.Name = "labAdmin";
            this.labAdmin.ReadOnly = true;
            // 
            // labelReport
            // 
            this.labelReport.AutoSize = true;
            this.labelReport.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReport.Location = new System.Drawing.Point(74, 20);
            this.labelReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(638, 61);
            this.labelReport.TabIndex = 0;
            this.labelReport.Text = "Lab Aid Timesheet Report";
            // 
            // textBoxIDZ
            // 
            this.textBoxIDZ.Location = new System.Drawing.Point(166, 196);
            this.textBoxIDZ.Name = "textBoxIDZ";
            this.textBoxIDZ.Size = new System.Drawing.Size(254, 26);
            this.textBoxIDZ.TabIndex = 5;
            this.textBoxIDZ.TextChanged += new System.EventHandler(this.textBoxIDZ_TextChanged);
            // 
            // FormPunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1146, 751);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.buttonStudent);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelSuccess);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panelATimeSheet);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPunch";
            this.Text = "Lab Aid Clocking System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelSuccess.ResumeLayout(false);
            this.panelSuccess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.panelATimeSheet.ResumeLayout(false);
            this.panelATimeSheet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.ComboBox comboLabs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelSuccess;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lab;
        private System.Windows.Forms.DataGridViewTextBoxColumn punchedIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn punchedOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelhomeP;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label labeladminTitle;
        private System.Windows.Forms.Label labelAdminSuccess;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAPass;
        private System.Windows.Forms.TextBox textBoxALogin;
        private System.Windows.Forms.Label labelAdmPass;
        private System.Windows.Forms.Label labelAdmUser;
        private System.Windows.Forms.Panel panelATimeSheet;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn studID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clockIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clockOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn labAdmin;
        private System.Windows.Forms.Label labelReport;
        private System.Windows.Forms.TextBox textBoxIDZ;
    }
}

