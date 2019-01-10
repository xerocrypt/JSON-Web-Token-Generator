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
            this.txtJsonData = new System.Windows.Forms.TextBox();
            this.txtEncodedToken = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblUserPayload = new System.Windows.Forms.Label();
            this.lblUserHeader = new System.Windows.Forms.Label();
            this.txtInputHeader = new System.Windows.Forms.TextBox();
            this.txtInputPayload = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdGenerateToken
            // 
            this.cmdGenerateToken.BackColor = System.Drawing.Color.DarkViolet;
            this.cmdGenerateToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGenerateToken.ForeColor = System.Drawing.Color.White;
            this.cmdGenerateToken.Location = new System.Drawing.Point(853, 402);
            this.cmdGenerateToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdGenerateToken.Name = "cmdGenerateToken";
            this.cmdGenerateToken.Size = new System.Drawing.Size(158, 30);
            this.cmdGenerateToken.TabIndex = 0;
            this.cmdGenerateToken.Text = "Generate Token";
            this.cmdGenerateToken.UseVisualStyleBackColor = false;
            this.cmdGenerateToken.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtJsonData
            // 
            this.txtJsonData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJsonData.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJsonData.Location = new System.Drawing.Point(15, 25);
            this.txtJsonData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJsonData.Multiline = true;
            this.txtJsonData.Name = "txtJsonData";
            this.txtJsonData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJsonData.Size = new System.Drawing.Size(488, 127);
            this.txtJsonData.TabIndex = 5;
            // 
            // txtEncodedToken
            // 
            this.txtEncodedToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEncodedToken.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncodedToken.Location = new System.Drawing.Point(15, 172);
            this.txtEncodedToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEncodedToken.Multiline = true;
            this.txtEncodedToken.Name = "txtEncodedToken";
            this.txtEncodedToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncodedToken.Size = new System.Drawing.Size(488, 105);
            this.txtEncodedToken.TabIndex = 6;
            this.txtEncodedToken.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtKey
            // 
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey.Location = new System.Drawing.Point(13, 360);
            this.txtKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(397, 25);
            this.txtKey.TabIndex = 10;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(10, 339);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(32, 17);
            this.lblKey.TabIndex = 9;
            this.lblKey.Text = "Key:";
            // 
            // lblUserPayload
            // 
            this.lblUserPayload.AutoSize = true;
            this.lblUserPayload.Location = new System.Drawing.Point(10, 172);
            this.lblUserPayload.Name = "lblUserPayload";
            this.lblUserPayload.Size = new System.Drawing.Size(57, 17);
            this.lblUserPayload.TabIndex = 11;
            this.lblUserPayload.Text = "Payload:";
            // 
            // lblUserHeader
            // 
            this.lblUserHeader.AutoSize = true;
            this.lblUserHeader.Location = new System.Drawing.Point(13, 21);
            this.lblUserHeader.Name = "lblUserHeader";
            this.lblUserHeader.Size = new System.Drawing.Size(54, 17);
            this.lblUserHeader.TabIndex = 12;
            this.lblUserHeader.Text = "Header:";
            // 
            // txtInputHeader
            // 
            this.txtInputHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInputHeader.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputHeader.Location = new System.Drawing.Point(13, 46);
            this.txtInputHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInputHeader.Multiline = true;
            this.txtInputHeader.Name = "txtInputHeader";
            this.txtInputHeader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputHeader.Size = new System.Drawing.Size(397, 106);
            this.txtInputHeader.TabIndex = 13;
            // 
            // txtInputPayload
            // 
            this.txtInputPayload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInputPayload.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputPayload.Location = new System.Drawing.Point(13, 193);
            this.txtInputPayload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInputPayload.Multiline = true;
            this.txtInputPayload.Name = "txtInputPayload";
            this.txtInputPayload.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputPayload.Size = new System.Drawing.Size(397, 120);
            this.txtInputPayload.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txtInputPayload);
            this.groupBox1.Controls.Add(this.txtInputHeader);
            this.groupBox1.Controls.Add(this.lblUserHeader);
            this.groupBox1.Controls.Add(this.lblUserPayload);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.lblKey);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 410);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.txtEncodedToken);
            this.groupBox2.Controls.Add(this.txtJsonData);
            this.groupBox2.Location = new System.Drawing.Point(479, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 294);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // frmTokenGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdGenerateToken);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTokenGenerator";
            this.Text = "JSON Web Token Generator";
            this.Load += new System.EventHandler(this.frmTokenGenerator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdGenerateToken;
        private System.Windows.Forms.TextBox txtJsonData;
        private System.Windows.Forms.TextBox txtEncodedToken;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblUserPayload;
        private System.Windows.Forms.Label lblUserHeader;
        private System.Windows.Forms.TextBox txtInputHeader;
        private System.Windows.Forms.TextBox txtInputPayload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

