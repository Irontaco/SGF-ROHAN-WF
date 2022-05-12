namespace SGF_ROHAN_WF
{
    partial class CreateClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Names = new System.Windows.Forms.TextBox();
            this.label_Surnames = new System.Windows.Forms.Label();
            this.textBox_Surnames = new System.Windows.Forms.TextBox();
            this.label_FullName = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.textBox_RegisteredBusiness = new System.Windows.Forms.TextBox();
            this.label_RegisteredBusiness = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_SaveClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // textBox_Names
            // 
            this.textBox_Names.Location = new System.Drawing.Point(12, 81);
            this.textBox_Names.MaxLength = 40;
            this.textBox_Names.Name = "textBox_Names";
            this.textBox_Names.Size = new System.Drawing.Size(270, 20);
            this.textBox_Names.TabIndex = 1;
            this.textBox_Names.TextChanged += new System.EventHandler(this.textBox_Names_TextChanged);
            // 
            // label_Surnames
            // 
            this.label_Surnames.AutoSize = true;
            this.label_Surnames.Location = new System.Drawing.Point(12, 104);
            this.label_Surnames.Name = "label_Surnames";
            this.label_Surnames.Size = new System.Drawing.Size(49, 13);
            this.label_Surnames.TabIndex = 2;
            this.label_Surnames.Text = "Apellidos";
            // 
            // textBox_Surnames
            // 
            this.textBox_Surnames.Location = new System.Drawing.Point(12, 120);
            this.textBox_Surnames.MaxLength = 40;
            this.textBox_Surnames.Name = "textBox_Surnames";
            this.textBox_Surnames.Size = new System.Drawing.Size(270, 20);
            this.textBox_Surnames.TabIndex = 3;
            // 
            // label_FullName
            // 
            this.label_FullName.AutoSize = true;
            this.label_FullName.Location = new System.Drawing.Point(12, 9);
            this.label_FullName.Name = "label_FullName";
            this.label_FullName.Size = new System.Drawing.Size(91, 13);
            this.label_FullName.TabIndex = 4;
            this.label_FullName.Text = "Nombre Completo";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(12, 159);
            this.textBox_Email.MaxLength = 40;
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(270, 20);
            this.textBox_Email.TabIndex = 6;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(12, 143);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(32, 13);
            this.label_Email.TabIndex = 5;
            this.label_Email.Text = "Email";
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(12, 202);
            this.textBox_PhoneNumber.MaxLength = 30;
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(270, 20);
            this.textBox_PhoneNumber.TabIndex = 8;
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Location = new System.Drawing.Point(12, 186);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(97, 13);
            this.label_PhoneNumber.TabIndex = 7;
            this.label_PhoneNumber.Text = "Número Telefónico";
            // 
            // textBox_RegisteredBusiness
            // 
            this.textBox_RegisteredBusiness.Location = new System.Drawing.Point(12, 241);
            this.textBox_RegisteredBusiness.MaxLength = 30;
            this.textBox_RegisteredBusiness.Name = "textBox_RegisteredBusiness";
            this.textBox_RegisteredBusiness.Size = new System.Drawing.Size(270, 20);
            this.textBox_RegisteredBusiness.TabIndex = 10;
            // 
            // label_RegisteredBusiness
            // 
            this.label_RegisteredBusiness.AutoSize = true;
            this.label_RegisteredBusiness.Location = new System.Drawing.Point(12, 225);
            this.label_RegisteredBusiness.Name = "label_RegisteredBusiness";
            this.label_RegisteredBusiness.Size = new System.Drawing.Size(48, 13);
            this.label_RegisteredBusiness.TabIndex = 9;
            this.label_RegisteredBusiness.Text = "Empresa";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(12, 298);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 11;
            this.button_Cancel.Text = "Cancelar";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_SaveClient
            // 
            this.button_SaveClient.Location = new System.Drawing.Point(179, 298);
            this.button_SaveClient.Name = "button_SaveClient";
            this.button_SaveClient.Size = new System.Drawing.Size(103, 23);
            this.button_SaveClient.TabIndex = 12;
            this.button_SaveClient.Text = "Registrar Cliente";
            this.button_SaveClient.UseVisualStyleBackColor = true;
            this.button_SaveClient.Click += new System.EventHandler(this.button_SaveClient_Click);
            // 
            // CreateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 333);
            this.Controls.Add(this.button_SaveClient);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.textBox_RegisteredBusiness);
            this.Controls.Add(this.label_RegisteredBusiness);
            this.Controls.Add(this.textBox_PhoneNumber);
            this.Controls.Add(this.label_PhoneNumber);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_FullName);
            this.Controls.Add(this.textBox_Surnames);
            this.Controls.Add(this.label_Surnames);
            this.Controls.Add(this.textBox_Names);
            this.Controls.Add(this.label1);
            this.Name = "CreateClient";
            this.Text = "Nuevo Cliente...";
            this.Load += new System.EventHandler(this.CreateClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Names;
        private System.Windows.Forms.Label label_Surnames;
        private System.Windows.Forms.TextBox textBox_Surnames;
        private System.Windows.Forms.Label label_FullName;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_RegisteredBusiness;
        private System.Windows.Forms.Label label_RegisteredBusiness;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_SaveClient;
    }
}