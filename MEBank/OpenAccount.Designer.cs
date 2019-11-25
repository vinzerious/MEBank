namespace MEBank
{
    partial class OpenAccount
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOpenBankAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtIBANNo = new System.Windows.Forms.TextBox();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.btnAccVerify = new System.Windows.Forms.Button();
            this.txtIDVerfiy = new System.Windows.Forms.TextBox();
            this.btnCheckIDNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 47);
            this.label5.TabIndex = 16;
            this.label5.Text = "Open Account";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(360, 40);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(280, 86);
            this.lblBrand.TabIndex = 15;
            this.lblBrand.Text = "iMEBank";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(343, 513);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.fnBack);
            // 
            // btnOpenBankAccount
            // 
            this.btnOpenBankAccount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenBankAccount.Location = new System.Drawing.Point(548, 513);
            this.btnOpenBankAccount.Name = "btnOpenBankAccount";
            this.btnOpenBankAccount.Size = new System.Drawing.Size(120, 40);
            this.btnOpenBankAccount.TabIndex = 25;
            this.btnOpenBankAccount.Text = "Register";
            this.btnOpenBankAccount.UseVisualStyleBackColor = true;
            this.btnOpenBankAccount.Click += new System.EventHandler(this.fnOpenBankAccount);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 45);
            this.label3.TabIndex = 24;
            this.label3.Text = "Amount";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(239, 344);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(212, 45);
            this.lbl2.TabIndex = 23;
            this.lbl2.Text = "Account Type";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(456, 432);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(315, 31);
            this.txtAmount.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 45);
            this.label2.TabIndex = 20;
            this.label2.Text = "Customer ID";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(239, 176);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(144, 45);
            this.lbl.TabIndex = 19;
            this.lbl.Text = "IBAN No";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(456, 264);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(315, 31);
            this.txtCustomerID.TabIndex = 18;
            // 
            // txtIBANNo
            // 
            this.txtIBANNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIBANNo.Location = new System.Drawing.Point(456, 187);
            this.txtIBANNo.Name = "txtIBANNo";
            this.txtIBANNo.ReadOnly = true;
            this.txtIBANNo.Size = new System.Drawing.Size(315, 31);
            this.txtIBANNo.TabIndex = 17;
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Location = new System.Drawing.Point(456, 360);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(315, 38);
            this.cmbAccountType.TabIndex = 27;
            // 
            // btnAccVerify
            // 
            this.btnAccVerify.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccVerify.Location = new System.Drawing.Point(777, 260);
            this.btnAccVerify.Name = "btnAccVerify";
            this.btnAccVerify.Size = new System.Drawing.Size(120, 40);
            this.btnAccVerify.TabIndex = 28;
            this.btnAccVerify.Text = "Verify";
            this.btnAccVerify.UseVisualStyleBackColor = true;
            this.btnAccVerify.Click += new System.EventHandler(this.fnVerfiy);
            // 
            // txtIDVerfiy
            // 
            this.txtIDVerfiy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDVerfiy.Location = new System.Drawing.Point(456, 313);
            this.txtIDVerfiy.Name = "txtIDVerfiy";
            this.txtIDVerfiy.Size = new System.Drawing.Size(315, 31);
            this.txtIDVerfiy.TabIndex = 29;
            this.txtIDVerfiy.Text = "Please input ID No to verify";
            this.txtIDVerfiy.Visible = false;
            // 
            // btnCheckIDNo
            // 
            this.btnCheckIDNo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIDNo.Location = new System.Drawing.Point(777, 313);
            this.btnCheckIDNo.Name = "btnCheckIDNo";
            this.btnCheckIDNo.Size = new System.Drawing.Size(120, 40);
            this.btnCheckIDNo.TabIndex = 30;
            this.btnCheckIDNo.Text = "Check";
            this.btnCheckIDNo.UseVisualStyleBackColor = true;
            this.btnCheckIDNo.Visible = false;
            this.btnCheckIDNo.Click += new System.EventHandler(this.fnCheckIDNo);
            // 
            // OpenAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCheckIDNo);
            this.Controls.Add(this.txtIDVerfiy);
            this.Controls.Add(this.btnAccVerify);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOpenBankAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtIBANNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBrand);
            this.Name = "OpenAccount";
            this.Size = new System.Drawing.Size(1024, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOpenBankAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtIBANNo;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.Button btnAccVerify;
        private System.Windows.Forms.TextBox txtIDVerfiy;
        private System.Windows.Forms.Button btnCheckIDNo;
    }
}
