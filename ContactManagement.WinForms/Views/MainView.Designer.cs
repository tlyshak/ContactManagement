namespace ContactManagement.WinForms.Views
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableRoot = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.tableTop = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.flpContacts = new System.Windows.Forms.FlowLayoutPanel();
            this.detailsRoot = new System.Windows.Forms.Panel();
            this.detailsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.flpHeaderActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeleteIcon = new System.Windows.Forms.Button();
            this.btnEditIcon = new System.Windows.Forms.Button();
            this.contentGrid = new System.Windows.Forms.TableLayoutPanel();
            this.rightStack = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddressValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNotesValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblWebsiteValue = new System.Windows.Forms.Label();
            this.leftStack = new System.Windows.Forms.FlowLayoutPanel();
            this.rowLayoutPhone = new System.Windows.Forms.TableLayoutPanel();
            this.lblPhoneValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCompanyValue = new System.Windows.Forms.Label();
            this.btnCsvExport = new System.Windows.Forms.Button();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.tableRoot.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.tableTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.detailsRoot.SuspendLayout();
            this.detailsLayout.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.headerLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.flpHeaderActions.SuspendLayout();
            this.contentGrid.SuspendLayout();
            this.rightStack.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.leftStack.SuspendLayout();
            this.rowLayoutPhone.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableRoot
            // 
            this.tableRoot.ColumnCount = 1;
            this.tableRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRoot.Controls.Add(this.panelTop, 0, 0);
            this.tableRoot.Controls.Add(this.splitMain, 0, 1);
            this.tableRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableRoot.Location = new System.Drawing.Point(0, 0);
            this.tableRoot.Name = "tableRoot";
            this.tableRoot.Padding = new System.Windows.Forms.Padding(8);
            this.tableRoot.RowCount = 2;
            this.tableRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRoot.Size = new System.Drawing.Size(884, 561);
            this.tableRoot.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tableTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(11, 11);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(862, 50);
            this.panelTop.TabIndex = 0;
            // 
            // tableTop
            // 
            this.tableTop.ColumnCount = 8;
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableTop.Controls.Add(this.btnCsvExport, 1, 0);
            this.tableTop.Controls.Add(this.txtSearch, 5, 0);
            this.tableTop.Controls.Add(this.lblSearch, 4, 0);
            this.tableTop.Controls.Add(this.lblCategory, 6, 0);
            this.tableTop.Controls.Add(this.cmbCategory, 7, 0);
            this.tableTop.Controls.Add(this.btnAdd, 0, 0);
            this.tableTop.Controls.Add(this.cmbSort, 3, 0);
            this.tableTop.Controls.Add(this.lblSort, 2, 0);
            this.tableTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableTop.Location = new System.Drawing.Point(0, 0);
            this.tableTop.Name = "tableTop";
            this.tableTop.Padding = new System.Windows.Forms.Padding(8);
            this.tableTop.RowCount = 1;
            this.tableTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTop.Size = new System.Drawing.Size(862, 50);
            this.tableTop.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(465, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(7, 3, 11, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(140, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(411, 18);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(619, 18);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(677, 14);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(174, 21);
            this.cmbCategory.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(11, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = " New Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(11, 67);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.flpContacts);
            this.splitMain.Panel1MinSize = 290;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.detailsRoot);
            this.splitMain.Panel2MinSize = 420;
            this.splitMain.Size = new System.Drawing.Size(862, 483);
            this.splitMain.SplitterDistance = 290;
            this.splitMain.TabIndex = 1;
            // 
            // flpContacts
            // 
            this.flpContacts.AutoScroll = true;
            this.flpContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpContacts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContacts.Location = new System.Drawing.Point(0, 0);
            this.flpContacts.Margin = new System.Windows.Forms.Padding(0);
            this.flpContacts.Name = "flpContacts";
            this.flpContacts.Padding = new System.Windows.Forms.Padding(8);
            this.flpContacts.Size = new System.Drawing.Size(290, 483);
            this.flpContacts.TabIndex = 0;
            this.flpContacts.WrapContents = false;
            // 
            // detailsRoot
            // 
            this.detailsRoot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.detailsRoot.Controls.Add(this.detailsLayout);
            this.detailsRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsRoot.Location = new System.Drawing.Point(0, 0);
            this.detailsRoot.Name = "detailsRoot";
            this.detailsRoot.Size = new System.Drawing.Size(568, 483);
            this.detailsRoot.TabIndex = 0;
            // 
            // detailsLayout
            // 
            this.detailsLayout.ColumnCount = 1;
            this.detailsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.detailsLayout.Controls.Add(this.headerPanel, 0, 1);
            this.detailsLayout.Controls.Add(this.flpHeaderActions, 0, 0);
            this.detailsLayout.Controls.Add(this.contentGrid, 0, 2);
            this.detailsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsLayout.Location = new System.Drawing.Point(0, 0);
            this.detailsLayout.Margin = new System.Windows.Forms.Padding(0);
            this.detailsLayout.Name = "detailsLayout";
            this.detailsLayout.Padding = new System.Windows.Forms.Padding(24);
            this.detailsLayout.RowCount = 3;
            this.detailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.detailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.detailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.detailsLayout.Size = new System.Drawing.Size(568, 483);
            this.detailsLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.AutoSize = true;
            this.headerPanel.Controls.Add(this.headerLayout);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.headerPanel.Location = new System.Drawing.Point(24, 62);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(520, 117);
            this.headerPanel.TabIndex = 0;
            // 
            // headerLayout
            // 
            this.headerLayout.AutoSize = true;
            this.headerLayout.ColumnCount = 1;
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.headerLayout.Controls.Add(this.pbAvatar, 0, 0);
            this.headerLayout.Controls.Add(this.lblFullName, 0, 1);
            this.headerLayout.Controls.Add(this.lblSubtitle, 0, 2);
            this.headerLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLayout.Location = new System.Drawing.Point(0, 0);
            this.headerLayout.Name = "headerLayout";
            this.headerLayout.RowCount = 3;
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.headerLayout.Size = new System.Drawing.Size(520, 117);
            this.headerLayout.TabIndex = 0;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbAvatar.BackColor = System.Drawing.Color.Gainsboro;
            this.pbAvatar.Location = new System.Drawing.Point(220, 3);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(80, 80);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFullName.AutoSize = true;
            this.headerLayout.SetColumnSpan(this.lblFullName, 2);
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(222, 86);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(75, 18);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSubtitle.AutoSize = true;
            this.headerLayout.SetColumnSpan(this.lblSubtitle, 2);
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(235, 104);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(49, 13);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Category";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpHeaderActions
            // 
            this.flpHeaderActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flpHeaderActions.AutoSize = true;
            this.flpHeaderActions.Controls.Add(this.btnDeleteIcon);
            this.flpHeaderActions.Controls.Add(this.btnEditIcon);
            this.flpHeaderActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpHeaderActions.Location = new System.Drawing.Point(468, 24);
            this.flpHeaderActions.Margin = new System.Windows.Forms.Padding(0);
            this.flpHeaderActions.Name = "flpHeaderActions";
            this.flpHeaderActions.Size = new System.Drawing.Size(76, 38);
            this.flpHeaderActions.TabIndex = 3;
            this.flpHeaderActions.WrapContents = false;
            // 
            // btnDeleteIcon
            // 
            this.btnDeleteIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteIcon.FlatAppearance.BorderSize = 0;
            this.btnDeleteIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIcon.Location = new System.Drawing.Point(41, 3);
            this.btnDeleteIcon.Name = "btnDeleteIcon";
            this.btnDeleteIcon.Size = new System.Drawing.Size(32, 32);
            this.btnDeleteIcon.TabIndex = 0;
            this.btnDeleteIcon.TabStop = false;
            this.btnDeleteIcon.Text = "";
            this.btnDeleteIcon.UseVisualStyleBackColor = true;
            this.btnDeleteIcon.Click += new System.EventHandler(this.btnDeleteIcon_Click);
            // 
            // btnEditIcon
            // 
            this.btnEditIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnEditIcon.FlatAppearance.BorderSize = 0;
            this.btnEditIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditIcon.Location = new System.Drawing.Point(3, 3);
            this.btnEditIcon.Name = "btnEditIcon";
            this.btnEditIcon.Size = new System.Drawing.Size(32, 32);
            this.btnEditIcon.TabIndex = 1;
            this.btnEditIcon.TabStop = false;
            this.btnEditIcon.Text = "";
            this.btnEditIcon.UseVisualStyleBackColor = false;
            this.btnEditIcon.Click += new System.EventHandler(this.btnEditIcon_Click);
            // 
            // contentGrid
            // 
            this.contentGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contentGrid.ColumnCount = 2;
            this.contentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.contentGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.contentGrid.Controls.Add(this.rightStack, 1, 0);
            this.contentGrid.Controls.Add(this.leftStack, 0, 0);
            this.contentGrid.Location = new System.Drawing.Point(24, 195);
            this.contentGrid.Margin = new System.Windows.Forms.Padding(0);
            this.contentGrid.Name = "contentGrid";
            this.contentGrid.RowCount = 1;
            this.contentGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentGrid.Size = new System.Drawing.Size(520, 264);
            this.contentGrid.TabIndex = 1;
            // 
            // rightStack
            // 
            this.rightStack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rightStack.AutoScroll = true;
            this.rightStack.Controls.Add(this.tableLayoutPanel4);
            this.rightStack.Controls.Add(this.tableLayoutPanel5);
            this.rightStack.Controls.Add(this.tableLayoutPanel3);
            this.rightStack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.rightStack.Location = new System.Drawing.Point(294, 0);
            this.rightStack.Margin = new System.Windows.Forms.Padding(0);
            this.rightStack.Name = "rightStack";
            this.rightStack.Size = new System.Drawing.Size(226, 264);
            this.rightStack.TabIndex = 1;
            this.rightStack.WrapContents = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lblAddressValue, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(225, 50);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddressValue.AutoSize = true;
            this.lblAddressValue.Location = new System.Drawing.Point(35, 18);
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(45, 13);
            this.lblAddressValue.TabIndex = 1;
            this.lblAddressValue.Text = "Address";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblNotesValue, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(225, 50);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "";
            // 
            // lblNotesValue
            // 
            this.lblNotesValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNotesValue.AutoSize = true;
            this.lblNotesValue.Location = new System.Drawing.Point(35, 18);
            this.lblNotesValue.Name = "lblNotesValue";
            this.lblNotesValue.Size = new System.Drawing.Size(35, 13);
            this.lblNotesValue.TabIndex = 1;
            this.lblNotesValue.Text = "Notes";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblWebsiteValue, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 124);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(225, 50);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "";
            // 
            // lblWebsiteValue
            // 
            this.lblWebsiteValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWebsiteValue.AutoSize = true;
            this.lblWebsiteValue.Location = new System.Drawing.Point(35, 18);
            this.lblWebsiteValue.Name = "lblWebsiteValue";
            this.lblWebsiteValue.Size = new System.Drawing.Size(46, 13);
            this.lblWebsiteValue.TabIndex = 1;
            this.lblWebsiteValue.Text = "Website";
            // 
            // leftStack
            // 
            this.leftStack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.leftStack.AutoScroll = true;
            this.leftStack.Controls.Add(this.rowLayoutPhone);
            this.leftStack.Controls.Add(this.tableLayoutPanel1);
            this.leftStack.Controls.Add(this.tableLayoutPanel2);
            this.leftStack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.leftStack.Location = new System.Drawing.Point(20, 0);
            this.leftStack.Margin = new System.Windows.Forms.Padding(0);
            this.leftStack.Name = "leftStack";
            this.leftStack.Size = new System.Drawing.Size(229, 264);
            this.leftStack.TabIndex = 0;
            this.leftStack.WrapContents = false;
            // 
            // rowLayoutPhone
            // 
            this.rowLayoutPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rowLayoutPhone.ColumnCount = 2;
            this.rowLayoutPhone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.rowLayoutPhone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rowLayoutPhone.Controls.Add(this.lblPhoneValue, 1, 0);
            this.rowLayoutPhone.Controls.Add(this.label1, 0, 0);
            this.rowLayoutPhone.Location = new System.Drawing.Point(0, 0);
            this.rowLayoutPhone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.rowLayoutPhone.Name = "rowLayoutPhone";
            this.rowLayoutPhone.RowCount = 1;
            this.rowLayoutPhone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rowLayoutPhone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.rowLayoutPhone.Size = new System.Drawing.Size(226, 50);
            this.rowLayoutPhone.TabIndex = 0;
            // 
            // lblPhoneValue
            // 
            this.lblPhoneValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhoneValue.AutoSize = true;
            this.lblPhoneValue.Location = new System.Drawing.Point(35, 18);
            this.lblPhoneValue.Name = "lblPhoneValue";
            this.lblPhoneValue.Size = new System.Drawing.Size(76, 13);
            this.lblPhoneValue.TabIndex = 1;
            this.lblPhoneValue.Text = "Phone number";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEmailValue, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "";
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.Location = new System.Drawing.Point(35, 18);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(32, 13);
            this.lblEmailValue.TabIndex = 1;
            this.lblEmailValue.Text = "Email";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCompanyValue, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 124);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(227, 50);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "";
            // 
            // lblCompanyValue
            // 
            this.lblCompanyValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCompanyValue.AutoSize = true;
            this.lblCompanyValue.Location = new System.Drawing.Point(35, 18);
            this.lblCompanyValue.Name = "lblCompanyValue";
            this.lblCompanyValue.Size = new System.Drawing.Size(51, 13);
            this.lblCompanyValue.TabIndex = 1;
            this.lblCompanyValue.Text = "Company";
            // 
            // btnCsvExport
            // 
            this.btnCsvExport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCsvExport.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCsvExport.Location = new System.Drawing.Point(120, 11);
            this.btnCsvExport.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnCsvExport.Name = "btnCsvExport";
            this.btnCsvExport.Size = new System.Drawing.Size(96, 27);
            this.btnCsvExport.TabIndex = 5;
            this.btnCsvExport.Text = " Export CSV";
            this.btnCsvExport.UseVisualStyleBackColor = true;
            this.btnCsvExport.Click += new System.EventHandler(this.btnCsvExport_Click);
            // 
            // cmbSort
            // 
            this.cmbSort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(279, 14);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(121, 21);
            this.cmbSort.TabIndex = 6;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // lblSort
            // 
            this.lblSort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(244, 18);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(29, 13);
            this.lblSort.TabIndex = 7;
            this.lblSort.Text = "Sort:";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tableRoot);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Management";
            this.tableRoot.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.tableTop.ResumeLayout(false);
            this.tableTop.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.detailsRoot.ResumeLayout(false);
            this.detailsLayout.ResumeLayout(false);
            this.detailsLayout.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.headerLayout.ResumeLayout(false);
            this.headerLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.flpHeaderActions.ResumeLayout(false);
            this.contentGrid.ResumeLayout(false);
            this.rightStack.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.leftStack.ResumeLayout(false);
            this.rowLayoutPhone.ResumeLayout(false);
            this.rowLayoutPhone.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableRoot;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TableLayoutPanel tableTop;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flpContacts;
        private System.Windows.Forms.Panel detailsRoot;
        private System.Windows.Forms.TableLayoutPanel detailsLayout;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TableLayoutPanel contentGrid;
        private System.Windows.Forms.FlowLayoutPanel leftStack;
        private System.Windows.Forms.TableLayoutPanel rowLayoutPhone;
        private System.Windows.Forms.Label lblPhoneValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblCompanyValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblWebsiteValue;
        private System.Windows.Forms.FlowLayoutPanel flpHeaderActions;
        private System.Windows.Forms.Button btnDeleteIcon;
        private System.Windows.Forms.Button btnEditIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel rightStack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblAddressValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNotesValue;
        private System.Windows.Forms.Button btnCsvExport;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label lblSort;
    }
}