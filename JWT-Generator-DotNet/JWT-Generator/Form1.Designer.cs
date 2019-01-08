namespace JWT_Generator
{
    partial class frmTokenGenerator
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
            this.cmdGenerateToken = new System.Windows.Forms.Button();
            this.lblTokenSubject = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTokenSubject = new System.Windows.Forms.TextBox();
            this.txtJsonData = new System.Windows.Forms.TextBox();
            this.txtEncodedToken = new System.Windows.Forms.TextBox();
            this.lblIsAdmin = new System.Windows.Forms.Label();
            this.cmbIsAdmin = new System.Windows.Forms.ComboBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdGenerateToken
            // 
            this.cmdGenerateToken.BackColor = System.Drawing.Color.DarkViolet;
            this.cmdGenerateToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGenerateToken.ForeColor = System.Drawing.Color.White;
            this.cmdGenerateToken.Location = new System.Drawing.Point(500, 308);
            this.cmdGenerateToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdGenerateToken.Name = "cmdGenerateToken";
            this.cmdGenerateToken.Size = new System.Drawing.Size(158, 30);
            this.cmdGenerateToken.TabIndex = 0;
            this.cmdGenerateToken.Text = "Generate Token";
            this.cmdGenerateToken.UseVisualStyleBackColor = false;
            this.cmdGenerateToken.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTokenSubject
            // 
            this.lblTokenSubject.AutoSize = true;
            this.lblTokenSubject.Location = new System.Drawing.Point(12, 20);
            this.lblTokenSubject.Name = "lblTokenSubject";
            this.lblTokenSubject.Size = new System.Drawing.Size(53, 17);
            this.lblTokenSubject.TabIndex = 1;
            this.lblTokenSubject.Text = "Subject:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(71, 61);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 25);
            this.txtName.TabIndex = 3;
            // 
            // txtTokenSubject
            // 
            this.txtTokenSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTokenSubject.Location = new System.Drawing.Point(71, 17);
            this.txtTokenSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTokenSubject.Name = "txtTokenSubject";
            this.txtTokenSubject.Size = new System.Drawing.Size(223, 25);
            this.txtTokenSubject.TabIndex = 4;
            // 
            // txtJsonData
            // 
            this.txtJsonData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJsonData.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJsonData.Location = new System.Drawing.Point(338, 17);
            this.txtJsonData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJsonData.Multiline = true;
            this.txtJsonData.Name = "txtJsonData";
            this.txtJsonData.Size = new System.Drawing.Size(320, 170);
            this.txtJsonData.TabIndex = 5;
            // 
            // txtEncodedToken
            // 
            this.txtEncodedToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEncodedToken.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncodedToken.Location = new System.Drawing.Point(14, 195);
            this.txtEncodedToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEncodedToken.Multiline = true;
            this.txtEncodedToken.Name = "txtEncodedToken";
            this.txtEncodedToken.Size = new System.Drawing.Size(644, 105);
            this.txtEncodedToken.TabIndex = 6;
            this.txtEncodedToken.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblIsAdmin
            // 
            this.lblIsAdmin.AutoSize = true;
            this.lblIsAdmin.Location = new System.Drawing.Point(12, 103);
            this.lblIsAdmin.Name = "lblIsAdmin";
            this.lblIsAdmin.Size = new System.Drawing.Size(48, 17);
            this.lblIsAdmin.TabIndex = 7;
            this.lblIsAdmin.Text = "Admin:";
            // 
            // cmbIsAdmin
            // 
            this.cmbIsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIsAdmin.FormattingEnabled = true;
            this.cmbIsAdmin.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbIsAdmin.Location = new System.Drawing.Point(71, 103);
            this.cmbIsAdmin.Name = "cmbIsAdmin";
            this.cmbIsAdmin.Size = new System.Drawing.Size(121, 25);
            this.cmbIsAdmin.TabIndex = 8;
            this.cmbIsAdmin.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtKey
            // 
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey.Location = new System.Drawing.Point(71, 148);
            this.txtKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(223, 25);
            this.txtKey.TabIndex = 10;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(12, 148);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(32, 17);
            this.lblKey.TabIndex = 9;
            this.lblKey.Text = "Key:";
            // 
            // frmTokenGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 347);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.cmbIsAdmin);
            this.Controls.Add(this.lblIsAdmin);
            this.Controls.Add(this.txtEncodedToken);
            this.Controls.Add(this.txtJsonData);
            this.Controls.Add(this.txtTokenSubject);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTokenSubject);
            this.Controls.Add(this.cmdGenerateToken);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTokenGenerator";
            this.Text = "JSON Web Token Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdGenerateToken;
        private System.Windows.Forms.Label lblTokenSubject;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTokenSubject;
        private System.Windows.Forms.TextBox txtJsonData;
        private System.Windows.Forms.TextBox txtEncodedToken;
        private System.Windows.Forms.Label lblIsAdmin;
        private System.Windows.Forms.ComboBox cmbIsAdmin;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
    }
}

