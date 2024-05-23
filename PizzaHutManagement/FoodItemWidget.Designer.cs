namespace PizzaHutManagement
{
    partial class FoodItemWidget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlFItem = new Guna.UI.WinForms.GunaPanel();
            this.cboSizePrice = new Guna.UI.WinForms.GunaComboBox();
            this.pboFItem = new Guna.UI.WinForms.GunaPictureBox();
            this.btnFoodName = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnlFItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFItem
            // 
            this.pnlFItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(202)))));
            this.pnlFItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFItem.Controls.Add(this.btnFoodName);
            this.pnlFItem.Controls.Add(this.cboSizePrice);
            this.pnlFItem.Controls.Add(this.pboFItem);
            this.pnlFItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFItem.Location = new System.Drawing.Point(0, 0);
            this.pnlFItem.Name = "pnlFItem";
            this.pnlFItem.Size = new System.Drawing.Size(190, 200);
            this.pnlFItem.TabIndex = 0;
            // 
            // cboSizePrice
            // 
            this.cboSizePrice.BackColor = System.Drawing.Color.Transparent;
            this.cboSizePrice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cboSizePrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(202)))));
            this.cboSizePrice.DisplayMember = "CategoryName";
            this.cboSizePrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboSizePrice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSizePrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSizePrice.FocusedColor = System.Drawing.Color.Empty;
            this.cboSizePrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSizePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(202)))));
            this.cboSizePrice.FormattingEnabled = true;
            this.cboSizePrice.Location = new System.Drawing.Point(0, 168);
            this.cboSizePrice.Name = "cboSizePrice";
            this.cboSizePrice.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboSizePrice.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboSizePrice.Size = new System.Drawing.Size(188, 30);
            this.cboSizePrice.TabIndex = 2;
            this.cboSizePrice.ValueMember = "CategoryName";
            // 
            // pboFItem
            // 
            this.pboFItem.BackColor = System.Drawing.Color.White;
            this.pboFItem.BaseColor = System.Drawing.Color.White;
            this.pboFItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pboFItem.Location = new System.Drawing.Point(0, 0);
            this.pboFItem.Name = "pboFItem";
            this.pboFItem.Size = new System.Drawing.Size(188, 120);
            this.pboFItem.TabIndex = 0;
            this.pboFItem.TabStop = false;
            // 
            // btnFoodName
            // 
            this.btnFoodName.AnimationHoverSpeed = 0.07F;
            this.btnFoodName.AnimationSpeed = 0.03F;
            this.btnFoodName.BaseColor = System.Drawing.Color.Empty;
            this.btnFoodName.BorderColor = System.Drawing.Color.Black;
            this.btnFoodName.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnFoodName.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnFoodName.CheckedForeColor = System.Drawing.Color.White;
            this.btnFoodName.CheckedImage = null;
            this.btnFoodName.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnFoodName.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFoodName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFoodName.FocusedColor = System.Drawing.Color.Empty;
            this.btnFoodName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnFoodName.Image = null;
            this.btnFoodName.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFoodName.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFoodName.Location = new System.Drawing.Point(0, 120);
            this.btnFoodName.Name = "btnFoodName";
            this.btnFoodName.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFoodName.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFoodName.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFoodName.OnHoverImage = null;
            this.btnFoodName.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnFoodName.OnPressedColor = System.Drawing.Color.Black;
            this.btnFoodName.Size = new System.Drawing.Size(188, 48);
            this.btnFoodName.TabIndex = 3;
            this.btnFoodName.Text = "FoodName";
            this.btnFoodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FoodItemWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlFItem);
            this.Name = "FoodItemWidget";
            this.Size = new System.Drawing.Size(190, 200);
            this.pnlFItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboFItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnlFItem;
        private Guna.UI.WinForms.GunaPictureBox pboFItem;
        private Guna.UI.WinForms.GunaComboBox cboSizePrice;
        private Guna.UI.WinForms.GunaAdvenceButton btnFoodName;
    }
}
