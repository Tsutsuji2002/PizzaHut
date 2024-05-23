namespace PizzaHutManagement
{
    partial class frmEXAddFoods
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
            this.pnlFill = new Guna.UI.WinForms.GunaShadowPanel();
            this.cboCategory = new Guna.UI.WinForms.GunaComboBox();
            this.foodCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBPizzaHutDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PizzaHutDataSet = new PizzaHutManagement.DB_PizzaHutDataSet();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.txtFind = new Guna.UI.WinForms.GunaTextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblQuantity = new Guna.UI.WinForms.GunaLabel();
            this.lblFoodName = new Guna.UI.WinForms.GunaLabel();
            this.numQuantity = new Guna.UI.WinForms.GunaNumeric();
            this.pnlView = new Guna.UI.WinForms.GunaPanel();
            this.foodCategoriesTableAdapter = new PizzaHutManagement.DB_PizzaHutDataSetTableAdapters.FoodCategoriesTableAdapter();
            this.foodCategoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPizzaHutDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PizzaHutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodCategoriesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.Color.Transparent;
            this.pnlFill.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.pnlFill.Controls.Add(this.cboCategory);
            this.pnlFill.Controls.Add(this.btnExit);
            this.pnlFill.Controls.Add(this.txtFind);
            this.pnlFill.Controls.Add(this.guna2Button1);
            this.pnlFill.Controls.Add(this.lblTitle);
            this.pnlFill.Controls.Add(this.btnSave);
            this.pnlFill.Controls.Add(this.lblQuantity);
            this.pnlFill.Controls.Add(this.lblFoodName);
            this.pnlFill.Controls.Add(this.numQuantity);
            this.pnlFill.Controls.Add(this.pnlView);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.ShadowColor = System.Drawing.Color.Black;
            this.pnlFill.Size = new System.Drawing.Size(835, 641);
            this.pnlFill.TabIndex = 0;
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.Color.Transparent;
            this.cboCategory.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cboCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(202)))));
            this.cboCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.foodCategoriesBindingSource, "ID", true));
            this.cboCategory.DataSource = this.foodCategoriesBindingSource1;
            this.cboCategory.DisplayMember = "CategoryName";
            this.cboCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(202)))));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(126, 17);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboCategory.Size = new System.Drawing.Size(218, 30);
            this.cboCategory.TabIndex = 29;
            this.cboCategory.ValueMember = "ID";
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // foodCategoriesBindingSource
            // 
            this.foodCategoriesBindingSource.DataMember = "FoodCategories";
            this.foodCategoriesBindingSource.DataSource = this.dBPizzaHutDataSetBindingSource;
            // 
            // dBPizzaHutDataSetBindingSource
            // 
            this.dBPizzaHutDataSetBindingSource.DataSource = this.dB_PizzaHutDataSet;
            this.dBPizzaHutDataSetBindingSource.Position = 0;
            // 
            // dB_PizzaHutDataSet
            // 
            this.dB_PizzaHutDataSet.DataSetName = "DB_PizzaHutDataSet";
            this.dB_PizzaHutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 10;
            this.btnExit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(731, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 48);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.txtFind.Location = new System.Drawing.Point(387, 18);
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.SelectedText = "";
            this.txtFind.Size = new System.Drawing.Size(258, 40);
            this.txtFind.TabIndex = 27;
            this.txtFind.Text = "Tìm kiếm";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(651, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(76, 48);
            this.guna2Button1.TabIndex = 26;
            this.guna2Button1.Text = "Tìm";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTitle.Location = new System.Drawing.Point(18, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 25);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Danh mục";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(742, 573);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 48);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Thêm";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblQuantity.Location = new System.Drawing.Point(598, 593);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(77, 20);
            this.lblQuantity.TabIndex = 22;
            this.lblQuantity.Text = "Số lượng :";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblFoodName.Location = new System.Drawing.Point(19, 593);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(55, 20);
            this.lblFoodName.TabIndex = 21;
            this.lblFoodName.Text = "Món ...";
            // 
            // numQuantity
            // 
            this.numQuantity.BaseColor = System.Drawing.Color.White;
            this.numQuantity.BorderColor = System.Drawing.Color.Silver;
            this.numQuantity.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.numQuantity.ButtonForeColor = System.Drawing.Color.White;
            this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numQuantity.ForeColor = System.Drawing.Color.Black;
            this.numQuantity.Location = new System.Drawing.Point(681, 583);
            this.numQuantity.Maximum = ((long)(9999999));
            this.numQuantity.Minimum = ((long)(1));
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(55, 30);
            this.numQuantity.TabIndex = 20;
            this.numQuantity.Text = "gunaNumeric1";
            this.numQuantity.Value = ((long)(1));
            // 
            // pnlView
            // 
            this.pnlView.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pnlView.AutoScroll = true;
            this.pnlView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(202)))));
            this.pnlView.Location = new System.Drawing.Point(18, 67);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(800, 500);
            this.pnlView.TabIndex = 18;
            // 
            // foodCategoriesTableAdapter
            // 
            this.foodCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // foodCategoriesBindingSource1
            // 
            this.foodCategoriesBindingSource1.DataMember = "FoodCategories";
            this.foodCategoriesBindingSource1.DataSource = this.dBPizzaHutDataSetBindingSource;
            // 
            // frmEXAddFoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 641);
            this.Controls.Add(this.pnlFill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEXAddFoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEXAddFoods";
            this.Load += new System.EventHandler(this.frmEXAddFoods_Load);
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPizzaHutDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PizzaHutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodCategoriesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel pnlFill;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI.WinForms.GunaLabel lblQuantity;
        private Guna.UI.WinForms.GunaLabel lblFoodName;
        private Guna.UI.WinForms.GunaNumeric numQuantity;
        private Guna.UI.WinForms.GunaPanel pnlView;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI.WinForms.GunaTextBox txtFind;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI.WinForms.GunaComboBox cboCategory;
        private System.Windows.Forms.BindingSource dBPizzaHutDataSetBindingSource;
        private DB_PizzaHutDataSet dB_PizzaHutDataSet;
        private System.Windows.Forms.BindingSource foodCategoriesBindingSource;
        private DB_PizzaHutDataSetTableAdapters.FoodCategoriesTableAdapter foodCategoriesTableAdapter;
        private System.Windows.Forms.BindingSource foodCategoriesBindingSource1;
    }
}