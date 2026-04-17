namespace MEBank
{
    partial class Register
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
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.btnRegisterIMEBank = new System.Windows.Forms.Button();
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
            this.label5.Text = "/ Customer Registration";

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
            this.pnlCardShadow.Location = new System.Drawing.Point(191, 83);
            this.pnlCardShadow.Name = "pnlCardShadow";
            this.pnlCardShadow.Size = new System.Drawing.Size(900, 640);
            this.pnlCardShadow.TabIndex = 21;

            // ── Wide form card (two-column layout) ────────────────────────────
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.pnlCardAccent);
            this.pnlCard.Controls.Add(this.lblCustomerID);
            this.pnlCard.Controls.Add(this.txtCustomerID);
            this.pnlCard.Controls.Add(this.label2);
            this.pnlCard.Controls.Add(this.txtName);
            this.pnlCard.Controls.Add(this.label4);
            this.pnlCard.Controls.Add(this.txtMiddleName);
            this.pnlCard.Controls.Add(this.label3);
            this.pnlCard.Controls.Add(this.txtSurname);
            this.pnlCard.Controls.Add(this.label8);
            this.pnlCard.Controls.Add(this.txtIDNo);
            this.pnlCard.Controls.Add(this.label7);
            this.pnlCard.Controls.Add(this.txtAddress);
            this.pnlCard.Controls.Add(this.label1);
            this.pnlCard.Controls.Add(this.txtTelNo);
            this.pnlCard.Controls.Add(this.btnRegisterIMEBank);
            this.pnlCard.Location = new System.Drawing.Point(188, 80);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(900, 640);
            this.pnlCard.TabIndex = 22;

            this.pnlCardAccent.BackColor = System.Drawing.Color.FromArgb(0, 103, 192);
            this.pnlCardAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlCardAccent.Name = "pnlCardAccent";
            this.pnlCardAccent.Size = new System.Drawing.Size(900, 4);
            this.pnlCardAccent.TabIndex = 0;

            // ── Left column (x=48 to 432, width=384) ──────────────────────────

            // Customer ID (readonly)
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblCustomerID.Location = new System.Drawing.Point(48, 26);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "Customer ID (auto-assigned)";

            this.txtCustomerID.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);
            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            this.txtCustomerID.Location = new System.Drawing.Point(48, 50);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(384, 27);
            this.txtCustomerID.TabIndex = 2;

            // First Name
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label2.Location = new System.Drawing.Point(48, 98);
            this.label2.Name = "label2";
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";

            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(48, 122);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(384, 27);
            this.txtName.TabIndex = 1;

            // Middle Name
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label4.Location = new System.Drawing.Point(48, 170);
            this.label4.Name = "label4";
            this.label4.TabIndex = 5;
            this.label4.Text = "Middle Name";

            this.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiddleName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(48, 194);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(384, 27);
            this.txtMiddleName.TabIndex = 2;

            // Surname
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label3.Location = new System.Drawing.Point(48, 242);
            this.label3.Name = "label3";
            this.label3.TabIndex = 7;
            this.label3.Text = "Surname";

            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(48, 266);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(384, 27);
            this.txtSurname.TabIndex = 3;

            // ── Right column (x=480 to 852, width=372) ────────────────────────

            // ID Number
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label8.Location = new System.Drawing.Point(480, 98);
            this.label8.Name = "label8";
            this.label8.TabIndex = 9;
            this.label8.Text = "ID Number";

            this.txtIDNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNo.Location = new System.Drawing.Point(480, 122);
            this.txtIDNo.Name = "txtIDNo";
            this.txtIDNo.Size = new System.Drawing.Size(372, 27);
            this.txtIDNo.TabIndex = 4;

            // Address
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label7.Location = new System.Drawing.Point(480, 170);
            this.label7.Name = "label7";
            this.label7.TabIndex = 11;
            this.label7.Text = "Address";

            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(480, 194);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(372, 88);
            this.txtAddress.TabIndex = 5;

            // Tel Number
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label1.Location = new System.Drawing.Point(480, 300);
            this.label1.Name = "label1";
            this.label1.TabIndex = 13;
            this.label1.Text = "Tel. Number";

            this.txtTelNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelNo.Location = new System.Drawing.Point(480, 324);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(372, 27);
            this.txtTelNo.TabIndex = 6;

            // Register button (full width at bottom)
            this.btnRegisterIMEBank.BackColor = System.Drawing.Color.FromArgb(0, 103, 192);
            this.btnRegisterIMEBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterIMEBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterIMEBank.FlatAppearance.BorderSize = 0;
            this.btnRegisterIMEBank.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterIMEBank.ForeColor = System.Drawing.Color.White;
            this.btnRegisterIMEBank.Location = new System.Drawing.Point(48, 390);
            this.btnRegisterIMEBank.Name = "btnRegisterIMEBank";
            this.btnRegisterIMEBank.Size = new System.Drawing.Size(804, 44);
            this.btnRegisterIMEBank.TabIndex = 7;
            this.btnRegisterIMEBank.Text = "Register Customer";
            this.btnRegisterIMEBank.UseVisualStyleBackColor = false;
            this.btnRegisterIMEBank.Click += new System.EventHandler(this.fnRegister);

            // ── UserControl ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.pnlCardShadow);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Register";
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
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Button btnRegisterIMEBank;
    }
}
