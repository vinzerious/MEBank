namespace MEBank
{
    partial class ParentalControlSetup
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAccType = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlCardShadow = new System.Windows.Forms.Panel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlCardAccent = new System.Windows.Forms.Panel();
            this.lblKidsIBAN = new System.Windows.Forms.Label();
            this.txtKidsIBANNo = new System.Windows.Forms.TextBox();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.lblLimit = new System.Windows.Forms.Label();
            this.txtTransactionLimit = new System.Windows.Forms.TextBox();
            this.lblLimitHint = new System.Windows.Forms.Label();
            this.chkRequireApproval = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatusMsg = new System.Windows.Forms.Label();
            this.grpCurrentSettings = new System.Windows.Forms.GroupBox();
            this.lblCurrentKidsIBAN = new System.Windows.Forms.Label();
            this.lblCurrentParent = new System.Windows.Forms.Label();
            this.lblCurrentLimit = new System.Windows.Forms.Label();
            this.lblCurrentApproval = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.grpCurrentSettings.SuspendLayout();
            this.SuspendLayout();

            // ── Dark header bar ────────────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.pnlHeader.Controls.Add(this.lblBrand);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblAccType);
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

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTitle.Location = new System.Drawing.Point(218, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "/ Parental Control Setup";

            this.lblAccType.AutoSize = true;
            this.lblAccType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccType.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblAccType.Location = new System.Drawing.Point(840, 26);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.TabIndex = 2;
            this.lblAccType.Text = "label1";

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
            this.pnlCardShadow.Size = new System.Drawing.Size(600, 380);
            this.pnlCardShadow.TabIndex = 21;

            // ── White form card ────────────────────────────────────────────────
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.pnlCardAccent);
            this.pnlCard.Controls.Add(this.lblKidsIBAN);
            this.pnlCard.Controls.Add(this.txtKidsIBANNo);
            this.pnlCard.Controls.Add(this.btnLoadSettings);
            this.pnlCard.Controls.Add(this.lblLimit);
            this.pnlCard.Controls.Add(this.txtTransactionLimit);
            this.pnlCard.Controls.Add(this.lblLimitHint);
            this.pnlCard.Controls.Add(this.chkRequireApproval);
            this.pnlCard.Controls.Add(this.btnSave);
            this.pnlCard.Controls.Add(this.lblStatusMsg);
            this.pnlCard.Location = new System.Drawing.Point(340, 108);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(600, 380);
            this.pnlCard.TabIndex = 22;

            this.pnlCardAccent.BackColor = System.Drawing.Color.FromArgb(0, 103, 192);
            this.pnlCardAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlCardAccent.Name = "pnlCardAccent";
            this.pnlCardAccent.Size = new System.Drawing.Size(600, 4);
            this.pnlCardAccent.TabIndex = 0;

            // Kids IBAN row
            this.lblKidsIBAN.AutoSize = true;
            this.lblKidsIBAN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKidsIBAN.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblKidsIBAN.Location = new System.Drawing.Point(48, 26);
            this.lblKidsIBAN.Name = "lblKidsIBAN";
            this.lblKidsIBAN.TabIndex = 1;
            this.lblKidsIBAN.Text = "Kids Account IBAN Number";

            this.txtKidsIBANNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKidsIBANNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKidsIBANNo.Location = new System.Drawing.Point(48, 50);
            this.txtKidsIBANNo.Name = "txtKidsIBANNo";
            this.txtKidsIBANNo.Size = new System.Drawing.Size(360, 27);
            this.txtKidsIBANNo.TabIndex = 1;

            this.btnLoadSettings.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnLoadSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSettings.FlatAppearance.BorderSize = 0;
            this.btnLoadSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSettings.ForeColor = System.Drawing.Color.White;
            this.btnLoadSettings.Location = new System.Drawing.Point(420, 50);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(132, 27);
            this.btnLoadSettings.TabIndex = 2;
            this.btnLoadSettings.Text = "Load Settings";
            this.btnLoadSettings.UseVisualStyleBackColor = false;
            this.btnLoadSettings.Click += new System.EventHandler(this.fnLoadSettings);

            // Transaction Limit row
            this.lblLimit.AutoSize = true;
            this.lblLimit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimit.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblLimit.Location = new System.Drawing.Point(48, 98);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.TabIndex = 3;
            this.lblLimit.Text = "Transaction Limit";

            this.txtTransactionLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransactionLimit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactionLimit.Location = new System.Drawing.Point(48, 122);
            this.txtTransactionLimit.Name = "txtTransactionLimit";
            this.txtTransactionLimit.Size = new System.Drawing.Size(180, 27);
            this.txtTransactionLimit.TabIndex = 3;

            this.lblLimitHint.AutoSize = true;
            this.lblLimitHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimitHint.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblLimitHint.Location = new System.Drawing.Point(242, 126);
            this.lblLimitHint.Name = "lblLimitHint";
            this.lblLimitHint.TabIndex = 4;
            this.lblLimitHint.Text = "(leave empty for no limit)";

            // Require Approval checkbox
            this.chkRequireApproval.AutoSize = true;
            this.chkRequireApproval.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRequireApproval.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.chkRequireApproval.Location = new System.Drawing.Point(48, 172);
            this.chkRequireApproval.Name = "chkRequireApproval";
            this.chkRequireApproval.Size = new System.Drawing.Size(420, 23);
            this.chkRequireApproval.TabIndex = 4;
            this.chkRequireApproval.Text = "Require parent approval before each transaction";
            this.chkRequireApproval.UseVisualStyleBackColor = true;

            // Save button
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 103, 192);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(48, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(504, 44);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.fnSave);

            // Status message
            this.lblStatusMsg.AutoSize = true;
            this.lblStatusMsg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusMsg.ForeColor = System.Drawing.Color.FromArgb(16, 124, 16);
            this.lblStatusMsg.Location = new System.Drawing.Point(48, 284);
            this.lblStatusMsg.Name = "lblStatusMsg";
            this.lblStatusMsg.TabIndex = 6;
            this.lblStatusMsg.Text = "";

            // ── Current Settings group (shown after load) ──────────────────────
            this.grpCurrentSettings.BackColor = System.Drawing.Color.White;
            this.grpCurrentSettings.Controls.Add(this.lblCurrentKidsIBAN);
            this.grpCurrentSettings.Controls.Add(this.lblCurrentParent);
            this.grpCurrentSettings.Controls.Add(this.lblCurrentLimit);
            this.grpCurrentSettings.Controls.Add(this.lblCurrentApproval);
            this.grpCurrentSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCurrentSettings.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.grpCurrentSettings.Location = new System.Drawing.Point(340, 508);
            this.grpCurrentSettings.Name = "grpCurrentSettings";
            this.grpCurrentSettings.Size = new System.Drawing.Size(600, 164);
            this.grpCurrentSettings.TabIndex = 23;
            this.grpCurrentSettings.TabStop = false;
            this.grpCurrentSettings.Text = "Current Settings";
            this.grpCurrentSettings.Visible = false;

            this.lblCurrentKidsIBAN.AutoSize = true;
            this.lblCurrentKidsIBAN.Location = new System.Drawing.Point(12, 30);
            this.lblCurrentKidsIBAN.Name = "lblCurrentKidsIBAN";
            this.lblCurrentKidsIBAN.TabIndex = 0;
            this.lblCurrentKidsIBAN.Text = "Kids IBAN:";

            this.lblCurrentParent.AutoSize = true;
            this.lblCurrentParent.Location = new System.Drawing.Point(12, 62);
            this.lblCurrentParent.Name = "lblCurrentParent";
            this.lblCurrentParent.TabIndex = 1;
            this.lblCurrentParent.Text = "Parent:";

            this.lblCurrentLimit.AutoSize = true;
            this.lblCurrentLimit.Location = new System.Drawing.Point(12, 94);
            this.lblCurrentLimit.Name = "lblCurrentLimit";
            this.lblCurrentLimit.TabIndex = 2;
            this.lblCurrentLimit.Text = "Transaction Limit:";

            this.lblCurrentApproval.AutoSize = true;
            this.lblCurrentApproval.Location = new System.Drawing.Point(12, 126);
            this.lblCurrentApproval.Name = "lblCurrentApproval";
            this.lblCurrentApproval.TabIndex = 3;
            this.lblCurrentApproval.Text = "Require Approval:";

            // ── UserControl ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            this.Controls.Add(this.grpCurrentSettings);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.pnlCardShadow);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ParentalControlSetup";
            this.Size = new System.Drawing.Size(1280, 800);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.grpCurrentSettings.ResumeLayout(false);
            this.grpCurrentSettings.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlCardShadow;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlCardAccent;
        private System.Windows.Forms.Label lblKidsIBAN;
        private System.Windows.Forms.TextBox txtKidsIBANNo;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.TextBox txtTransactionLimit;
        private System.Windows.Forms.Label lblLimitHint;
        private System.Windows.Forms.CheckBox chkRequireApproval;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStatusMsg;
        private System.Windows.Forms.GroupBox grpCurrentSettings;
        private System.Windows.Forms.Label lblCurrentKidsIBAN;
        private System.Windows.Forms.Label lblCurrentParent;
        private System.Windows.Forms.Label lblCurrentLimit;
        private System.Windows.Forms.Label lblCurrentApproval;
    }
}
