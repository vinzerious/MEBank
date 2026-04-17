using System;

namespace MEBank
{
    partial class Transfer
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
            this.lblAccType = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlCardShadow = new System.Windows.Forms.Panel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlCardAccent = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAccountList = new System.Windows.Forms.ComboBox();
            this.pnlBalanceBg = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransferTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.pnlBalanceBg.SuspendLayout();
            this.SuspendLayout();

            // ── Dark header bar ────────────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.pnlHeader.Controls.Add(this.lblBrand);
            this.pnlHeader.Controls.Add(this.label5);
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

            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.label5.Location = new System.Drawing.Point(218, 22);
            this.label5.Name = "label5";
            this.label5.TabIndex = 1;
            this.label5.Text = "/ Transfer";

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
            this.pnlCardShadow.Size = new System.Drawing.Size(600, 490);
            this.pnlCardShadow.TabIndex = 21;

            // ── White form card ────────────────────────────────────────────────
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.pnlCardAccent);
            this.pnlCard.Controls.Add(this.label3);
            this.pnlCard.Controls.Add(this.cmbAccountList);
            this.pnlCard.Controls.Add(this.pnlBalanceBg);
            this.pnlCard.Controls.Add(this.label1);
            this.pnlCard.Controls.Add(this.txtTransferTo);
            this.pnlCard.Controls.Add(this.label2);
            this.pnlCard.Controls.Add(this.txtAmount);
            this.pnlCard.Controls.Add(this.btnTransfer);
            this.pnlCard.Location = new System.Drawing.Point(340, 108);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(600, 490);
            this.pnlCard.TabIndex = 22;

            this.pnlCardAccent.BackColor = System.Drawing.Color.FromArgb(0, 103, 192);
            this.pnlCardAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlCardAccent.Name = "pnlCardAccent";
            this.pnlCardAccent.Size = new System.Drawing.Size(600, 4);
            this.pnlCardAccent.TabIndex = 0;

            // Transfer from (source account)
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label3.Location = new System.Drawing.Point(48, 26);
            this.label3.Name = "label3";
            this.label3.TabIndex = 1;
            this.label3.Text = "Transfer From";

            this.cmbAccountList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccountList.FormattingEnabled = true;
            this.cmbAccountList.Location = new System.Drawing.Point(48, 50);
            this.cmbAccountList.Name = "cmbAccountList";
            this.cmbAccountList.Size = new System.Drawing.Size(504, 27);
            this.cmbAccountList.TabIndex = 1;
            this.cmbAccountList.SelectedIndexChanged += new System.EventHandler(this.fnGetBalance);

            // Balance info
            this.pnlBalanceBg.BackColor = System.Drawing.Color.FromArgb(232, 244, 253);
            this.pnlBalanceBg.Controls.Add(this.label6);
            this.pnlBalanceBg.Controls.Add(this.lblBalance);
            this.pnlBalanceBg.Location = new System.Drawing.Point(48, 94);
            this.pnlBalanceBg.Name = "pnlBalanceBg";
            this.pnlBalanceBg.Size = new System.Drawing.Size(504, 40);
            this.pnlBalanceBg.TabIndex = 3;

            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(0, 80, 160);
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.TabIndex = 0;
            this.label6.Text = "Available Balance:";

            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(0, 103, 192);
            this.lblBalance.Location = new System.Drawing.Point(158, 10);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "—";

            // Transfer to (destination IBAN)
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label1.Location = new System.Drawing.Point(48, 152);
            this.label1.Name = "label1";
            this.label1.TabIndex = 4;
            this.label1.Text = "Transfer To (IBAN)";

            this.txtTransferTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransferTo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferTo.Location = new System.Drawing.Point(48, 176);
            this.txtTransferTo.MaxLength = 20;
            this.txtTransferTo.Name = "txtTransferTo";
            this.txtTransferTo.Size = new System.Drawing.Size(504, 27);
            this.txtTransferTo.TabIndex = 2;

            // Amount
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label2.Location = new System.Drawing.Point(48, 222);
            this.label2.Name = "label2";
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount";

            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(48, 246);
            this.txtAmount.MaxLength = 30;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(504, 27);
            this.txtAmount.TabIndex = 3;

            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(0, 103, 192);
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(48, 312);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(504, 44);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer Funds";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.fnTransfer);

            // ── UserControl ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.pnlCardShadow);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Transfer";
            this.Size = new System.Drawing.Size(1280, 800);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlBalanceBg.ResumeLayout(false);
            this.pnlBalanceBg.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlCardShadow;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlCardAccent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAccountList;
        private System.Windows.Forms.Panel pnlBalanceBg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTransferTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnTransfer;
    }
}
