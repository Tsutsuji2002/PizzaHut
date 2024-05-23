namespace PizzaHutManagement
{
    partial class frmEXBill
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
            this.pnlFill = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.cboPayment = new Guna.UI.WinForms.GunaComboBox();
            this.btnEXBill = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContain = new Guna.UI.WinForms.GunaPanel();
            this.lblTotal = new Guna.UI.WinForms.GunaLabel();
            this.lblCustomerName = new Guna.UI.WinForms.GunaLabel();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.ctrlExit = new Guna.UI.WinForms.GunaControlBox();
            this.pnlFill.SuspendLayout();
            this.pnlContain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.pnlFill.Controls.Add(this.gunaLabel2);
            this.pnlFill.Controls.Add(this.cboPayment);
            this.pnlFill.Controls.Add(this.btnEXBill);
            this.pnlFill.Controls.Add(this.pnlContain);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(400, 500);
            this.pnlFill.TabIndex = 0;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.gunaLabel2.Location = new System.Drawing.Point(12, 416);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(246, 21);
            this.gunaLabel2.TabIndex = 25;
            this.gunaLabel2.Text = "Chọn phương thức thanh toán:";
            // 
            // cboPayment
            // 
            this.cboPayment.BackColor = System.Drawing.Color.Transparent;
            this.cboPayment.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cboPayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(202)))));
            this.cboPayment.DisplayMember = "CategoryName";
            this.cboPayment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPayment.FocusedColor = System.Drawing.Color.Empty;
            this.cboPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(202)))));
            this.cboPayment.FormattingEnabled = true;
            this.cboPayment.Location = new System.Drawing.Point(12, 448);
            this.cboPayment.Name = "cboPayment";
            this.cboPayment.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboPayment.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboPayment.Size = new System.Drawing.Size(218, 30);
            this.cboPayment.TabIndex = 25;
            this.cboPayment.ValueMember = "ID";
            // 
            // btnEXBill
            // 
            this.btnEXBill.BorderRadius = 10;
            this.btnEXBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEXBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEXBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEXBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEXBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnEXBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXBill.ForeColor = System.Drawing.Color.White;
            this.btnEXBill.Location = new System.Drawing.Point(253, 440);
            this.btnEXBill.Name = "btnEXBill";
            this.btnEXBill.Size = new System.Drawing.Size(135, 48);
            this.btnEXBill.TabIndex = 17;
            this.btnEXBill.Text = "Thanh toán";
            // 
            // pnlContain
            // 
            this.pnlContain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(202)))));
            this.pnlContain.Controls.Add(this.ctrlExit);
            this.pnlContain.Controls.Add(this.lblTotal);
            this.pnlContain.Controls.Add(this.lblCustomerName);
            this.pnlContain.Controls.Add(this.lblTitle);
            this.pnlContain.Controls.Add(this.gunaLabel1);
            this.pnlContain.Controls.Add(this.lblName);
            this.pnlContain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContain.Location = new System.Drawing.Point(0, 0);
            this.pnlContain.Name = "pnlContain";
            this.pnlContain.Size = new System.Drawing.Size(400, 405);
            this.pnlContain.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblTotal.Location = new System.Drawing.Point(154, 129);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(81, 21);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "totalprice";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.Color.Blue;
            this.lblCustomerName.Location = new System.Drawing.Point(154, 95);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(50, 21);
            this.lblCustomerName.TabIndex = 23;
            this.lblCustomerName.Text = "name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTitle.Location = new System.Drawing.Point(103, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 37);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Thanh toán";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Blue;
            this.gunaLabel1.Location = new System.Drawing.Point(12, 129);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(84, 21);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Tổng tiền:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(12, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên khách hàng:";
            // 
            // ctrlExit
            // 
            this.ctrlExit.AnimationHoverSpeed = 0.07F;
            this.ctrlExit.AnimationSpeed = 0.03F;
            this.ctrlExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ctrlExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.ctrlExit.IconSize = 50F;
            this.ctrlExit.Location = new System.Drawing.Point(333, 3);
            this.ctrlExit.Name = "ctrlExit";
            this.ctrlExit.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.ctrlExit.OnHoverIconColor = System.Drawing.Color.White;
            this.ctrlExit.OnPressedColor = System.Drawing.Color.Black;
            this.ctrlExit.Size = new System.Drawing.Size(64, 27);
            this.ctrlExit.TabIndex = 3;
            // 
            // frmEXBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.pnlFill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEXBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEXBill";
            this.Load += new System.EventHandler(this.frmEXBill_Load);
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            this.pnlContain.ResumeLayout(false);
            this.pnlContain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnlFill;
        private Guna.UI.WinForms.GunaPanel pnlContain;
        private Guna.UI2.WinForms.Guna2Button btnEXBill;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI.WinForms.GunaLabel lblTotal;
        private Guna.UI.WinForms.GunaLabel lblCustomerName;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaComboBox cboPayment;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaControlBox ctrlExit;
    }
}