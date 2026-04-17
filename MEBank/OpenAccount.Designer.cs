namespace MEBank
{
    partial class OpenAccount
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlCardShadow = new System.Windows.Forms.Panel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlCardAccent = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.txtIBANNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnAccVerify = new System.Windows.Forms.Button();
            this.txtIDVerfiy = new System.Windows.Forms.TextBox();
            this.btnCheckIDNo = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnOpenBankAccount = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();

            // ── Dark header bar ────────────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.pnlHeader.Controls.Add(this.lblBrand);
            this.pnlHeader.Controls.Add(this.label5);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1280, 72);
            this.pnlHeader.TabIndex = 20;

            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(24, 14);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "iMEBank";

            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.label5.Location = new System.Drawing.Point(218, 22);
            this.label5.Name = "label5";
            this.label5.TabIndex = 1;
            this.label5.Text = "/ Open Account";

            this.btnBack.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnBack.Location = new System.Drawing.Point(1152, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 36);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.fnBack);

            // ── Card shadow ────────────────────────────────────────────────────
            this.pnlCardShadow.BackColor = System.Drawing.Color.FromArgb(210, 214, 219);
            this.pnlCardShadow.Location = new System.Drawing.Point(343, 95);
            this.pnlCardShadow.Name = "pnlCardShadow";
            this.pnlCardShadow.Size = new System.Drawing.Size(600, 560);
            this.pnlCardShadow.TabIndex = 21;

            // ── White form card ────────────────────────────────────────────────
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.pnlCardAccent);
            this.pnlCard.Controls.Add(this.lbl);
            this.pnlCard.Controls.Add(this.txtIBANNo);
            this.pnlCard.Controls.Add(this.label2);
            this.pnlCard.Controls.Add(this.txtCustomerID);
            this.pnlCard.Controls.Add(this.btnAccVerify);
            this.pnlCard.Controls.Add(this.txtIDVerfiy);
            this.pnlCard.Controls.Add(this.btnCheckIDNo);
            this.pnlCard.Controls.Add(this.lbl2);
            this.pnlCard.Controls.Add(this.cmbAccountType);
            this.pnlCard.Controls.Add(this.label3);
            this.pnlCard.Controls.Add(this.txtAmount);
            this.pnlCard.Controls.Add(this.btnOpenBankAccount);
            this.pnlCard.Location = new System.Drawing.Point(340, 92);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(600, 560);
            this.pnlCard.TabIndex = 22;

            this.pnlCardAccent.BackColor = System.Drawing.Color.FromArgb(0, 103, 192);
            this.pnlCardAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlCardAccent.Name = "pnlCardAccent";
            this.pnlCardAccent.Size = new System.Drawing.Size(600, 4);
            this.pnlCardAccent.TabIndex = 0;

            // IBAN No (auto-generated, readonly)
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lbl.Location = new System.Drawing.Point(48, 26);
            this.lbl.Name = "lbl";
            this.lbl.TabIndex = 1;
            this.lbl.Text = "IBAN Number (auto-generated)";

            this.txtIBANNo.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);
            this.txtIBANNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIBANNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIBANNo.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            this.txtIBANNo.Location = new System.Drawing.Point(48, 50);
            this.txtIBANNo.Name = "txtIBANNo";
            this.txtIBANNo.ReadOnly = true;
            this.txtIBANNo.Size = new System.Drawing.Size(504, 27);
            this.txtIBANNo.TabIndex = 2;

            // Customer ID
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label2.Location = new System.Drawing.Point(48, 96);
            this.label2.Name = "label2";
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer ID";

            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(48, 120);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(384, 27);
            this.txtCustomerID.TabIndex = 1;

            // Verify button
            this.btnAccVerify.BackColor = System.Drawing.Color.FromArgb(0, 103, 192);
            this.btnAccVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccVerify.FlatAppearance.BorderSize = 0;
            this.btnAccVerify.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccVerify.ForeColor = System.Drawing.Color.White;
            this.btnAccVerify.Location = new System.Drawing.Point(444, 120);
            this.btnAccVerify.Name = "btnAccVerify";
            this.btnAccVerify.Size = new System.Drawing.Size(108, 27);
            this.btnAccVerify.TabIndex = 2;
            this.btnAccVerify.Text = "Verify";
            this.btnAccVerify.UseVisualStyleBackColor = false;
            this.btnAccVerify.Click += new System.EventHandler(this.fnVerfiy);

            // ID verify (hidden initially)
            this.txtIDVerfiy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDVerfiy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDVerfiy.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            this.txtIDVerfiy.Location = new System.Drawing.Point(48, 164);
            this.txtIDVerfiy.Name = "txtIDVerfiy";
            this.txtIDVerfiy.Size = new System.Drawing.Size(384, 27);
            this.txtIDVerfiy.TabIndex = 3;
            this.txtIDVerfiy.Text = "Please input ID No to verify";
            this.txtIDVerfiy.Visible = false;

            this.btnCheckIDNo.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnCheckIDNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIDNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIDNo.FlatAppearance.BorderSize = 0;
            this.btnCheckIDNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIDNo.ForeColor = System.Drawing.Color.White;
            this.btnCheckIDNo.Location = new System.Drawing.Point(444, 164);
            this.btnCheckIDNo.Name = "btnCheckIDNo";
            this.btnCheckIDNo.Size = new System.Drawing.Size(108, 27);
            this.btnCheckIDNo.TabIndex = 4;
            this.btnCheckIDNo.Text = "Check";
            this.btnCheckIDNo.UseVisualStyleBackColor = false;
            this.btnCheckIDNo.Visible = false;
            this.btnCheckIDNo.Click += new System.EventHandler(this.fnCheckIDNo);

            // Account Type
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lbl2.Location = new System.Drawing.Point(48, 210);
            this.lbl2.Name = "lbl2";
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Account Type";

            this.cmbAccountType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Location = new System.Drawing.Point(48, 234);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(504, 27);
            this.cmbAccountType.TabIndex = 5;

            // Initial Deposit Amount
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label3.Location = new System.Drawing.Point(48, 280);
            this.label3.Name = "label3";
            this.label3.TabIndex = 7;
            this.label3.Text = "Initial Deposit Amount";

            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(48, 304);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(504, 27);
            this.txtAmount.TabIndex = 6;

            // Register (Open Account) button
            this.btnOpenBankAccount.BackColor = System.Drawing.Color.FromArgb(0, 103, 192);
            this.btnOpenBankAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenBankAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenBankAccount.FlatAppearance.BorderSize = 0;
            this.btnOpenBankAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenBankAccount.ForeColor = System.Drawing.Color.White;
            this.btnOpenBankAccount.Location = new System.Drawing.Point(48, 372);
            this.btnOpenBankAccount.Name = "btnOpenBankAccount";
            this.btnOpenBankAccount.Size = new System.Drawing.Size(504, 44);
            this.btnOpenBankAccount.TabIndex = 7;
            this.btnOpenBankAccount.Text = "Open Bank Account";
            this.btnOpenBankAccount.UseVisualStyleBackColor = false;
            this.btnOpenBankAccount.Click += new System.EventHandler(this.fnOpenBankAccount);

            // ── UserControl ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.pnlCardShadow);
            this.Controls.Add(this.pnlHeader);
            this.Name = "OpenAccount";
            this.Size = new System.Drawing.Size(1280, 800);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlCardShadow;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlCardAccent;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtIBANNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnAccVerify;
        private System.Windows.Forms.TextBox txtIDVerfiy;
        private System.Windows.Forms.Button btnCheckIDNo;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnOpenBankAccount;
    }
}
