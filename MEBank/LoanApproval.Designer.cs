namespace MEBank
{
    partial class LoanApproval
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
            this.pnlHeader         = new System.Windows.Forms.Panel();
            this.lblBrand          = new System.Windows.Forms.Label();
            this.lblTitle          = new System.Windows.Forms.Label();
            this.lblAccType        = new System.Windows.Forms.Label();
            this.btnBack           = new System.Windows.Forms.Button();
            this.btnRefresh        = new System.Windows.Forms.Button();
            this.pnlTableContainer = new System.Windows.Forms.Panel();
            this.dgvLoans          = new System.Windows.Forms.DataGridView();
            this.colApprLoanID     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApprCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApprCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApprAmount     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApprPurpose    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApprTerm       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApprSalary     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApprMaxElig    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApprScore      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApprGrade      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApprDocuments  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApprReqDate    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDetailPanel    = new System.Windows.Forms.Panel();
            this.lblDetailLoanID   = new System.Windows.Forms.Label();
            this.lblDetailCustomer = new System.Windows.Forms.Label();
            this.lblDetailAmount   = new System.Windows.Forms.Label();
            this.lblDetailTerm     = new System.Windows.Forms.Label();
            this.lblDetailSalary   = new System.Windows.Forms.Label();
            this.lblDetailScore    = new System.Windows.Forms.Label();
            this.lblDetailDocuments = new System.Windows.Forms.Label();
            this.lblDetailPurpose  = new System.Windows.Forms.Label();
            this.pnlActionBar      = new System.Windows.Forms.Panel();
            this.lblReviewNotes    = new System.Windows.Forms.Label();
            this.txtReviewNotes    = new System.Windows.Forms.TextBox();
            this.btnApprove        = new System.Windows.Forms.Button();
            this.btnReject         = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.pnlDetailPanel.SuspendLayout();
            this.pnlActionBar.SuspendLayout();
            this.SuspendLayout();

            // ── Header ──────────────────────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.pnlHeader.Controls.Add(this.lblBrand);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblAccType);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name     = "pnlHeader";
            this.pnlHeader.Size     = new System.Drawing.Size(1280, 72);
            this.pnlHeader.TabIndex = 0;

            this.lblBrand.AutoSize  = true;
            this.lblBrand.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location  = new System.Drawing.Point(24, 14);
            this.lblBrand.Name      = "lblBrand";
            this.lblBrand.TabIndex  = 0;
            this.lblBrand.Text      = "iMEBank";

            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTitle.Location  = new System.Drawing.Point(218, 22);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.TabIndex  = 1;
            this.lblTitle.Text      = "/ Loan Approvals";

            this.lblAccType.AutoSize  = true;
            this.lblAccType.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAccType.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblAccType.Location  = new System.Drawing.Point(780, 26);
            this.lblAccType.Name      = "lblAccType";
            this.lblAccType.TabIndex  = 2;
            this.lblAccType.Text      = "label1";

            this.btnRefresh.BackColor                 = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnRefresh.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font                      = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRefresh.ForeColor                 = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnRefresh.Location                  = new System.Drawing.Point(1036, 18);
            this.btnRefresh.Name                      = "btnRefresh";
            this.btnRefresh.Size                      = new System.Drawing.Size(100, 36);
            this.btnRefresh.TabIndex                  = 3;
            this.btnRefresh.Text                      = "↻ Refresh";
            this.btnRefresh.UseVisualStyleBackColor   = false;
            this.btnRefresh.Click                    += new System.EventHandler(this.fnRefresh);

            this.btnBack.BackColor                 = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnBack.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font                      = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.ForeColor                 = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnBack.Location                  = new System.Drawing.Point(1152, 18);
            this.btnBack.Name                      = "btnBack";
            this.btnBack.Size                      = new System.Drawing.Size(100, 36);
            this.btnBack.TabIndex                  = 4;
            this.btnBack.Text                      = "← Back";
            this.btnBack.UseVisualStyleBackColor   = false;
            this.btnBack.Click                    += new System.EventHandler(this.fnBack);

            // ── Loan list grid ──────────────────────────────────────────────────
            this.pnlTableContainer.BackColor = System.Drawing.Color.White;
            this.pnlTableContainer.Controls.Add(this.dgvLoans);
            this.pnlTableContainer.Location = new System.Drawing.Point(24, 84);
            this.pnlTableContainer.Name     = "pnlTableContainer";
            this.pnlTableContainer.Size     = new System.Drawing.Size(1232, 330);
            this.pnlTableContainer.TabIndex = 1;

            this.dgvLoans.AllowUserToAddRows    = false;
            this.dgvLoans.AllowUserToDeleteRows = false;
            this.dgvLoans.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoans.BackgroundColor        = System.Drawing.Color.White;
            this.dgvLoans.BorderStyle            = System.Windows.Forms.BorderStyle.None;
            this.dgvLoans.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.dgvLoans.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLoans.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colApprLoanID, this.colApprCustomerID, this.colApprCustomerName,
                this.colApprAmount, this.colApprPurpose, this.colApprTerm,
                this.colApprSalary, this.colApprMaxElig,
                this.colApprScore, this.colApprGrade,
                this.colApprDocuments, this.colApprReqDate });
            this.dgvLoans.DefaultCellStyle.Font                = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvLoans.DefaultCellStyle.SelectionBackColor  = System.Drawing.Color.FromArgb(200, 225, 255);
            this.dgvLoans.DefaultCellStyle.SelectionForeColor  = System.Drawing.Color.FromArgb(26, 26, 26);
            this.dgvLoans.EnableHeadersVisualStyles            = false;
            this.dgvLoans.GridColor                            = System.Drawing.Color.FromArgb(225, 225, 225);
            this.dgvLoans.Location                             = new System.Drawing.Point(0, 0);
            this.dgvLoans.MultiSelect                          = false;
            this.dgvLoans.Name                                 = "dgvLoans";
            this.dgvLoans.ReadOnly                             = true;
            this.dgvLoans.RowHeadersVisible                    = false;
            this.dgvLoans.RowTemplate.Height                   = 36;
            this.dgvLoans.SelectionMode                        = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoans.Size                                 = new System.Drawing.Size(1232, 330);
            this.dgvLoans.TabIndex                             = 0;
            this.dgvLoans.SelectionChanged                    += new System.EventHandler(this.onRowSelected);

            this.colApprLoanID.HeaderText = "Request ID";      this.colApprLoanID.Name = "colApprLoanID";         this.colApprLoanID.ReadOnly = true;
            this.colApprCustomerID.HeaderText = "Customer ID";  this.colApprCustomerID.Name = "colApprCustomerID"; this.colApprCustomerID.ReadOnly = true;
            this.colApprCustomerName.HeaderText = "Name";       this.colApprCustomerName.Name = "colApprCustomerName"; this.colApprCustomerName.ReadOnly = true;
            this.colApprAmount.HeaderText = "Amount";           this.colApprAmount.Name = "colApprAmount";         this.colApprAmount.ReadOnly = true;
            this.colApprPurpose.HeaderText = "Purpose";         this.colApprPurpose.Name = "colApprPurpose";       this.colApprPurpose.ReadOnly = true;
            this.colApprTerm.HeaderText = "Term";               this.colApprTerm.Name = "colApprTerm";             this.colApprTerm.ReadOnly = true;
            this.colApprSalary.HeaderText = "Monthly Salary";   this.colApprSalary.Name = "colApprSalary";         this.colApprSalary.ReadOnly = true;
            this.colApprMaxElig.HeaderText = "Max Eligible";    this.colApprMaxElig.Name = "colApprMaxElig";       this.colApprMaxElig.ReadOnly = true;
            this.colApprScore.HeaderText = "Score";             this.colApprScore.Name = "colApprScore";           this.colApprScore.ReadOnly = true;
            this.colApprGrade.HeaderText = "Grade";             this.colApprGrade.Name = "colApprGrade";           this.colApprGrade.ReadOnly = true;
            this.colApprDocuments.HeaderText = "Documents";     this.colApprDocuments.Name = "colApprDocuments";   this.colApprDocuments.ReadOnly = true;
            this.colApprReqDate.HeaderText = "Requested Date";  this.colApprReqDate.Name = "colApprReqDate";       this.colApprReqDate.ReadOnly = true;

            // ── Detail panel ─────────────────────────────────────────────────────
            this.pnlDetailPanel.BackColor = System.Drawing.Color.White;
            this.pnlDetailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetailPanel.Controls.Add(this.lblDetailLoanID);
            this.pnlDetailPanel.Controls.Add(this.lblDetailCustomer);
            this.pnlDetailPanel.Controls.Add(this.lblDetailAmount);
            this.pnlDetailPanel.Controls.Add(this.lblDetailTerm);
            this.pnlDetailPanel.Controls.Add(this.lblDetailSalary);
            this.pnlDetailPanel.Controls.Add(this.lblDetailScore);
            this.pnlDetailPanel.Controls.Add(this.lblDetailDocuments);
            this.pnlDetailPanel.Controls.Add(this.lblDetailPurpose);
            this.pnlDetailPanel.Location = new System.Drawing.Point(24, 426);
            this.pnlDetailPanel.Name     = "pnlDetailPanel";
            this.pnlDetailPanel.Size     = new System.Drawing.Size(1232, 164);
            this.pnlDetailPanel.TabIndex = 2;

            int dy = 8;
            System.Drawing.Font detailFont = new System.Drawing.Font("Segoe UI", 9F);
            System.Drawing.Color detailColor = System.Drawing.Color.FromArgb(50, 50, 50);

            this.lblDetailLoanID.AutoSize = true;   this.lblDetailLoanID.Font = detailFont;   this.lblDetailLoanID.ForeColor = detailColor;   this.lblDetailLoanID.Location = new System.Drawing.Point(12, dy);     this.lblDetailLoanID.Name = "lblDetailLoanID";   this.lblDetailLoanID.Text = "Request ID : —";   dy += 20;
            this.lblDetailCustomer.AutoSize = true; this.lblDetailCustomer.Font = detailFont; this.lblDetailCustomer.ForeColor = detailColor; this.lblDetailCustomer.Location = new System.Drawing.Point(12, dy);   this.lblDetailCustomer.Name = "lblDetailCustomer"; this.lblDetailCustomer.Text = "Customer   : —"; dy += 20;
            this.lblDetailAmount.AutoSize = true;   this.lblDetailAmount.Font = detailFont;   this.lblDetailAmount.ForeColor = detailColor;   this.lblDetailAmount.Location = new System.Drawing.Point(12, dy);     this.lblDetailAmount.Name = "lblDetailAmount";   this.lblDetailAmount.Text = "Amount     : —";   dy += 20;
            this.lblDetailTerm.AutoSize = true;     this.lblDetailTerm.Font = detailFont;     this.lblDetailTerm.ForeColor = detailColor;     this.lblDetailTerm.Location = new System.Drawing.Point(12, dy);       this.lblDetailTerm.Name = "lblDetailTerm";       this.lblDetailTerm.Text = "Term       : —";   dy += 20;
            this.lblDetailSalary.AutoSize = true;   this.lblDetailSalary.Font = detailFont;   this.lblDetailSalary.ForeColor = detailColor;   this.lblDetailSalary.Location = new System.Drawing.Point(12, dy);     this.lblDetailSalary.Name = "lblDetailSalary";   this.lblDetailSalary.Text = "Salary     : —";   dy += 20;
            this.lblDetailScore.AutoSize = true;    this.lblDetailScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblDetailScore.ForeColor = System.Drawing.Color.FromArgb(0, 100, 0); this.lblDetailScore.Location = new System.Drawing.Point(12, dy); this.lblDetailScore.Name = "lblDetailScore"; this.lblDetailScore.Text = "Score      : —"; dy += 20;
            this.lblDetailDocuments.AutoSize = true; this.lblDetailDocuments.Font = detailFont; this.lblDetailDocuments.ForeColor = detailColor; this.lblDetailDocuments.Location = new System.Drawing.Point(12, dy); this.lblDetailDocuments.Name = "lblDetailDocuments"; this.lblDetailDocuments.Text = "Documents  : —"; dy += 20;
            this.lblDetailPurpose.AutoSize = true;  this.lblDetailPurpose.Font = detailFont;  this.lblDetailPurpose.ForeColor = detailColor;  this.lblDetailPurpose.Location = new System.Drawing.Point(12, dy);    this.lblDetailPurpose.Name = "lblDetailPurpose";  this.lblDetailPurpose.Text = "Purpose    : —";

            // ── Action bar ──────────────────────────────────────────────────────
            this.pnlActionBar.BackColor = System.Drawing.Color.White;
            this.pnlActionBar.Controls.Add(this.lblReviewNotes);
            this.pnlActionBar.Controls.Add(this.txtReviewNotes);
            this.pnlActionBar.Controls.Add(this.btnApprove);
            this.pnlActionBar.Controls.Add(this.btnReject);
            this.pnlActionBar.Location = new System.Drawing.Point(24, 602);
            this.pnlActionBar.Name     = "pnlActionBar";
            this.pnlActionBar.Size     = new System.Drawing.Size(1232, 96);
            this.pnlActionBar.TabIndex = 3;

            this.lblReviewNotes.AutoSize  = true;
            this.lblReviewNotes.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReviewNotes.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblReviewNotes.Location  = new System.Drawing.Point(16, 16);
            this.lblReviewNotes.Name      = "lblReviewNotes";
            this.lblReviewNotes.Text      = "Review Notes (optional):";

            this.txtReviewNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReviewNotes.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReviewNotes.Location    = new System.Drawing.Point(200, 12);
            this.txtReviewNotes.Name        = "txtReviewNotes";
            this.txtReviewNotes.Size        = new System.Drawing.Size(500, 23);
            this.txtReviewNotes.TabIndex    = 0;

            this.btnApprove.BackColor                 = System.Drawing.Color.FromArgb(16, 124, 16);
            this.btnApprove.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.Font                      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnApprove.ForeColor                 = System.Drawing.Color.White;
            this.btnApprove.Location                  = new System.Drawing.Point(16, 48);
            this.btnApprove.Name                      = "btnApprove";
            this.btnApprove.Size                      = new System.Drawing.Size(160, 36);
            this.btnApprove.TabIndex                  = 1;
            this.btnApprove.Text                      = "✓  Approve";
            this.btnApprove.UseVisualStyleBackColor   = false;
            this.btnApprove.Click                    += new System.EventHandler(this.fnApprove);

            this.btnReject.BackColor                 = System.Drawing.Color.FromArgb(196, 43, 28);
            this.btnReject.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnReject.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.Font                      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReject.ForeColor                 = System.Drawing.Color.White;
            this.btnReject.Location                  = new System.Drawing.Point(192, 48);
            this.btnReject.Name                      = "btnReject";
            this.btnReject.Size                      = new System.Drawing.Size(160, 36);
            this.btnReject.TabIndex                  = 2;
            this.btnReject.Text                      = "✕  Reject";
            this.btnReject.UseVisualStyleBackColor   = false;
            this.btnReject.Click                    += new System.EventHandler(this.fnReject);

            // ── UserControl ─────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(243, 243, 243);
            this.Controls.Add(this.pnlActionBar);
            this.Controls.Add(this.pnlDetailPanel);
            this.Controls.Add(this.pnlTableContainer);
            this.Controls.Add(this.pnlHeader);
            this.Name                = "LoanApproval";
            this.Size                = new System.Drawing.Size(1280, 800);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.pnlDetailPanel.ResumeLayout(false);
            this.pnlDetailPanel.PerformLayout();
            this.pnlActionBar.ResumeLayout(false);
            this.pnlActionBar.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel              pnlHeader;
        private System.Windows.Forms.Label              lblBrand;
        private System.Windows.Forms.Label              lblTitle;
        private System.Windows.Forms.Label              lblAccType;
        private System.Windows.Forms.Button             btnBack;
        private System.Windows.Forms.Button             btnRefresh;
        private System.Windows.Forms.Panel              pnlTableContainer;
        private System.Windows.Forms.DataGridView       dgvLoans;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApprLoanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApprCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApprCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApprAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApprPurpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApprTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApprSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApprMaxElig;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApprScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApprGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApprDocuments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApprReqDate;
        private System.Windows.Forms.Panel              pnlDetailPanel;
        private System.Windows.Forms.Label              lblDetailLoanID;
        private System.Windows.Forms.Label              lblDetailCustomer;
        private System.Windows.Forms.Label              lblDetailAmount;
        private System.Windows.Forms.Label              lblDetailTerm;
        private System.Windows.Forms.Label              lblDetailSalary;
        private System.Windows.Forms.Label              lblDetailScore;
        private System.Windows.Forms.Label              lblDetailDocuments;
        private System.Windows.Forms.Label              lblDetailPurpose;
        private System.Windows.Forms.Panel              pnlActionBar;
        private System.Windows.Forms.Label              lblReviewNotes;
        private System.Windows.Forms.TextBox            txtReviewNotes;
        private System.Windows.Forms.Button             btnApprove;
        private System.Windows.Forms.Button             btnReject;
    }
}
