namespace MEBank
{
    partial class RegisterIMEBank
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
            this.lblScreen = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlCardShadow = new System.Windows.Forms.Panel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlCardAccent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblVerify = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnAccVerify = new System.Windows.Forms.Button();
            this.txtIDVerfiy = new System.Windows.Forms.TextBox();
            this.btnCheckIDNo = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbAccType = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();

            // ── Dark header bar ────────────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.pnlHeader.Controls.Add(this.lblBrand);
            this.pnlHeader.Controls.Add(this.lblScreen);
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

            this.lblScreen.AutoSize = true;
            this.lblScreen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreen.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblScreen.Location = new System.Drawing.Point(218, 22);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.TabIndex = 1;
            this.lblScreen.Text = "/ iMEBank Registration";

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
            this.pnlCardShadow.Location = new System.Drawing.Point(343, 111);
            this.pnlCardShadow.Name = "pnlCardShadow";
            this.pnlCardShadow.Size = new System.Drawing.Size(600, 510);
            this.pnlCardShadow.TabIndex = 21;

            // ── White form card ────────────────────────────────────────────────
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.pnlCardAccent);
            this.pnlCard.Controls.Add(this.label1);
            this.pnlCard.Controls.Add(this.txtUserID);
            this.pnlCard.Controls.Add(this.label2);
            this.pnlCard.Controls.Add(this.txtPassword);
            this.pnlCard.Controls.Add(this.lblVerify);
            this.pnlCard.Controls.Add(this.txtCustomerID);
            this.pnlCard.Controls.Add(this.btnAccVerify);
            this.pnlCard.Controls.Add(this.txtIDVerfiy);
            this.pnlCard.Controls.Add(this.btnCheckIDNo);
            this.pnlCard.Controls.Add(this.lblType);
            this.pnlCard.Controls.Add(this.cmbAccType);
            this.pnlCard.Controls.Add(this.btnRegister);
            this.pnlCard.Location = new System.Drawing.Point(340, 108);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(600, 510);
            this.pnlCard.TabIndex = 22;

            this.pnlCardAccent.BackColor = System.Drawing.Color.FromArgb(0, 103, 192);
            this.pnlCardAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlCardAccent.Name = "pnlCardAccent";
            this.pnlCardAccent.Size = new System.Drawing.Size(600, 4);
            this.pnlCardAccent.TabIndex = 0;

            // User ID
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID";

            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(48, 50);
            this.txtUserID.MaxLength = 20;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(504, 27);
            this.txtUserID.TabIndex = 1;

            // Password
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label2.Location = new System.Drawing.Point(48, 96);
            this.label2.Name = "label2";
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";

            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(48, 120);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(504, 27);
            this.txtPassword.TabIndex = 2;

            // Customer ID + Verify
            this.lblVerify.AutoSize = true;
            this.lblVerify.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerify.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblVerify.Location = new System.Drawing.Point(48, 166);
            this.lblVerify.Name = "lblVerify";
            this.lblVerify.TabIndex = 5;
            this.lblVerify.Text = "Customer ID";

            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(48, 190);
            this.txtCustomerID.MaxLength = 50;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(384, 27);
            this.txtCustomerID.TabIndex = 3;

            this.btnAccVerify.BackColor = System.Drawing.Color.FromArgb(0, 103, 192);
            this.btnAccVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccVerify.FlatAppearance.BorderSize = 0;
            this.btnAccVerify.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccVerify.ForeColor = System.Drawing.Color.White;
            this.btnAccVerify.Location = new System.Drawing.Point(444, 190);
            this.btnAccVerify.Name = "btnAccVerify";
            this.btnAccVerify.Size = new System.Drawing.Size(108, 27);
            this.btnAccVerify.TabIndex = 4;
            this.btnAccVerify.Text = "Verify";
            this.btnAccVerify.UseVisualStyleBackColor = false;
            this.btnAccVerify.Click += new System.EventHandler(this.fnVerify);

            // ID verify (hidden initially)
            this.txtIDVerfiy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDVerfiy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDVerfiy.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            this.txtIDVerfiy.Location = new System.Drawing.Point(48, 234);
            this.txtIDVerfiy.Name = "txtIDVerfiy";
            this.txtIDVerfiy.Size = new System.Drawing.Size(384, 27);
            this.txtIDVerfiy.TabIndex = 5;
            this.txtIDVerfiy.Text = "Please input ID No to verify";
            this.txtIDVerfiy.Visible = false;

            this.btnCheckIDNo.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnCheckIDNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIDNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIDNo.FlatAppearance.BorderSize = 0;
            this.btnCheckIDNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIDNo.ForeColor = System.Drawing.Color.White;
            this.btnCheckIDNo.Location = new System.Drawing.Point(444, 234);
            this.btnCheckIDNo.Name = "btnCheckIDNo";
            this.btnCheckIDNo.Size = new System.Drawing.Size(108, 27);
            this.btnCheckIDNo.TabIndex = 6;
            this.btnCheckIDNo.Text = "Check";
            this.btnCheckIDNo.UseVisualStyleBackColor = false;
            this.btnCheckIDNo.Visible = false;
            this.btnCheckIDNo.Click += new System.EventHandler(this.fnCheckIDNo);

            // Account Type
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblType.Location = new System.Drawing.Point(48, 280);
            this.lblType.Name = "lblType";
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Account Type";

            this.cmbAccType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccType.FormattingEnabled = true;
            this.cmbAccType.Location = new System.Drawing.Point(48, 304);
            this.cmbAccType.Name = "cmbAccType";
            this.cmbAccType.Size = new System.Drawing.Size(504, 27);
            this.cmbAccType.TabIndex = 7;

            // Register button
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(0, 103, 192);
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(48, 372);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(504, 44);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.fnRegister);

            // ── UserControl ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.pnlCardShadow);
            this.Controls.Add(this.pnlHeader);
            this.Name = "RegisterIMEBank";
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
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlCardShadow;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlCardAccent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblVerify;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnAccVerify;
        private System.Windows.Forms.TextBox txtIDVerfiy;
        private System.Windows.Forms.Button btnCheckIDNo;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbAccType;
        private System.Windows.Forms.Button btnRegister;
    }
}
