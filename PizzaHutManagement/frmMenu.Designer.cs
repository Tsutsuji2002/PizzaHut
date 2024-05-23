namespace PizzaHutManagement
{
    partial class frmMenu
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
            this.pnlFill = new System.Windows.Forms.Panel();
            this.txtFind = new Guna.UI.WinForms.GunaTextBox();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlter = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.cboCategory = new Guna.UI.WinForms.GunaComboBox();
            this.foodCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PizzaHutDataSet = new PizzaHutManagement.DB_PizzaHutDataSet();
            this.pnlMenu = new Guna.UI.WinForms.GunaGradient2Panel();
            this.foodCategoriesTableAdapter = new PizzaHutManagement.DB_PizzaHutDataSetTableAdapters.FoodCategoriesTableAdapter();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PizzaHutDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.pnlFill.Controls.Add(this.txtFind);
            this.pnlFill.Controls.Add(this.btnFind);
            this.pnlFill.Controls.Add(this.btnAlter);
            this.pnlFill.Controls.Add(this.btnDel);
            this.pnlFill.Controls.Add(this.btnAdd);
            this.pnlFill.Controls.Add(this.lblTitle);
            this.pnlFill.Controls.Add(this.cboCategory);
            this.pnlFill.Controls.Add(this.pnlMenu);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(1168, 722);
            this.pnlFill.TabIndex = 0;
            // 
            // txtFind
            // 
            this.txtFind.BaseColor = System.Drawing.Color.White;
            this.txtFind.BorderColor = System.Drawing.Color.Silver;
            this.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFind.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFind.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFind.Location = new System.Drawing.Point(754, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.SelectedText = "";
            this.txtFind.Size = new System.Drawing.Size(258, 40);
            this.txtFind.TabIndex = 16;
            this.txtFind.Text = "Tìm kiếm";
            // 
            // btnFind
            // 
            this.btnFind.BorderRadius = 10;
            this.btnFind.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(1029, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(135, 48);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "Tìm";
            // 
            // btnAlter
            // 
            this.btnAlter.BorderRadius = 10;
            this.btnAlter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAlter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAlter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAlter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAlter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAlter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAlter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlter.ForeColor = System.Drawing.Color.White;
            this.btnAlter.Location = new System.Drawing.Point(1029, 195);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(135, 48);
            this.btnAlter.TabIndex = 14;
            this.btnAlter.Text = "Chỉnh sửa";
            // 
            // btnDel
            // 
            this.btnDel.BorderRadius = 10;
            this.btnDel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(1029, 134);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(135, 48);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "Xóa";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1029, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 48);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm món";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTitle.Location = new System.Drawing.Point(28, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Danh mục";
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.Color.Transparent;
            this.cboCategory.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cboCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(202)))));
            this.cboCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.foodCategoriesBindingSource, "ID", true));
            this.cboCategory.DataSource = this.foodCategoriesBindingSource;
            this.cboCategory.DisplayMember = "CategoryName";
            this.cboCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(202)))));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(145, 12);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboCategory.Size = new System.Drawing.Size(218, 30);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.ValueMember = "ID";
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // foodCategoriesBindingSource
            // 
            this.foodCategoriesBindingSource.DataMember = "FoodCategories";
            this.foodCategoriesBindingSource.DataSource = this.dB_PizzaHutDataSet;
            // 
            // dB_PizzaHutDataSet
            // 
            this.dB_PizzaHutDataSet.DataSetName = "DB_PizzaHutDataSet";
            this.dB_PizzaHutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlMenu
            // 
            this.pnlMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.pnlMenu.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pnlMenu.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.pnlMenu.Location = new System.Drawing.Point(16, 67);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1000, 630);
            this.pnlMenu.TabIndex = 0;
            // 
            // foodCategoriesTableAdapter
            // 
            this.foodCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 722);
            this.Controls.Add(this.pnlFill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PizzaHutDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFill;
        private Guna.UI.WinForms.GunaComboBox cboCategory;
        private Guna.UI.WinForms.GunaGradient2Panel pnlMenu;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaTextBox txtFind;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private Guna.UI2.WinForms.Guna2Button btnAlter;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private DB_PizzaHutDataSet dB_PizzaHutDataSet;
        private System.Windows.Forms.BindingSource foodCategoriesBindingSource;
        private DB_PizzaHutDataSetTableAdapters.FoodCategoriesTableAdapter foodCategoriesTableAdapter;
    }
}