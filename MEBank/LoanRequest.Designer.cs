namespace MEBank
{
    partial class LoanRequest
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
            this.pnlHeader            = new System.Windows.Forms.Panel();
            this.lblBrand             = new System.Windows.Forms.Label();
            this.lblTitle             = new System.Windows.Forms.Label();
            this.lblAccType           = new System.Windows.Forms.Label();
            this.btnBack              = new System.Windows.Forms.Button();
            this.btnRefresh           = new System.Windows.Forms.Button();
            this.tabControl           = new System.Windows.Forms.TabControl();
            this.tabApply             = new System.Windows.Forms.TabPage();
            this.pnlApplyForm         = new System.Windows.Forms.Panel();
            this.lblLoanAmount        = new System.Windows.Forms.Label();
            this.txtLoanAmount        = new System.Windows.Forms.TextBox();
            this.lblLoanPurpose       = new System.Windows.Forms.Label();
            this.txtLoanPurpose       = new System.Windows.Forms.TextBox();
            this.lblLoanTerm          = new System.Windows.Forms.Label();
            this.cmbLoanTerm          = new System.Windows.Forms.ComboBox();
            this.lblMonthlySalary     = new System.Windows.Forms.Label();
            this.txtMonthlySalary     = new System.Windows.Forms.TextBox();
            this.lblMaxEligible       = new System.Windows.Forms.Label();
            this.lblDocumentDesc      = new System.Windows.Forms.Label();
            this.txtDocumentDescription = new System.Windows.Forms.TextBox();
            this.lblScoreInfo         = new System.Windows.Forms.Label();
            this.btnSubmit            = new System.Windows.Forms.Button();
            this.tabMyLoans           = new System.Windows.Forms.TabPage();
            this.pnlTableContainer    = new System.Windows.Forms.Panel();
            this.dgvMyLoans           = new System.Windows.Forms.DataGridView();
            this.colLoanID            = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoanAmount        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurpose           = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerm              = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalary            = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxElig           = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrade             = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus            = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestDate       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabApply.SuspendLayout();
            this.tabMyLoans.SuspendLayout();
            this.pnlTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyLoans)).BeginInit();
            this.SuspendLayout();

            // ── Header ──────────────────────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.pnlHeader.Controls.Add(this.lblBrand);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblAccType);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Location  = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name      = "pnlHeader";
            this.pnlHeader.Size      = new System.Drawing.Size(1280, 72);
            this.pnlHeader.TabIndex  = 0;

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
            this.lblTitle.Text      = "/ Loan Request";

            this.lblAccType.AutoSize  = true;
            this.lblAccType.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAccType.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblAccType.Location  = new System.Drawing.Point(780, 26);
            this.lblAccType.Name      = "lblAccType";
            this.lblAccType.TabIndex  = 2;
            this.lblAccType.Text      = "label1";

            this.btnRefresh.BackColor                  = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnRefresh.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize  = 0;
            this.btnRefresh.Font                       = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRefresh.ForeColor                  = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnRefresh.Location                   = new System.Drawing.Point(1036, 18);
            this.btnRefresh.Name                       = "btnRefresh";
            this.btnRefresh.Size                       = new System.Drawing.Size(100, 36);
            this.btnRefresh.TabIndex                   = 3;
            this.btnRefresh.Text                       = "↻ Refresh";
            this.btnRefresh.UseVisualStyleBackColor    = false;
            this.btnRefresh.Click                     += new System.EventHandler(this.fnRefresh);

            this.btnBack.BackColor                  = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnBack.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize  = 0;
            this.btnBack.Font                       = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.ForeColor                  = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnBack.Location                   = new System.Drawing.Point(1152, 18);
            this.btnBack.Name                       = "btnBack";
            this.btnBack.Size                       = new System.Drawing.Size(100, 36);
            this.btnBack.TabIndex                   = 4;
            this.btnBack.Text                       = "← Back";
            this.btnBack.UseVisualStyleBackColor    = false;
            this.btnBack.Click                     += new System.EventHandler(this.fnBack);

            // ── Tab Control ─────────────────────────────────────────────────────
            this.tabControl.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location  = new System.Drawing.Point(24, 84);
            this.tabControl.Name      = "tabControl";
            this.tabControl.Size      = new System.Drawing.Size(1232, 696);
            this.tabControl.TabIndex  = 1;
            this.tabControl.Controls.Add(this.tabApply);
            this.tabControl.Controls.Add(this.tabMyLoans);

            // ── Tab: Apply ──────────────────────────────────────────────────────
            this.tabApply.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            this.tabApply.Controls.Add(this.pnlApplyForm);
            this.tabApply.Name     = "tabApply";
            this.tabApply.Padding  = new System.Windows.Forms.Padding(10);
            this.tabApply.TabIndex = 0;
            this.tabApply.Text     = "  Apply for Loan  ";

            this.pnlApplyForm.AutoScroll    = true;
            this.pnlApplyForm.BackColor     = System.Drawing.Color.White;
            this.pnlApplyForm.Controls.Add(this.lblLoanAmount);
            this.pnlApplyForm.Controls.Add(this.txtLoanAmount);
            this.pnlApplyForm.Controls.Add(this.lblMonthlySalary);
            this.pnlApplyForm.Controls.Add(this.txtMonthlySalary);
            this.pnlApplyForm.Controls.Add(this.lblMaxEligible);
            this.pnlApplyForm.Controls.Add(this.lblLoanPurpose);
            this.pnlApplyForm.Controls.Add(this.txtLoanPurpose);
            this.pnlApplyForm.Controls.Add(this.lblLoanTerm);
            this.pnlApplyForm.Controls.Add(this.cmbLoanTerm);
            this.pnlApplyForm.Controls.Add(this.lblDocumentDesc);
            this.pnlApplyForm.Controls.Add(this.txtDocumentDescription);
            this.pnlApplyForm.Controls.Add(this.lblScoreInfo);
            this.pnlApplyForm.Controls.Add(this.btnSubmit);
            this.pnlApplyForm.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlApplyForm.Name      = "pnlApplyForm";
            this.pnlApplyForm.Padding   = new System.Windows.Forms.Padding(40, 30, 40, 30);
            this.pnlApplyForm.TabIndex  = 0;

            int labelX = 40, fieldX = 260, rowH = 56, y = 30;

            // Loan Amount
            this.lblLoanAmount.AutoSize  = true;
            this.lblLoanAmount.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLoanAmount.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblLoanAmount.Location  = new System.Drawing.Point(labelX, y + 6);
            this.lblLoanAmount.Name      = "lblLoanAmount";
            this.lblLoanAmount.Text      = "Loan Amount *";

            this.txtLoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoanAmount.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLoanAmount.Location    = new System.Drawing.Point(fieldX, y);
            this.txtLoanAmount.Name        = "txtLoanAmount";
            this.txtLoanAmount.Size        = new System.Drawing.Size(220, 30);
            this.txtLoanAmount.TextChanged += new System.EventHandler(this.onSalaryOrAmountChanged);

            y += rowH;

            // Monthly Salary
            this.lblMonthlySalary.AutoSize  = true;
            this.lblMonthlySalary.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMonthlySalary.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblMonthlySalary.Location  = new System.Drawing.Point(labelX, y + 6);
            this.lblMonthlySalary.Name      = "lblMonthlySalary";
            this.lblMonthlySalary.Text      = "Monthly Salary *";

            this.txtMonthlySalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonthlySalary.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMonthlySalary.Location    = new System.Drawing.Point(fieldX, y);
            this.txtMonthlySalary.Name        = "txtMonthlySalary";
            this.txtMonthlySalary.Size        = new System.Drawing.Size(220, 30);
            this.txtMonthlySalary.TextChanged += new System.EventHandler(this.onSalaryOrAmountChanged);

            this.lblMaxEligible.AutoSize  = true;
            this.lblMaxEligible.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMaxEligible.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            this.lblMaxEligible.Location  = new System.Drawing.Point(fieldX + 230, y + 6);
            this.lblMaxEligible.Name      = "lblMaxEligible";
            this.lblMaxEligible.Text      = "Max eligible: —";

            y += rowH;

            // Loan Purpose
            this.lblLoanPurpose.AutoSize  = true;
            this.lblLoanPurpose.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLoanPurpose.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblLoanPurpose.Location  = new System.Drawing.Point(labelX, y + 6);
            this.lblLoanPurpose.Name      = "lblLoanPurpose";
            this.lblLoanPurpose.Text      = "Loan Purpose *";

            this.txtLoanPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoanPurpose.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLoanPurpose.Location    = new System.Drawing.Point(fieldX, y);
            this.txtLoanPurpose.Name        = "txtLoanPurpose";
            this.txtLoanPurpose.Size        = new System.Drawing.Size(560, 30);

            y += rowH;

            // Loan Term
            this.lblLoanTerm.AutoSize  = true;
            this.lblLoanTerm.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLoanTerm.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblLoanTerm.Location  = new System.Drawing.Point(labelX, y + 6);
            this.lblLoanTerm.Name      = "lblLoanTerm";
            this.lblLoanTerm.Text      = "Loan Term *";

            this.cmbLoanTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoanTerm.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLoanTerm.Location      = new System.Drawing.Point(fieldX, y);
            this.cmbLoanTerm.Name          = "cmbLoanTerm";
            this.cmbLoanTerm.Size          = new System.Drawing.Size(160, 28);
            this.cmbLoanTerm.Items.AddRange(new object[] { "6", "12", "24", "36", "48", "60" });

            y += rowH;

            // Document Description
            this.lblDocumentDesc.AutoSize  = true;
            this.lblDocumentDesc.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDocumentDesc.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblDocumentDesc.Location  = new System.Drawing.Point(labelX, y + 6);
            this.lblDocumentDesc.Name      = "lblDocumentDesc";
            this.lblDocumentDesc.Text      = "Submitted Documents";

            this.txtDocumentDescription.BorderStyle  = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumentDescription.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDocumentDescription.Location     = new System.Drawing.Point(fieldX, y);
            this.txtDocumentDescription.Multiline    = true;
            this.txtDocumentDescription.Name         = "txtDocumentDescription";
            this.txtDocumentDescription.Size         = new System.Drawing.Size(560, 70);
            this.txtDocumentDescription.ScrollBars   = System.Windows.Forms.ScrollBars.Vertical;

            y += 90;

            // Score info banner
            this.lblScoreInfo.AutoSize  = false;
            this.lblScoreInfo.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblScoreInfo.ForeColor = System.Drawing.Color.FromArgb(0, 80, 150);
            this.lblScoreInfo.BackColor = System.Drawing.Color.FromArgb(224, 240, 255);
            this.lblScoreInfo.Location  = new System.Drawing.Point(labelX, y);
            this.lblScoreInfo.Name      = "lblScoreInfo";
            this.lblScoreInfo.Padding   = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.lblScoreInfo.Size      = new System.Drawing.Size(780, 44);
            this.lblScoreInfo.Text      = "Your financial score (0–100) is calculated automatically based on your account " +
                                          "balance, salary-to-loan ratio, and transaction history. " +
                                          "Good ≥ 70 | Fair ≥ 40 | Poor < 40";

            y += 60;

            // Submit button
            this.btnSubmit.BackColor               = System.Drawing.Color.FromArgb(0, 103, 192);
            this.btnSubmit.Cursor                  = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle               = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.Font                    = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor               = System.Drawing.Color.White;
            this.btnSubmit.Location                = new System.Drawing.Point(fieldX, y);
            this.btnSubmit.Name                    = "btnSubmit";
            this.btnSubmit.Size                    = new System.Drawing.Size(200, 40);
            this.btnSubmit.TabIndex                = 10;
            this.btnSubmit.Text                    = "Submit Request";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click                  += new System.EventHandler(this.fnSubmit);

            // ── Tab: My Loans ───────────────────────────────────────────────────
            this.tabMyLoans.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            this.tabMyLoans.Controls.Add(this.pnlTableContainer);
            this.tabMyLoans.Name     = "tabMyLoans";
            this.tabMyLoans.Padding  = new System.Windows.Forms.Padding(10);
            this.tabMyLoans.TabIndex = 1;
            this.tabMyLoans.Text     = "  My Loan Requests  ";

            this.pnlTableContainer.BackColor = System.Drawing.Color.White;
            this.pnlTableContainer.Controls.Add(this.dgvMyLoans);
            this.pnlTableContainer.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableContainer.Name      = "pnlTableContainer";
            this.pnlTableContainer.TabIndex  = 0;

            // DataGridView
            this.dgvMyLoans.AllowUserToAddRows    = false;
            this.dgvMyLoans.AllowUserToDeleteRows = false;
            this.dgvMyLoans.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyLoans.BackgroundColor        = System.Drawing.Color.White;
            this.dgvMyLoans.BorderStyle            = System.Windows.Forms.BorderStyle.None;
            this.dgvMyLoans.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.dgvMyLoans.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMyLoans.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvMyLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyLoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colLoanID, this.colLoanAmount, this.colPurpose, this.colTerm,
                this.colSalary, this.colMaxElig, this.colScore, this.colGrade,
                this.colStatus, this.colRequestDate });
            this.dgvMyLoans.DefaultCellStyle.Font                 = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvMyLoans.DefaultCellStyle.SelectionBackColor   = System.Drawing.Color.FromArgb(200, 225, 255);
            this.dgvMyLoans.DefaultCellStyle.SelectionForeColor   = System.Drawing.Color.FromArgb(26, 26, 26);
            this.dgvMyLoans.EnableHeadersVisualStyles             = false;
            this.dgvMyLoans.GridColor                             = System.Drawing.Color.FromArgb(225, 225, 225);
            this.dgvMyLoans.Dock                                  = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyLoans.MultiSelect                           = false;
            this.dgvMyLoans.Name                                  = "dgvMyLoans";
            this.dgvMyLoans.ReadOnly                              = true;
            this.dgvMyLoans.RowHeadersVisible                     = false;
            this.dgvMyLoans.RowTemplate.Height                    = 36;
            this.dgvMyLoans.SelectionMode                         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyLoans.TabIndex                              = 0;

            this.colLoanID.HeaderText = "Request ID";      this.colLoanID.Name = "colLoanID";      this.colLoanID.ReadOnly = true;
            this.colLoanAmount.HeaderText = "Amount";      this.colLoanAmount.Name = "colLoanAmount"; this.colLoanAmount.ReadOnly = true;
            this.colPurpose.HeaderText = "Purpose";        this.colPurpose.Name = "colPurpose";    this.colPurpose.ReadOnly = true;
            this.colTerm.HeaderText = "Term";              this.colTerm.Name = "colTerm";          this.colTerm.ReadOnly = true;
            this.colSalary.HeaderText = "Monthly Salary";  this.colSalary.Name = "colSalary";      this.colSalary.ReadOnly = true;
            this.colMaxElig.HeaderText = "Max Eligible";   this.colMaxElig.Name = "colMaxElig";    this.colMaxElig.ReadOnly = true;
            this.colScore.HeaderText = "Score";            this.colScore.Name = "colScore";        this.colScore.ReadOnly = true;
            this.colGrade.HeaderText = "Grade";            this.colGrade.Name = "colGrade";        this.colGrade.ReadOnly = true;
            this.colStatus.HeaderText = "Status";          this.colStatus.Name = "colStatus";      this.colStatus.ReadOnly = true;
            this.colRequestDate.HeaderText = "Date";       this.colRequestDate.Name = "colRequestDate"; this.colRequestDate.ReadOnly = true;

            // ── UserControl ─────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(243, 243, 243);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlHeader);
            this.Name                = "LoanRequest";
            this.Size                = new System.Drawing.Size(1280, 800);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabApply.ResumeLayout(false);
            this.tabMyLoans.ResumeLayout(false);
            this.pnlTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyLoans)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel              pnlHeader;
        private System.Windows.Forms.Label              lblBrand;
        private System.Windows.Forms.Label              lblTitle;
        private System.Windows.Forms.Label              lblAccType;
        private System.Windows.Forms.Button             btnBack;
        private System.Windows.Forms.Button             btnRefresh;
        private System.Windows.Forms.TabControl         tabControl;
        private System.Windows.Forms.TabPage            tabApply;
        private System.Windows.Forms.Panel              pnlApplyForm;
        private System.Windows.Forms.Label              lblLoanAmount;
        private System.Windows.Forms.TextBox            txtLoanAmount;
        private System.Windows.Forms.Label              lblLoanPurpose;
        private System.Windows.Forms.TextBox            txtLoanPurpose;
        private System.Windows.Forms.Label              lblLoanTerm;
        private System.Windows.Forms.ComboBox           cmbLoanTerm;
        private System.Windows.Forms.Label              lblMonthlySalary;
        private System.Windows.Forms.TextBox            txtMonthlySalary;
        private System.Windows.Forms.Label              lblMaxEligible;
        private System.Windows.Forms.Label              lblDocumentDesc;
        private System.Windows.Forms.TextBox            txtDocumentDescription;
        private System.Windows.Forms.Label              lblScoreInfo;
        private System.Windows.Forms.Button             btnSubmit;
        private System.Windows.Forms.TabPage            tabMyLoans;
        private System.Windows.Forms.Panel              pnlTableContainer;
        private System.Windows.Forms.DataGridView       dgvMyLoans;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoanAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxElig;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestDate;
    }
}
