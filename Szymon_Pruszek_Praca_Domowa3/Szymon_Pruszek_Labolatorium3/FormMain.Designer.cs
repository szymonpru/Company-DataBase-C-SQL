namespace Szymon_Pruszek_Labolatorium3
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddPersonEdit = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDeletePerson = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIDtoDelete = new System.Windows.Forms.TextBox();
            this.comboBoxEducation = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSerchName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSortByEmployment = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxAmountofCounty = new System.Windows.Forms.TextBox();
            this.buttonShowCounty = new System.Windows.Forms.Button();
            this.pictureBoxMonster = new System.Windows.Forms.PictureBox();
            this.pictureBoxHorizontal = new System.Windows.Forms.PictureBox();
            this.pictureBoxVertical = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonShowAvarageAge = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxAddMoney = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.buttonAddMoney = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.Location = new System.Drawing.Point(12, 21);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(653, 390);
            this.dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz tabelę do wyświetlenia";
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(17, 477);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTables.TabIndex = 2;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(161, 466);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(134, 44);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "Wyświetl";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(694, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dodaj osobę/edytuj";
            // 
            // buttonAddPersonEdit
            // 
            this.buttonAddPersonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddPersonEdit.Location = new System.Drawing.Point(741, 269);
            this.buttonAddPersonEdit.Name = "buttonAddPersonEdit";
            this.buttonAddPersonEdit.Size = new System.Drawing.Size(179, 51);
            this.buttonAddPersonEdit.TabIndex = 5;
            this.buttonAddPersonEdit.Text = "Dodaj osobę/edytuj";
            this.buttonAddPersonEdit.UseVisualStyleBackColor = true;
            this.buttonAddPersonEdit.Click += new System.EventHandler(this.buttonAddPersonEdit_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(787, 116);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(787, 150);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxSurname.TabIndex = 7;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(787, 192);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 22);
            this.textBoxAge.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Imie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nazwisko";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Wiek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(681, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Wykształcenie";
            // 
            // buttonDeletePerson
            // 
            this.buttonDeletePerson.Location = new System.Drawing.Point(768, 378);
            this.buttonDeletePerson.Name = "buttonDeletePerson";
            this.buttonDeletePerson.Size = new System.Drawing.Size(139, 33);
            this.buttonDeletePerson.TabIndex = 14;
            this.buttonDeletePerson.Text = "Usuń osobę";
            this.buttonDeletePerson.UseVisualStyleBackColor = true;
            this.buttonDeletePerson.Click += new System.EventHandler(this.buttonDeletePerson_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(763, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Usuń osobę";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(682, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID";
            // 
            // textBoxIDtoDelete
            // 
            this.textBoxIDtoDelete.Location = new System.Drawing.Point(715, 383);
            this.textBoxIDtoDelete.Name = "textBoxIDtoDelete";
            this.textBoxIDtoDelete.Size = new System.Drawing.Size(34, 22);
            this.textBoxIDtoDelete.TabIndex = 17;
            // 
            // comboBoxEducation
            // 
            this.comboBoxEducation.FormattingEnabled = true;
            this.comboBoxEducation.Location = new System.Drawing.Point(787, 227);
            this.comboBoxEducation.Name = "comboBoxEducation";
            this.comboBoxEducation.Size = new System.Drawing.Size(100, 24);
            this.comboBoxEducation.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(681, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(787, 80);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(731, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "ID Zostaw puste przy dodawaniu";
            // 
            // textBoxSerchName
            // 
            this.textBoxSerchName.Location = new System.Drawing.Point(394, 477);
            this.textBoxSerchName.Name = "textBoxSerchName";
            this.textBoxSerchName.Size = new System.Drawing.Size(207, 22);
            this.textBoxSerchName.TabIndex = 22;
            this.textBoxSerchName.TextChanged += new System.EventHandler(this.textBoxSerchName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(363, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(281, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Szukaj osby po imieniu lub nazwisku";
            // 
            // buttonSortByEmployment
            // 
            this.buttonSortByEmployment.Location = new System.Drawing.Point(17, 563);
            this.buttonSortByEmployment.Name = "buttonSortByEmployment";
            this.buttonSortByEmployment.Size = new System.Drawing.Size(278, 68);
            this.buttonSortByEmployment.TabIndex = 24;
            this.buttonSortByEmployment.Text = "Sortuj według daty zatrudnienia";
            this.buttonSortByEmployment.UseVisualStyleBackColor = true;
            this.buttonSortByEmployment.Click += new System.EventHandler(this.buttonSortByEmployment_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(391, 563);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Wyświetl";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(536, 563);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "powiatów";
            // 
            // textBoxAmountofCounty
            // 
            this.textBoxAmountofCounty.Location = new System.Drawing.Point(459, 560);
            this.textBoxAmountofCounty.Name = "textBoxAmountofCounty";
            this.textBoxAmountofCounty.Size = new System.Drawing.Size(71, 22);
            this.textBoxAmountofCounty.TabIndex = 27;
            // 
            // buttonShowCounty
            // 
            this.buttonShowCounty.Location = new System.Drawing.Point(394, 596);
            this.buttonShowCounty.Name = "buttonShowCounty";
            this.buttonShowCounty.Size = new System.Drawing.Size(207, 30);
            this.buttonShowCounty.TabIndex = 28;
            this.buttonShowCounty.Text = "Wyświetl powiaty";
            this.buttonShowCounty.UseVisualStyleBackColor = true;
            this.buttonShowCounty.Click += new System.EventHandler(this.buttonShowCounty_Click);
            // 
            // pictureBoxMonster
            // 
            this.pictureBoxMonster.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMonster.ErrorImage")));
            this.pictureBoxMonster.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMonster.Image")));
            this.pictureBoxMonster.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMonster.InitialImage")));
            this.pictureBoxMonster.Location = new System.Drawing.Point(12, 21);
            this.pictureBoxMonster.Name = "pictureBoxMonster";
            this.pictureBoxMonster.Size = new System.Drawing.Size(653, 390);
            this.pictureBoxMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMonster.TabIndex = 29;
            this.pictureBoxMonster.TabStop = false;
            // 
            // pictureBoxHorizontal
            // 
            this.pictureBoxHorizontal.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHorizontal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHorizontal.Image")));
            this.pictureBoxHorizontal.Location = new System.Drawing.Point(12, 516);
            this.pictureBoxHorizontal.Name = "pictureBoxHorizontal";
            this.pictureBoxHorizontal.Size = new System.Drawing.Size(278, 40);
            this.pictureBoxHorizontal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHorizontal.TabIndex = 30;
            this.pictureBoxHorizontal.TabStop = false;
            // 
            // pictureBoxVertical
            // 
            this.pictureBoxVertical.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxVertical.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVertical.Image")));
            this.pictureBoxVertical.Location = new System.Drawing.Point(315, 436);
            this.pictureBoxVertical.Name = "pictureBoxVertical";
            this.pictureBoxVertical.Size = new System.Drawing.Size(42, 194);
            this.pictureBoxVertical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVertical.TabIndex = 31;
            this.pictureBoxVertical.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(367, 514);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(715, 417);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // buttonShowAvarageAge
            // 
            this.buttonShowAvarageAge.Location = new System.Drawing.Point(734, 477);
            this.buttonShowAvarageAge.Name = "buttonShowAvarageAge";
            this.buttonShowAvarageAge.Size = new System.Drawing.Size(208, 30);
            this.buttonShowAvarageAge.TabIndex = 34;
            this.buttonShowAvarageAge.Text = "Pokaż średni wiek Osób";
            this.buttonShowAvarageAge.UseVisualStyleBackColor = true;
            this.buttonShowAvarageAge.Click += new System.EventHandler(this.buttonShowAvarageAge_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(650, 437);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 194);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(730, 563);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(225, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "Zwiększ wszystkim pensję o:";
            // 
            // textBoxAddMoney
            // 
            this.textBoxAddMoney.Location = new System.Drawing.Point(734, 604);
            this.textBoxAddMoney.Name = "textBoxAddMoney";
            this.textBoxAddMoney.Size = new System.Drawing.Size(88, 22);
            this.textBoxAddMoney.TabIndex = 37;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(715, 517);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(246, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // buttonAddMoney
            // 
            this.buttonAddMoney.Location = new System.Drawing.Point(845, 594);
            this.buttonAddMoney.Name = "buttonAddMoney";
            this.buttonAddMoney.Size = new System.Drawing.Size(110, 42);
            this.buttonAddMoney.TabIndex = 39;
            this.buttonAddMoney.Text = "Zwiększ pensje";
            this.buttonAddMoney.UseVisualStyleBackColor = true;
            this.buttonAddMoney.Click += new System.EventHandler(this.buttonAddMoney_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(988, 649);
            this.Controls.Add(this.buttonAddMoney);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textBoxAddMoney);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonShowAvarageAge);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxVertical);
            this.Controls.Add(this.pictureBoxHorizontal);
            this.Controls.Add(this.pictureBoxMonster);
            this.Controls.Add(this.buttonShowCounty);
            this.Controls.Add(this.textBoxAmountofCounty);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonSortByEmployment);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxSerchName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxEducation);
            this.Controls.Add(this.textBoxIDtoDelete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonDeletePerson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAddPersonEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = " Szymon Pruszek COMPANY DataBase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddPersonEdit;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDeletePerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxIDtoDelete;
        private System.Windows.Forms.ComboBox comboBoxEducation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSerchName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSortByEmployment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxAmountofCounty;
        private System.Windows.Forms.Button buttonShowCounty;
        private System.Windows.Forms.PictureBox pictureBoxMonster;
        private System.Windows.Forms.PictureBox pictureBoxHorizontal;
        private System.Windows.Forms.PictureBox pictureBoxVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonShowAvarageAge;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxAddMoney;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button buttonAddMoney;
    }
}

