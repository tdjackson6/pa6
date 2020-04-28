namespace pa6
{
    partial class frmCWID
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
            this.lblCWID = new System.Windows.Forms.Label();
            this.txtCWID = new System.Windows.Forms.TextBox();
            this.txtOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCWID
            // 
            this.lblCWID.AutoSize = true;
            this.lblCWID.Location = new System.Drawing.Point(45, 50);
            this.lblCWID.Name = "lblCWID";
            this.lblCWID.Size = new System.Drawing.Size(153, 24);
            this.lblCWID.TabIndex = 0;
            this.lblCWID.Text = "Enter Your CWID";
            // 
            // txtCWID
            // 
            this.txtCWID.Location = new System.Drawing.Point(204, 50);
            this.txtCWID.Name = "txtCWID";
            this.txtCWID.Size = new System.Drawing.Size(218, 29);
            this.txtCWID.TabIndex = 1;
            // 
            // txtOK
            // 
            this.txtOK.Location = new System.Drawing.Point(204, 106);
            this.txtOK.Name = "txtOK";
            this.txtOK.Size = new System.Drawing.Size(95, 31);
            this.txtOK.TabIndex = 2;
            this.txtOK.Text = "OK";
            this.txtOK.UseVisualStyleBackColor = true;
            this.txtOK.Click += new System.EventHandler(this.txtOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(327, 106);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 31);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseCompatibleTextRendering = true;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCWID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 183);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtOK);
            this.Controls.Add(this.txtCWID);
            this.Controls.Add(this.lblCWID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmCWID";
            this.Text = "CWID";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCWID;
        private System.Windows.Forms.TextBox txtCWID;
        private System.Windows.Forms.Button txtOK;
        private System.Windows.Forms.Button btnClose;
    }
}

