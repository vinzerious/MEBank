namespace MEBank
{
    partial class Profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBrand = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpenAcc = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblAccType = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRegisterBankOfficer = new System.Windows.Forms.Button();
            this.btnRegisterCustomer = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(371, 40);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(280, 86);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "iMEBank";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 47);
            this.label5.TabIndex = 14;
            this.label5.Text = "Profile";
            // 
            // btnOpenAcc
            // 
            this.btnOpenAcc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAcc.Location = new System.Drawing.Point(226, 251);
            this.btnOpenAcc.Name = "btnOpenAcc";
            this.btnOpenAcc.Size = new System.Drawing.Size(161, 40);
            this.btnOpenAcc.TabIndex = 15;
            this.btnOpenAcc.Text = "Open Account";
            this.btnOpenAcc.UseVisualStyleBackColor = true;
            this.btnOpenAcc.Click += new System.EventHandler(this.fnOpenAccount);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(226, 321);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(161, 40);
            this.btnDeposit.TabIndex = 16;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.fnDeposit);
            // 
            // lblAccType
            // 
            this.lblAccType.AutoSize = true;
            this.lblAccType.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccType.Location = new System.Drawing.Point(147, 132);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(90, 37);
            this.lblAccType.TabIndex = 17;
            this.lblAccType.Text = "label1";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(877, 80);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 40);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.fnLogout);
            // 
            // btnRegisterBankOfficer
            // 
            this.btnRegisterBankOfficer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterBankOfficer.Location = new System.Drawing.Point(445, 251);
            this.btnRegisterBankOfficer.Name = "btnRegisterBankOfficer";
            this.btnRegisterBankOfficer.Size = new System.Drawing.Size(195, 40);
            this.btnRegisterBankOfficer.TabIndex = 19;
            this.btnRegisterBankOfficer.Text = "Register Bank Officer";
            this.btnRegisterBankOfficer.UseVisualStyleBackColor = true;
            this.btnRegisterBankOfficer.Visible = false;
            this.btnRegisterBankOfficer.Click += new System.EventHandler(this.fnRegisterBankOfficer);
            // 
            // btnRegisterCustomer
            // 
            this.btnRegisterCustomer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterCustomer.Location = new System.Drawing.Point(445, 251);
            this.btnRegisterCustomer.Name = "btnRegisterCustomer";
            this.btnRegisterCustomer.Size = new System.Drawing.Size(195, 40);
            this.btnRegisterCustomer.TabIndex = 20;
            this.btnRegisterCustomer.Text = "Register Customer";
            this.btnRegisterCustomer.UseVisualStyleBackColor = true;
            this.btnRegisterCustomer.Visible = false;
            this.btnRegisterCustomer.Click += new System.EventHandler(this.fnRegisterCustomer);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(445, 321);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(161, 40);
            this.btnTransfer.TabIndex = 21;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Visible = false;
            this.btnTransfer.Click += new System.EventHandler(this.fnTransfer);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnRegisterCustomer);
            this.Controls.Add(this.btnRegisterBankOfficer);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblAccType);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnOpenAcc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBrand);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(1024, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOpenAcc;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRegisterBankOfficer;
        private System.Windows.Forms.Button btnRegisterCustomer;
        private System.Windows.Forms.Button btnTransfer;
    }
}
