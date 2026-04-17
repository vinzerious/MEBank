namespace MEBank
{
    partial class Profile
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlBrandBar = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlUserBadge = new System.Windows.Forms.Panel();
            this.lblAccType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlNavDivider = new System.Windows.Forms.Panel();
            this.btnOpenAcc = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnParentalControl = new System.Windows.Forms.Button();
            this.btnPendingApproval = new System.Windows.Forms.Button();
            this.btnRegisterBankOfficer = new System.Windows.Forms.Button();
            this.btnRegisterCustomer = new System.Windows.Forms.Button();
            this.pnlLogoutDivider = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlContentHeader = new System.Windows.Forms.Panel();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.lblDashboardSubtitle = new System.Windows.Forms.Label();
            this.pnlWelcomeCard = new System.Windows.Forms.Panel();
            this.pnlWelcomeAccent = new System.Windows.Forms.Panel();
            this.lblWelcomeHeading = new System.Windows.Forms.Label();
            this.lblWelcomeBody = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlUserBadge.SuspendLayout();
            this.pnlContentHeader.SuspendLayout();
            this.pnlWelcomeCard.SuspendLayout();
            this.SuspendLayout();

            // ── Sidebar ────────────────────────────────────────────────────────
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.pnlSidebar.Controls.Add(this.pnlBrandBar);
            this.pnlSidebar.Controls.Add(this.lblBrand);
            this.pnlSidebar.Controls.Add(this.pnlUserBadge);
            this.pnlSidebar.Controls.Add(this.label5);
            this.pnlSidebar.Controls.Add(this.pnlNavDivider);
            this.pnlSidebar.Controls.Add(this.btnOpenAcc);
            this.pnlSidebar.Controls.Add(this.btnDeposit);
            this.pnlSidebar.Controls.Add(this.btnWithdraw);
            this.pnlSidebar.Controls.Add(this.btnTransfer);
            this.pnlSidebar.Controls.Add(this.btnParentalControl);
            this.pnlSidebar.Controls.Add(this.btnPendingApproval);
            this.pnlSidebar.Controls.Add(this.btnRegisterBankOfficer);
            this.pnlSidebar.Controls.Add(this.btnRegisterCustomer);
            this.pnlSidebar.Controls.Add(this.pnlLogoutDivider);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(240, 800);
            this.pnlSidebar.TabIndex = 20;

            // Blue accent bar at the top of the sidebar
            this.pnlBrandBar.BackColor = System.Drawing.Color.FromArgb(0, 103, 192);
            this.pnlBrandBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBrandBar.Name = "pnlBrandBar";
            this.pnlBrandBar.Size = new System.Drawing.Size(240, 4);
            this.pnlBrandBar.TabIndex = 0;

            // Brand name in sidebar
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(20, 18);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "iMEBank";

            // User badge container
            this.pnlUserBadge.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.pnlUserBadge.Controls.Add(this.lblAccType);
            this.pnlUserBadge.Location = new System.Drawing.Point(16, 74);
            this.pnlUserBadge.Name = "pnlUserBadge";
            this.pnlUserBadge.Size = new System.Drawing.Size(208, 42);
            this.pnlUserBadge.TabIndex = 2;

            // Role + user ID label inside badge
            this.lblAccType.AutoSize = false;
            this.lblAccType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccType.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblAccType.Location = new System.Drawing.Point(0, 0);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblAccType.Size = new System.Drawing.Size(208, 42);
            this.lblAccType.TabIndex = 0;
            this.lblAccType.Text = "label1";
            this.lblAccType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // "NAVIGATION" section label
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.label5.Location = new System.Drawing.Point(20, 134);
            this.label5.Name = "label5";
            this.label5.TabIndex = 3;
            this.label5.Text = "NAVIGATION";

            // Divider below section label
            this.pnlNavDivider.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.pnlNavDivider.Location = new System.Drawing.Point(16, 154);
            this.pnlNavDivider.Name = "pnlNavDivider";
            this.pnlNavDivider.Size = new System.Drawing.Size(208, 1);
            this.pnlNavDivider.TabIndex = 4;

            // ── Sidebar navigation buttons ──────────────────────────────────
            // Open Account
            this.btnOpenAcc.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnOpenAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAcc.FlatAppearance.BorderSize = 0;
            this.btnOpenAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnOpenAcc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAcc.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnOpenAcc.Location = new System.Drawing.Point(0, 162);
            this.btnOpenAcc.Name = "btnOpenAcc";
            this.btnOpenAcc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnOpenAcc.Size = new System.Drawing.Size(240, 52);
            this.btnOpenAcc.TabIndex = 5;
            this.btnOpenAcc.Text = "Open Account";
            this.btnOpenAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAcc.UseVisualStyleBackColor = false;
            this.btnOpenAcc.Click += new System.EventHandler(this.fnOpenAccount);

            // Deposit
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnDeposit.Location = new System.Drawing.Point(0, 214);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDeposit.Size = new System.Drawing.Size(240, 52);
            this.btnDeposit.TabIndex = 6;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.fnDeposit);

            // Withdraw (hidden by default, shown for Customer)
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnWithdraw.Location = new System.Drawing.Point(0, 266);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnWithdraw.Size = new System.Drawing.Size(240, 52);
            this.btnWithdraw.TabIndex = 7;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Visible = false;
            this.btnWithdraw.Click += new System.EventHandler(this.fnWithdraw);

            // Transfer (hidden by default, shown for Customer)
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnTransfer.Location = new System.Drawing.Point(0, 318);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTransfer.Size = new System.Drawing.Size(240, 52);
            this.btnTransfer.TabIndex = 8;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Visible = false;
            this.btnTransfer.Click += new System.EventHandler(this.fnTransfer);

            // Parental Controls (hidden by default, shown for Customer)
            this.btnParentalControl.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnParentalControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParentalControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParentalControl.FlatAppearance.BorderSize = 0;
            this.btnParentalControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnParentalControl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParentalControl.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnParentalControl.Location = new System.Drawing.Point(0, 370);
            this.btnParentalControl.Name = "btnParentalControl";
            this.btnParentalControl.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnParentalControl.Size = new System.Drawing.Size(240, 52);
            this.btnParentalControl.TabIndex = 9;
            this.btnParentalControl.Text = "Parental Controls";
            this.btnParentalControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParentalControl.UseVisualStyleBackColor = false;
            this.btnParentalControl.Visible = false;
            this.btnParentalControl.Click += new System.EventHandler(this.fnParentalControl);

            // Pending Approvals (hidden by default, shown for Customer)
            this.btnPendingApproval.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnPendingApproval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPendingApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendingApproval.FlatAppearance.BorderSize = 0;
            this.btnPendingApproval.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnPendingApproval.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendingApproval.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnPendingApproval.Location = new System.Drawing.Point(0, 422);
            this.btnPendingApproval.Name = "btnPendingApproval";
            this.btnPendingApproval.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPendingApproval.Size = new System.Drawing.Size(240, 52);
            this.btnPendingApproval.TabIndex = 10;
            this.btnPendingApproval.Text = "Pending Approvals";
            this.btnPendingApproval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPendingApproval.UseVisualStyleBackColor = false;
            this.btnPendingApproval.Visible = false;
            this.btnPendingApproval.Click += new System.EventHandler(this.fnPendingApproval);

            // Register Bank Officer (hidden by default, shown for Admin)
            this.btnRegisterBankOfficer.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnRegisterBankOfficer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterBankOfficer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterBankOfficer.FlatAppearance.BorderSize = 0;
            this.btnRegisterBankOfficer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnRegisterBankOfficer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterBankOfficer.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnRegisterBankOfficer.Location = new System.Drawing.Point(0, 474);
            this.btnRegisterBankOfficer.Name = "btnRegisterBankOfficer";
            this.btnRegisterBankOfficer.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRegisterBankOfficer.Size = new System.Drawing.Size(240, 52);
            this.btnRegisterBankOfficer.TabIndex = 11;
            this.btnRegisterBankOfficer.Text = "Register Bank Officer";
            this.btnRegisterBankOfficer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterBankOfficer.UseVisualStyleBackColor = false;
            this.btnRegisterBankOfficer.Visible = false;
            this.btnRegisterBankOfficer.Click += new System.EventHandler(this.fnRegisterBankOfficer);

            // Register Customer (hidden by default, shown for Bank)
            this.btnRegisterCustomer.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnRegisterCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterCustomer.FlatAppearance.BorderSize = 0;
            this.btnRegisterCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnRegisterCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterCustomer.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnRegisterCustomer.Location = new System.Drawing.Point(0, 526);
            this.btnRegisterCustomer.Name = "btnRegisterCustomer";
            this.btnRegisterCustomer.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRegisterCustomer.Size = new System.Drawing.Size(240, 52);
            this.btnRegisterCustomer.TabIndex = 12;
            this.btnRegisterCustomer.Text = "Register Customer";
            this.btnRegisterCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterCustomer.UseVisualStyleBackColor = false;
            this.btnRegisterCustomer.Visible = false;
            this.btnRegisterCustomer.Click += new System.EventHandler(this.fnRegisterCustomer);

            // Logout divider
            this.pnlLogoutDivider.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.pnlLogoutDivider.Location = new System.Drawing.Point(16, 744);
            this.pnlLogoutDivider.Name = "pnlLogoutDivider";
            this.pnlLogoutDivider.Size = new System.Drawing.Size(208, 1);
            this.pnlLogoutDivider.TabIndex = 13;

            // Logout button
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(220, 80, 80);
            this.btnLogout.Location = new System.Drawing.Point(0, 748);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(240, 52);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.fnLogout);

            // ── Content area header bar ────────────────────────────────────────
            this.pnlContentHeader.BackColor = System.Drawing.Color.White;
            this.pnlContentHeader.Controls.Add(this.lblDashboardTitle);
            this.pnlContentHeader.Controls.Add(this.lblDashboardSubtitle);
            this.pnlContentHeader.Location = new System.Drawing.Point(240, 0);
            this.pnlContentHeader.Name = "pnlContentHeader";
            this.pnlContentHeader.Size = new System.Drawing.Size(1040, 72);
            this.pnlContentHeader.TabIndex = 21;

            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.lblDashboardTitle.Location = new System.Drawing.Point(28, 12);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Dashboard";

            this.lblDashboardSubtitle.AutoSize = true;
            this.lblDashboardSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardSubtitle.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            this.lblDashboardSubtitle.Location = new System.Drawing.Point(28, 42);
            this.lblDashboardSubtitle.Name = "lblDashboardSubtitle";
            this.lblDashboardSubtitle.TabIndex = 1;
            this.lblDashboardSubtitle.Text = "Select an action from the sidebar to get started";

            // ── Welcome card in content area ───────────────────────────────────
            this.pnlWelcomeCard.BackColor = System.Drawing.Color.White;
            this.pnlWelcomeCard.Controls.Add(this.pnlWelcomeAccent);
            this.pnlWelcomeCard.Controls.Add(this.lblWelcomeHeading);
            this.pnlWelcomeCard.Controls.Add(this.lblWelcomeBody);
            this.pnlWelcomeCard.Location = new System.Drawing.Point(264, 100);
            this.pnlWelcomeCard.Name = "pnlWelcomeCard";
            this.pnlWelcomeCard.Size = new System.Drawing.Size(752, 100);
            this.pnlWelcomeCard.TabIndex = 22;

            this.pnlWelcomeAccent.BackColor = System.Drawing.Color.FromArgb(0, 103, 192);
            this.pnlWelcomeAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlWelcomeAccent.Name = "pnlWelcomeAccent";
            this.pnlWelcomeAccent.Size = new System.Drawing.Size(752, 4);
            this.pnlWelcomeAccent.TabIndex = 0;

            this.lblWelcomeHeading.AutoSize = true;
            this.lblWelcomeHeading.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeHeading.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.lblWelcomeHeading.Location = new System.Drawing.Point(24, 20);
            this.lblWelcomeHeading.Name = "lblWelcomeHeading";
            this.lblWelcomeHeading.TabIndex = 1;
            this.lblWelcomeHeading.Text = "Welcome to iMEBank";

            this.lblWelcomeBody.AutoSize = true;
            this.lblWelcomeBody.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeBody.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            this.lblWelcomeBody.Location = new System.Drawing.Point(24, 52);
            this.lblWelcomeBody.Name = "lblWelcomeBody";
            this.lblWelcomeBody.TabIndex = 2;
            this.lblWelcomeBody.Text = "Use the navigation menu on the left to access banking features.";

            // ── UserControl ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 243, 243);
            this.Controls.Add(this.pnlWelcomeCard);
            this.Controls.Add(this.pnlContentHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(1280, 800);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlUserBadge.ResumeLayout(false);
            this.pnlContentHeader.ResumeLayout(false);
            this.pnlContentHeader.PerformLayout();
            this.pnlWelcomeCard.ResumeLayout(false);
            this.pnlWelcomeCard.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlBrandBar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Panel pnlUserBadge;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlNavDivider;
        private System.Windows.Forms.Button btnOpenAcc;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnParentalControl;
        private System.Windows.Forms.Button btnPendingApproval;
        private System.Windows.Forms.Button btnRegisterBankOfficer;
        private System.Windows.Forms.Button btnRegisterCustomer;
        private System.Windows.Forms.Panel pnlLogoutDivider;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlContentHeader;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Label lblDashboardSubtitle;
        private System.Windows.Forms.Panel pnlWelcomeCard;
        private System.Windows.Forms.Panel pnlWelcomeAccent;
        private System.Windows.Forms.Label lblWelcomeHeading;
        private System.Windows.Forms.Label lblWelcomeBody;
    }
}
