namespace Assign_2_BS_19011519_006
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gbFindById = new System.Windows.Forms.GroupBox();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.txtGetById = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone_Number = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblCurrStudent = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnBrowseImg = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txt_Phone_Number = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.gbFindById.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNew,
            this.toolStripSeparator1,
            this.tsSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1023, 25);
            this.toolStrip1.TabIndex = 44;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // gbFindById
            // 
            this.gbFindById.AutoSize = true;
            this.gbFindById.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gbFindById.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbFindById.Controls.Add(this.pbSearch);
            this.gbFindById.Controls.Add(this.btnSearchById);
            this.gbFindById.Controls.Add(this.txtGetById);
            this.gbFindById.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFindById.Location = new System.Drawing.Point(802, 83);
            this.gbFindById.Name = "gbFindById";
            this.gbFindById.Size = new System.Drawing.Size(188, 222);
            this.gbFindById.TabIndex = 42;
            this.gbFindById.TabStop = false;
            this.gbFindById.Text = "Find by ID";
            // 
            // btnSearchById
            // 
            this.btnSearchById.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnSearchById.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchById.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchById.Location = new System.Drawing.Point(60, 128);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(75, 23);
            this.btnSearchById.TabIndex = 16;
            this.btnSearchById.Text = "Search";
            this.btnSearchById.UseVisualStyleBackColor = false;
            this.btnSearchById.Click += new System.EventHandler(this.btnSearchById_Click);
            // 
            // txtGetById
            // 
            this.txtGetById.Location = new System.Drawing.Point(6, 101);
            this.txtGetById.Name = "txtGetById";
            this.txtGetById.Size = new System.Drawing.Size(170, 21);
            this.txtGetById.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(467, 369);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 43;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(187, 83);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(85, 16);
            this.lblStudentId.TabIndex = 36;
            this.lblStudentId.Text = "Student ID";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(187, 289);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 16);
            this.lblGender.TabIndex = 20;
            this.lblGender.Text = "Gender";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(187, 331);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 16);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Address";
            // 
            // lblPhone_Number
            // 
            this.lblPhone_Number.AutoSize = true;
            this.lblPhone_Number.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone_Number.Location = new System.Drawing.Point(187, 247);
            this.lblPhone_Number.Name = "lblPhone_Number";
            this.lblPhone_Number.Size = new System.Drawing.Size(116, 16);
            this.lblPhone_Number.TabIndex = 23;
            this.lblPhone_Number.Text = "Phone Number";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(187, 205);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(39, 16);
            this.lblDOB.TabIndex = 24;
            this.lblDOB.Text = "DOB";
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentEmail.Location = new System.Drawing.Point(187, 163);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(110, 16);
            this.lblStudentEmail.TabIndex = 25;
            this.lblStudentEmail.Text = "Student Email";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(187, 121);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(109, 16);
            this.lblStudentName.TabIndex = 26;
            this.lblStudentName.Text = "Student Name";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(396, 289);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(78, 20);
            this.rbFemale.TabIndex = 33;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(335, 287);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(60, 20);
            this.rbMale.TabIndex = 32;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(335, 199);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpDOB.TabIndex = 29;
            // 
            // lblCurrStudent
            // 
            this.lblCurrStudent.AutoSize = true;
            this.lblCurrStudent.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrStudent.Location = new System.Drawing.Point(606, 369);
            this.lblCurrStudent.Name = "lblCurrStudent";
            this.lblCurrStudent.Size = new System.Drawing.Size(72, 16);
            this.lblCurrStudent.TabIndex = 27;
            this.lblCurrStudent.Text = "Student: ";
            this.lblCurrStudent.Click += new System.EventHandler(this.lblCurrStudent_Click);
            // 
            // txtStudentId
            // 
            this.txtStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.Location = new System.Drawing.Point(335, 80);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(200, 22);
            this.txtStudentId.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(368, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(328, 397);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 40;
            this.btnPrev.Text = "<- Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentEmail.Location = new System.Drawing.Point(335, 160);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(200, 22);
            this.txtStudentEmail.TabIndex = 28;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(335, 118);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(200, 22);
            this.txtStudentName.TabIndex = 18;
            // 
            // btnBrowseImg
            // 
            this.btnBrowseImg.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImg.Location = new System.Drawing.Point(649, 305);
            this.btnBrowseImg.Name = "btnBrowseImg";
            this.btnBrowseImg.Size = new System.Drawing.Size(109, 23);
            this.btnBrowseImg.TabIndex = 37;
            this.btnBrowseImg.Text = "Browse Image";
            this.btnBrowseImg.UseVisualStyleBackColor = true;
            this.btnBrowseImg.Click += new System.EventHandler(this.btnBrowseImg_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(409, 397);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 41;
            this.btnNext.Text = "Next ->";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(269, 369);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 39;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txt_Phone_Number
            // 
            this.txt_Phone_Number.Location = new System.Drawing.Point(335, 242);
            this.txt_Phone_Number.Name = "txt_Phone_Number";
            this.txt_Phone_Number.Size = new System.Drawing.Size(200, 20);
            this.txt_Phone_Number.TabIndex = 45;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(335, 331);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Registration Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tsNew
            // 
            this.tsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsNew.Image = ((System.Drawing.Image)(resources.GetObject("tsNew.Image")));
            this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(35, 22);
            this.tsNew.Text = "New";
            // 
            // tsSave
            // 
            this.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSave.Image = ((System.Drawing.Image)(resources.GetObject("tsSave.Image")));
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(35, 22);
            this.tsSave.Text = "Save";
            // 
            // pbSearch
            // 
            this.pbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSearch.Image = global::Assign_2_BS_19011519_006.Properties.Resources.search;
            this.pbSearch.InitialImage = null;
            this.pbSearch.Location = new System.Drawing.Point(70, 38);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(50, 46);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 48;
            this.pbSearch.TabStop = false;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Image = global::Assign_2_BS_19011519_006.Properties.Resources.user;
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(609, 80);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(165, 219);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 31;
            this.pbImage.TabStop = false;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1023, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txt_Phone_Number);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbFindById);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone_Number);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblStudentEmail);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblCurrStudent);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.btnBrowseImg);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnNew);
            this.Name = "StudentForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentForm_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbFindById.ResumeLayout(false);
            this.gbFindById.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.GroupBox gbFindById;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.TextBox txtGetById;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone_Number;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblCurrStudent;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrev;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnBrowseImg;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txt_Phone_Number;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSearch;
    }
}

