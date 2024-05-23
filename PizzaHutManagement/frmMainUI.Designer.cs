namespace PizzaHutManagement
{
    partial class frmMainUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainUI));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlRight = new Guna.UI.WinForms.GunaPanel();
            this.btnLogout = new Guna.UI.WinForms.GunaCircleButton();
            this.lblUsername = new Guna.UI.WinForms.GunaLabel();
            this.lblUser = new Guna.UI.WinForms.GunaLabel();
            this.ctrlMin = new Guna.UI.WinForms.GunaControlBox();
            this.ctrlMax = new Guna.UI.WinForms.GunaControlBox();
            this.ctrlExit = new Guna.UI.WinForms.GunaControlBox();
            this.pnlLeft = new Guna.UI.WinForms.GunaPanel();
            this.btnAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnIncome = new Guna.UI2.WinForms.Guna2Button();
            this.btnWarehouse = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnBills = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrders = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelieveries = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnTableList = new Guna.UI2.WinForms.Guna2Button();
            this.pboxLogo = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.pnlFill = new Guna.UI.WinForms.GunaPanel();
            this.pnlRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(202)))));
            this.pnlRight.Controls.Add(this.btnLogout);
            this.pnlRight.Controls.Add(this.lblUsername);
            this.pnlRight.Controls.Add(this.lblUser);
            this.pnlRight.Controls.Add(this.ctrlMin);
            this.pnlRight.Controls.Add(this.ctrlMax);
            this.pnlRight.Controls.Add(this.ctrlExit);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRight.Location = new System.Drawing.Point(0, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1350, 38);
            this.pnlRight.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnLogout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(202)))));
            this.btnLogout.Image = null;
            this.btnLogout.ImageSize = new System.Drawing.Size(52, 52);
            this.btnLogout.Location = new System.Drawing.Point(293, 1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(102, 36);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblUsername.Location = new System.Drawing.Point(194, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(86, 19);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "(Username)";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(152, 19);
            this.lblUser.TabIndex = 16;
            this.lblUser.Text = "Phiên đăng nhập của:";
            // 
            // ctrlMin
            // 
            this.ctrlMin.AnimationHoverSpeed = 0.07F;
            this.ctrlMin.AnimationSpeed = 0.03F;
            this.ctrlMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ctrlMin.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.ctrlMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrlMin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.ctrlMin.IconSize = 50F;
            this.ctrlMin.Location = new System.Drawing.Point(1158, 0);
            this.ctrlMin.Name = "ctrlMin";
            this.ctrlMin.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.ctrlMin.OnHoverIconColor = System.Drawing.Color.White;
            this.ctrlMin.OnPressedColor = System.Drawing.Color.Black;
            this.ctrlMin.Size = new System.Drawing.Size(64, 38);
            this.ctrlMin.TabIndex = 2;
            // 
            // ctrlMax
            // 
            this.ctrlMax.AnimationHoverSpeed = 0.07F;
            this.ctrlMax.AnimationSpeed = 0.03F;
            this.ctrlMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ctrlMax.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.ctrlMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrlMax.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.ctrlMax.IconSize = 50F;
            this.ctrlMax.Location = new System.Drawing.Point(1222, 0);
            this.ctrlMax.Name = "ctrlMax";
            this.ctrlMax.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.ctrlMax.OnHoverIconColor = System.Drawing.Color.White;
            this.ctrlMax.OnPressedColor = System.Drawing.Color.Black;
            this.ctrlMax.Size = new System.Drawing.Size(64, 38);
            this.ctrlMax.TabIndex = 1;
            // 
            // ctrlExit
            // 
            this.ctrlExit.AnimationHoverSpeed = 0.07F;
            this.ctrlExit.AnimationSpeed = 0.03F;
            this.ctrlExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ctrlExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrlExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.ctrlExit.IconSize = 50F;
            this.ctrlExit.Location = new System.Drawing.Point(1286, 0);
            this.ctrlExit.Name = "ctrlExit";
            this.ctrlExit.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.ctrlExit.OnHoverIconColor = System.Drawing.Color.White;
            this.ctrlExit.OnPressedColor = System.Drawing.Color.Black;
            this.ctrlExit.Size = new System.Drawing.Size(64, 38);
            this.ctrlExit.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(202)))));
            this.pnlLeft.Controls.Add(this.btnAdmin);
            this.pnlLeft.Controls.Add(this.btnIncome);
            this.pnlLeft.Controls.Add(this.btnWarehouse);
            this.pnlLeft.Controls.Add(this.btnCustomers);
            this.pnlLeft.Controls.Add(this.btnBills);
            this.pnlLeft.Controls.Add(this.btnOrders);
            this.pnlLeft.Controls.Add(this.btnDelieveries);
            this.pnlLeft.Controls.Add(this.btnMenu);
            this.pnlLeft.Controls.Add(this.btnTableList);
            this.pnlLeft.Controls.Add(this.pboxLogo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 38);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(164, 723);
            this.pnlLeft.TabIndex = 5;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Animated = true;
            this.btnAdmin.BorderRadius = 10;
            this.btnAdmin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(0, 604);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(164, 59);
            this.btnAdmin.TabIndex = 13;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.BorderRadius = 10;
            this.btnIncome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnIncome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIncome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIncome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIncome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncome.Enabled = false;
            this.btnIncome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnIncome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.ForeColor = System.Drawing.Color.White;
            this.btnIncome.Location = new System.Drawing.Point(0, 545);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(164, 59);
            this.btnIncome.TabIndex = 11;
            this.btnIncome.Text = "Doanh thu";
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.BorderRadius = 10;
            this.btnWarehouse.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnWarehouse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWarehouse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWarehouse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWarehouse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWarehouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWarehouse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnWarehouse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarehouse.ForeColor = System.Drawing.Color.White;
            this.btnWarehouse.Location = new System.Drawing.Point(0, 486);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(164, 59);
            this.btnWarehouse.TabIndex = 10;
            this.btnWarehouse.Text = "Kho";
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BorderRadius = 10;
            this.btnCustomers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(0, 427);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(164, 59);
            this.btnCustomers.TabIndex = 9;
            this.btnCustomers.Text = "Khách hàng";
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnBills
            // 
            this.btnBills.BorderRadius = 10;
            this.btnBills.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBills.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBills.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBills.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBills.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBills.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBills.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnBills.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.Location = new System.Drawing.Point(0, 368);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(164, 59);
            this.btnBills.TabIndex = 8;
            this.btnBills.Text = "Danh sách hóa đơn";
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BorderRadius = 10;
            this.btnOrders.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOrders.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrders.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(0, 309);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(164, 59);
            this.btnOrders.TabIndex = 7;
            this.btnOrders.Text = "Danh sách đơn đặt";
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnDelieveries
            // 
            this.btnDelieveries.BorderRadius = 10;
            this.btnDelieveries.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDelieveries.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelieveries.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelieveries.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelieveries.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelieveries.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelieveries.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnDelieveries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelieveries.ForeColor = System.Drawing.Color.White;
            this.btnDelieveries.Location = new System.Drawing.Point(0, 250);
            this.btnDelieveries.Name = "btnDelieveries";
            this.btnDelieveries.Size = new System.Drawing.Size(164, 59);
            this.btnDelieveries.TabIndex = 6;
            this.btnDelieveries.Text = "Đơn mang đi";
            this.btnDelieveries.Click += new System.EventHandler(this.btnDelieveries_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BorderRadius = 10;
            this.btnMenu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(0, 191);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(164, 59);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Menu";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // btnTableList
            // 
            this.btnTableList.BorderRadius = 10;
            this.btnTableList.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTableList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTableList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTableList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTableList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTableList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTableList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnTableList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableList.ForeColor = System.Drawing.Color.White;
            this.btnTableList.Location = new System.Drawing.Point(0, 132);
            this.btnTableList.Name = "btnTableList";
            this.btnTableList.Size = new System.Drawing.Size(164, 59);
            this.btnTableList.TabIndex = 4;
            this.btnTableList.Text = "Danh sách bàn";
            this.btnTableList.Click += new System.EventHandler(this.btnTableList_Click_1);
            // 
            // pboxLogo
            // 
            this.pboxLogo.BaseColor = System.Drawing.Color.White;
            this.pboxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pboxLogo.Image = global::PizzaHutManagement.Properties.Resources.Pizza_Hut_logo_svg;
            this.pboxLogo.InitialImage = global::PizzaHutManagement.Properties.Resources.Pizza_Hut_logo_svg;
            this.pboxLogo.Location = new System.Drawing.Point(0, 0);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(164, 132);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxLogo.TabIndex = 3;
            this.pboxLogo.TabStop = false;
            this.pboxLogo.UseTransfarantBackground = false;
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(164, 38);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(1186, 723);
            this.pnlFill.TabIndex = 6;
            // 
            // frmMainUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1350, 761);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Hut Management";
            this.Load += new System.EventHandler(this.frmMainUI_Load);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI.WinForms.GunaPanel pnlLeft;
        private Guna.UI2.WinForms.Guna2Button btnAdmin;
        private Guna.UI2.WinForms.Guna2Button btnIncome;
        private Guna.UI2.WinForms.Guna2Button btnWarehouse;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Button btnBills;
        private Guna.UI2.WinForms.Guna2Button btnOrders;
        private Guna.UI2.WinForms.Guna2Button btnDelieveries;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2Button btnTableList;
        private Guna.UI.WinForms.GunaCirclePictureBox pboxLogo;
        private Guna.UI.WinForms.GunaPanel pnlRight;
        private Guna.UI.WinForms.GunaControlBox ctrlMin;
        private Guna.UI.WinForms.GunaControlBox ctrlMax;
        private Guna.UI.WinForms.GunaControlBox ctrlExit;
        private Guna.UI.WinForms.GunaPanel pnlFill;
        private Guna.UI.WinForms.GunaLabel lblUsername;
        private Guna.UI.WinForms.GunaLabel lblUser;
        private Guna.UI.WinForms.GunaCircleButton btnLogout;
    }
}

