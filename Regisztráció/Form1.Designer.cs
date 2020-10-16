namespace Regisztráció
{
    partial class Form1
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
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.rbtnGenderMale = new System.Windows.Forms.RadioButton();
            this.rbtnGenerFemale = new System.Windows.Forms.RadioButton();
            this.lboxHobby = new System.Windows.Forms.ListBox();
            this.lbHobby = new System.Windows.Forms.Label();
            this.lbNewHobby = new System.Windows.Forms.Label();
            this.tbHobby = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(33, 17);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Név";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(52, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(153, 22);
            this.tbName.TabIndex = 1;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(105, 41);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 22);
            this.tbDate.TabIndex = 3;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(13, 41);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(86, 17);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = " Szül. dátum";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(12, 67);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(37, 17);
            this.lbGender.TabIndex = 4;
            this.lbGender.Text = "Nem";
            // 
            // rbtnGenderMale
            // 
            this.rbtnGenderMale.AutoSize = true;
            this.rbtnGenderMale.Location = new System.Drawing.Point(56, 67);
            this.rbtnGenderMale.Name = "rbtnGenderMale";
            this.rbtnGenderMale.Size = new System.Drawing.Size(61, 21);
            this.rbtnGenderMale.TabIndex = 5;
            this.rbtnGenderMale.TabStop = true;
            this.rbtnGenderMale.Text = "Féfrfi";
            this.rbtnGenderMale.UseVisualStyleBackColor = true;
            // 
            // rbtnGenerFemale
            // 
            this.rbtnGenerFemale.AutoSize = true;
            this.rbtnGenerFemale.Location = new System.Drawing.Point(123, 69);
            this.rbtnGenerFemale.Name = "rbtnGenerFemale";
            this.rbtnGenerFemale.Size = new System.Drawing.Size(47, 21);
            this.rbtnGenerFemale.TabIndex = 6;
            this.rbtnGenerFemale.TabStop = true;
            this.rbtnGenerFemale.Text = "Nő";
            this.rbtnGenerFemale.UseVisualStyleBackColor = true;
            // 
            // lboxHobby
            // 
            this.lboxHobby.FormattingEnabled = true;
            this.lboxHobby.ItemHeight = 16;
            this.lboxHobby.Location = new System.Drawing.Point(253, 29);
            this.lboxHobby.Name = "lboxHobby";
            this.lboxHobby.Size = new System.Drawing.Size(190, 260);
            this.lboxHobby.TabIndex = 7;
            // 
            // lbHobby
            // 
            this.lbHobby.AutoSize = true;
            this.lbHobby.Location = new System.Drawing.Point(250, 9);
            this.lbHobby.Name = "lbHobby";
            this.lbHobby.Size = new System.Drawing.Size(102, 17);
            this.lbHobby.TabIndex = 8;
            this.lbHobby.Text = "Kedvenc hobbi";
            // 
            // lbNewHobby
            // 
            this.lbNewHobby.AutoSize = true;
            this.lbNewHobby.Location = new System.Drawing.Point(250, 298);
            this.lbNewHobby.Name = "lbNewHobby";
            this.lbNewHobby.Size = new System.Drawing.Size(60, 17);
            this.lbNewHobby.TabIndex = 9;
            this.lbNewHobby.Text = "Új hobbi";
            // 
            // tbHobby
            // 
            this.tbHobby.Location = new System.Drawing.Point(316, 295);
            this.tbHobby.Name = "tbHobby";
            this.tbHobby.Size = new System.Drawing.Size(127, 22);
            this.tbHobby.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(368, 323);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Hozzáad";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(368, 415);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Betöltés";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(287, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbHobby);
            this.Controls.Add(this.lbNewHobby);
            this.Controls.Add(this.lbHobby);
            this.Controls.Add(this.lboxHobby);
            this.Controls.Add(this.rbtnGenerFemale);
            this.Controls.Add(this.rbtnGenderMale);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.RadioButton rbtnGenderMale;
        private System.Windows.Forms.RadioButton rbtnGenerFemale;
        private System.Windows.Forms.ListBox lboxHobby;
        private System.Windows.Forms.Label lbHobby;
        private System.Windows.Forms.Label lbNewHobby;
        private System.Windows.Forms.TextBox tbHobby;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
    }
}

