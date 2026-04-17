namespace MEBank
{
    partial class ParentalControlSetup
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAccType = new System.Windows.Forms.Label();
            this.lblKidsIBAN = new System.Windows.Forms.Label();
            this.txtKidsIBANNo = new System.Windows.Forms.TextBox();
            this.lblLimit = new System.Windows.Forms.Label();
            this.txtTransactionLimit = new System.Windows.Forms.TextBox();
            this.lblLimitHint = new System.Windows.Forms.Label();
            this.chkRequireApproval = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStatusMsg = new System.Windows.Forms.Label();
            this.grpCurrentSettings = new System.Windows.Forms.GroupBox();
            this.lblCurrentKidsIBAN = new System.Windows.Forms.Label();
            this.lblCurrentLimit = new System.Windows.Forms.Label();
            this.lblCurrentApproval = new System.Windows.Forms.Label();
            this.lblCurrentParent = new System.Windows.Forms.Label();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.grpCurrentSettings.SuspendLayout();
            this.SuspendLayout();
            //
            // lblBrand
            //
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(371, 20);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(280, 86);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "iMEBank";
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(26, 110);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Parental Control Setup";
            //
            // lblAccType
            //
            this.lblAccType.AutoSize = true;
            this.lblAccType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAccType.Location = new System.Drawing.Point(26, 155);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(60, 20);
            this.lblAccType.TabIndex = 2;
            this.lblAccType.Text = "label1";
            //
            // lblKidsIBAN
            //
            this.lblKidsIBAN.AutoSize = true;
            this.lblKidsIBAN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblKidsIBAN.Location = new System.Drawing.Point(26, 200);
            this.lblKidsIBAN.Name = "lblKidsIBAN";
            this.lblKidsIBAN.TabIndex = 3;
            this.lblKidsIBAN.Text = "Kids Account IBAN No:";
            //
            // txtKidsIBANNo
            //
            this.txtKidsIBANNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtKidsIBANNo.Location = new System.Drawing.Point(220, 197);
            this.txtKidsIBANNo.Name = "txtKidsIBANNo";
            this.txtKidsIBANNo.Size = new System.Drawing.Size(220, 29);
            this.txtKidsIBANNo.TabIndex = 4;
            //
            // btnLoadSettings
            //
            this.btnLoadSettings.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLoadSettings.Location = new System.Drawing.Point(450, 197);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(130, 30);
            this.btnLoadSettings.TabIndex = 5;
            this.btnLoadSettings.Text = "Load Settings";
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.fnLoadSettings);
            //
            // lblLimit
            //
            this.lblLimit.AutoSize = true;
            this.lblLimit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLimit.Location = new System.Drawing.Point(26, 250);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.TabIndex = 6;
            this.lblLimit.Text = "Transaction Limit:";
            //
            // txtTransactionLimit
            //
            this.txtTransactionLimit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTransactionLimit.Location = new System.Drawing.Point(220, 247);
            this.txtTransactionLimit.Name = "txtTransactionLimit";
            this.txtTransactionLimit.Size = new System.Drawing.Size(160, 29);
            this.txtTransactionLimit.TabIndex = 7;
            //
            // lblLimitHint
            //
            this.lblLimitHint.AutoSize = true;
            this.lblLimitHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLimitHint.ForeColor = System.Drawing.Color.Gray;
            this.lblLimitHint.Location = new System.Drawing.Point(390, 253);
            this.lblLimitHint.Name = "lblLimitHint";
            this.lblLimitHint.TabIndex = 8;
            this.lblLimitHint.Text = "(leave empty for no limit)";
            //
            // chkRequireApproval
            //
            this.chkRequireApproval.AutoSize = true;
            this.chkRequireApproval.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chkRequireApproval.Location = new System.Drawing.Point(26, 300);
            this.chkRequireApproval.Name = "chkRequireApproval";
            this.chkRequireApproval.Size = new System.Drawing.Size(420, 25);
            this.chkRequireApproval.TabIndex = 9;
            this.chkRequireApproval.Text = "Require parent approval before each transaction";
            this.chkRequireApproval.UseVisualStyleBackColor = true;
            //
            // btnSave
            //
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnSave.Location = new System.Drawing.Point(220, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.fnSave);
            //
            // btnBack
            //
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnBack.Location = new System.Drawing.Point(877, 60);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.fnBack);
            //
            // lblStatusMsg
            //
            this.lblStatusMsg.AutoSize = true;
            this.lblStatusMsg.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatusMsg.ForeColor = System.Drawing.Color.Green;
            this.lblStatusMsg.Location = new System.Drawing.Point(26, 410);
            this.lblStatusMsg.Name = "lblStatusMsg";
            this.lblStatusMsg.TabIndex = 12;
            this.lblStatusMsg.Text = "";
            //
            // grpCurrentSettings
            //
            this.grpCurrentSettings.Controls.Add(this.lblCurrentKidsIBAN);
            this.grpCurrentSettings.Controls.Add(this.lblCurrentLimit);
            this.grpCurrentSettings.Controls.Add(this.lblCurrentApproval);
            this.grpCurrentSettings.Controls.Add(this.lblCurrentParent);
            this.grpCurrentSettings.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.grpCurrentSettings.Location = new System.Drawing.Point(26, 450);
            this.grpCurrentSettings.Name = "grpCurrentSettings";
            this.grpCurrentSettings.Size = new System.Drawing.Size(560, 160);
            this.grpCurrentSettings.TabIndex = 13;
            this.grpCurrentSettings.TabStop = false;
            this.grpCurrentSettings.Text = "Current Settings";
            this.grpCurrentSettings.Visible = false;
            //
            // lblCurrentKidsIBAN
            //
            this.lblCurrentKidsIBAN.AutoSize = true;
            this.lblCurrentKidsIBAN.Location = new System.Drawing.Point(10, 30);
            this.lblCurrentKidsIBAN.Name = "lblCurrentKidsIBAN";
            this.lblCurrentKidsIBAN.TabIndex = 0;
            this.lblCurrentKidsIBAN.Text = "Kids IBAN:";
            //
            // lblCurrentParent
            //
            this.lblCurrentParent.AutoSize = true;
            this.lblCurrentParent.Location = new System.Drawing.Point(10, 65);
            this.lblCurrentParent.Name = "lblCurrentParent";
            this.lblCurrentParent.TabIndex = 1;
            this.lblCurrentParent.Text = "Parent:";
            //
            // lblCurrentLimit
            //
            this.lblCurrentLimit.AutoSize = true;
            this.lblCurrentLimit.Location = new System.Drawing.Point(10, 100);
            this.lblCurrentLimit.Name = "lblCurrentLimit";
            this.lblCurrentLimit.TabIndex = 2;
            this.lblCurrentLimit.Text = "Transaction Limit:";
            //
            // lblCurrentApproval
            //
            this.lblCurrentApproval.AutoSize = true;
            this.lblCurrentApproval.Location = new System.Drawing.Point(10, 135);
            this.lblCurrentApproval.Name = "lblCurrentApproval";
            this.lblCurrentApproval.TabIndex = 3;
            this.lblCurrentApproval.Text = "Require Approval:";
            //
            // ParentalControlSetup
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpCurrentSettings);
            this.Controls.Add(this.lblStatusMsg);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkRequireApproval);
            this.Controls.Add(this.lblLimitHint);
            this.Controls.Add(this.txtTransactionLimit);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.btnLoadSettings);
            this.Controls.Add(this.txtKidsIBANNo);
            this.Controls.Add(this.lblKidsIBAN);
            this.Controls.Add(this.lblAccType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBrand);
            this.Name = "ParentalControlSetup";
            this.Size = new System.Drawing.Size(1024, 768);
            this.grpCurrentSettings.ResumeLayout(false);
            this.grpCurrentSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.Label lblKidsIBAN;
        private System.Windows.Forms.TextBox txtKidsIBANNo;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.TextBox txtTransactionLimit;
        private System.Windows.Forms.Label lblLimitHint;
        private System.Windows.Forms.CheckBox chkRequireApproval;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStatusMsg;
        private System.Windows.Forms.GroupBox grpCurrentSettings;
        private System.Windows.Forms.Label lblCurrentKidsIBAN;
        private System.Windows.Forms.Label lblCurrentLimit;
        private System.Windows.Forms.Label lblCurrentApproval;
        private System.Windows.Forms.Label lblCurrentParent;
        private System.Windows.Forms.Button btnLoadSettings;
    }
}
