namespace MEBank
{
    partial class PendingApproval
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlTableContainer = new System.Windows.Forms.Panel();
            this.dgvPending = new System.Windows.Forms.DataGridView();
            this.colPendingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKidsIBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestIBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlActionBar = new System.Windows.Forms.Panel();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).BeginInit();
            this.pnlActionBar.SuspendLayout();
            this.SuspendLayout();

            // ── Dark header bar ────────────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.pnlHeader.Controls.Add(this.lblBrand);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblAccType);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.btnRefresh);
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
            this.lblTitle.Text = "/ Pending Approvals";

            this.lblAccType.AutoSize = true;
            this.lblAccType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccType.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblAccType.Location = new System.Drawing.Point(780, 26);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.TabIndex = 2;
            this.lblAccType.Text = "label1";

            // Refresh button in header
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnRefresh.Location = new System.Drawing.Point(1036, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "↻ Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.fnRefresh);

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

            // ── Table container ────────────────────────────────────────────────
            this.pnlTableContainer.BackColor = System.Drawing.Color.White;
            this.pnlTableContainer.Controls.Add(this.dgvPending);
            this.pnlTableContainer.Location = new System.Drawing.Point(24, 84);
            this.pnlTableContainer.Name = "pnlTableContainer";
            this.pnlTableContainer.Size = new System.Drawing.Size(1232, 440);
            this.pnlTableContainer.TabIndex = 21;

            // ── DataGridView ───────────────────────────────────────────────────
            this.dgvPending.AllowUserToAddRows = false;
            this.dgvPending.AllowUserToDeleteRows = false;
            this.dgvPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPending.BackgroundColor = System.Drawing.Color.White;
            this.dgvPending.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPending.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.dgvPending.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPending.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPending.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(4);
            this.dgvPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colPendingID,
                this.colKidsIBAN,
                this.colDestIBAN,
                this.colType,
                this.colAmount,
                this.colRequestDate,
                this.colRequestUser});
            this.dgvPending.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPending.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 225, 255);
            this.dgvPending.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.dgvPending.EnableHeadersVisualStyles = false;
            this.dgvPending.GridColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.dgvPending.Location = new System.Drawing.Point(0, 0);
            this.dgvPending.MultiSelect = false;
            this.dgvPending.Name = "dgvPending";
            this.dgvPending.ReadOnly = true;
            this.dgvPending.RowHeadersVisible = false;
            this.dgvPending.RowTemplate.Height = 36;
            this.dgvPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPending.Size = new System.Drawing.Size(1232, 440);
            this.dgvPending.TabIndex = 3;

            // Columns
            this.colPendingID.HeaderText = "Request ID";
            this.colPendingID.Name = "colPendingID";
            this.colPendingID.ReadOnly = true;

            this.colKidsIBAN.HeaderText = "Kids Account";
            this.colKidsIBAN.Name = "colKidsIBAN";
            this.colKidsIBAN.ReadOnly = true;

            this.colDestIBAN.HeaderText = "Destination";
            this.colDestIBAN.Name = "colDestIBAN";
            this.colDestIBAN.ReadOnly = true;

            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;

            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;

            this.colRequestDate.HeaderText = "Requested Date";
            this.colRequestDate.Name = "colRequestDate";
            this.colRequestDate.ReadOnly = true;

            this.colRequestUser.HeaderText = "Requested By";
            this.colRequestUser.Name = "colRequestUser";
            this.colRequestUser.ReadOnly = true;

            // ── Action bar at bottom ───────────────────────────────────────────
            this.pnlActionBar.BackColor = System.Drawing.Color.White;
            this.pnlActionBar.Controls.Add(this.lblNotes);
            this.pnlActionBar.Controls.Add(this.txtNotes);
            this.pnlActionBar.Controls.Add(this.btnApprove);
            this.pnlActionBar.Controls.Add(this.btnReject);
            this.pnlActionBar.Location = new System.Drawing.Point(24, 540);
            this.pnlActionBar.Name = "pnlActionBar";
            this.pnlActionBar.Size = new System.Drawing.Size(1232, 96);
            this.pnlActionBar.TabIndex = 22;

            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblNotes.Location = new System.Drawing.Point(16, 16);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Notes (optional):";

            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(160, 12);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(400, 23);
            this.txtNotes.TabIndex = 5;

            // Approve button (green)
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(16, 124, 16);
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(16, 48);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(160, 36);
            this.btnApprove.TabIndex = 6;
            this.btnApprove.Text = "✓  Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.fnApprove);

            // Reject button (red)
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(196, 43, 28);
            this.btnReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(192, 48);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(160, 36);
            this.btnReject.TabIndex = 7;
            this.btnReject.Text = "✕  Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.fnReject);

            // ── UserControl ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            this.Controls.Add(this.pnlActionBar);
            this.Controls.Add(this.pnlTableContainer);
            this.Controls.Add(this.pnlHeader);
            this.Name = "PendingApproval";
            this.Size = new System.Drawing.Size(1280, 800);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).EndInit();
            this.pnlActionBar.ResumeLayout(false);
            this.pnlActionBar.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlTableContainer;
        private System.Windows.Forms.DataGridView dgvPending;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPendingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKidsIBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestIBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestUser;
        private System.Windows.Forms.Panel pnlActionBar;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
    }
}
