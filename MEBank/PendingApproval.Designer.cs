namespace MEBank
{
    partial class PendingApproval
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
            this.dgvPending = new System.Windows.Forms.DataGridView();
            this.colPendingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKidsIBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestIBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).BeginInit();
            this.SuspendLayout();
            //
            // lblBrand
            //
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(371, 10);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(280, 86);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "iMEBank";
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTitle.Location = new System.Drawing.Point(26, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Pending Transaction Approvals";
            //
            // lblAccType
            //
            this.lblAccType.AutoSize = true;
            this.lblAccType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAccType.Location = new System.Drawing.Point(26, 135);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.TabIndex = 2;
            this.lblAccType.Text = "label1";
            //
            // dgvPending
            //
            this.dgvPending.AllowUserToAddRows = false;
            this.dgvPending.AllowUserToDeleteRows = false;
            this.dgvPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colPendingID,
                this.colKidsIBAN,
                this.colDestIBAN,
                this.colType,
                this.colAmount,
                this.colRequestDate,
                this.colRequestUser});
            this.dgvPending.Location = new System.Drawing.Point(26, 165);
            this.dgvPending.MultiSelect = false;
            this.dgvPending.Name = "dgvPending";
            this.dgvPending.ReadOnly = true;
            this.dgvPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPending.Size = new System.Drawing.Size(972, 380);
            this.dgvPending.TabIndex = 3;
            //
            // colPendingID
            //
            this.colPendingID.HeaderText = "Request ID";
            this.colPendingID.Name = "colPendingID";
            this.colPendingID.ReadOnly = true;
            //
            // colKidsIBAN
            //
            this.colKidsIBAN.HeaderText = "Kids Account";
            this.colKidsIBAN.Name = "colKidsIBAN";
            this.colKidsIBAN.ReadOnly = true;
            //
            // colDestIBAN
            //
            this.colDestIBAN.HeaderText = "Destination";
            this.colDestIBAN.Name = "colDestIBAN";
            this.colDestIBAN.ReadOnly = true;
            //
            // colType
            //
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            //
            // colAmount
            //
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            //
            // colRequestDate
            //
            this.colRequestDate.HeaderText = "Requested Date";
            this.colRequestDate.Name = "colRequestDate";
            this.colRequestDate.ReadOnly = true;
            //
            // colRequestUser
            //
            this.colRequestUser.HeaderText = "Requested By";
            this.colRequestUser.Name = "colRequestUser";
            this.colRequestUser.ReadOnly = true;
            //
            // lblNotes
            //
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNotes.Location = new System.Drawing.Point(26, 560);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Notes (optional):";
            //
            // txtNotes
            //
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNotes.Location = new System.Drawing.Point(200, 557);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(360, 29);
            this.txtNotes.TabIndex = 5;
            //
            // btnApprove
            //
            this.btnApprove.BackColor = System.Drawing.Color.Green;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(26, 610);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(161, 45);
            this.btnApprove.TabIndex = 6;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.fnApprove);
            //
            // btnReject
            //
            this.btnReject.BackColor = System.Drawing.Color.Firebrick;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(200, 610);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(161, 45);
            this.btnReject.TabIndex = 7;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.fnReject);
            //
            // btnRefresh
            //
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnRefresh.Location = new System.Drawing.Point(400, 610);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 45);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.fnRefresh);
            //
            // btnBack
            //
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnBack.Location = new System.Drawing.Point(877, 60);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.fnBack);
            //
            // PendingApproval
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.dgvPending);
            this.Controls.Add(this.lblAccType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBrand);
            this.Name = "PendingApproval";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.DataGridView dgvPending;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPendingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKidsIBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestIBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestUser;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
    }
}
