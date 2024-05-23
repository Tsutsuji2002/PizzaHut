namespace PizzaHutManagement
{
    partial class TableWidget
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
            this.pnlTable = new Guna.UI.WinForms.GunaShadowPanel();
            this.pboIcon = new Guna.UI.WinForms.GunaPictureBox();
            this.lblPPnum = new Guna.UI.WinForms.GunaLabel();
            this.lblStatus = new Guna.UI.WinForms.GunaLabel();
            this.lblTableName = new Guna.UI.WinForms.GunaLabel();
            this.btnTable = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTable
            // 
            this.pnlTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(202)))));
            this.pnlTable.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.pnlTable.Controls.Add(this.pboIcon);
            this.pnlTable.Controls.Add(this.lblPPnum);
            this.pnlTable.Controls.Add(this.lblStatus);
            this.pnlTable.Controls.Add(this.lblTableName);
            this.pnlTable.Controls.Add(this.btnTable);
            this.pnlTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTable.Location = new System.Drawing.Point(0, 0);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.ShadowColor = System.Drawing.Color.Bisque;
            this.pnlTable.Size = new System.Drawing.Size(170, 150);
            this.pnlTable.TabIndex = 0;
            // 
            // pboIcon
            // 
            this.pboIcon.BackColor = System.Drawing.Color.Transparent;
            this.pboIcon.BaseColor = System.Drawing.Color.White;
            this.pboIcon.Image = global::PizzaHutManagement.Properties.Resources.user_icon_icons_com_57997;
            this.pboIcon.Location = new System.Drawing.Point(122, 124);
            this.pboIcon.Name = "pboIcon";
            this.pboIcon.Size = new System.Drawing.Size(18, 21);
            this.pboIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboIcon.TabIndex = 5;
            this.pboIcon.TabStop = false;
            // 
            // lblPPnum
            // 
            this.lblPPnum.AutoSize = true;
            this.lblPPnum.BackColor = System.Drawing.Color.Transparent;
            this.lblPPnum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPPnum.Location = new System.Drawing.Point(142, 124);
            this.lblPPnum.Name = "lblPPnum";
            this.lblPPnum.Size = new System.Drawing.Size(28, 21);
            this.lblPPnum.TabIndex = 3;
            this.lblPPnum.Text = "x0";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoEllipsis = true;
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblStatus.Location = new System.Drawing.Point(12, 54);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 30);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Trống";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.BackColor = System.Drawing.Color.Transparent;
            this.lblTableName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(202)))));
            this.lblTableName.Location = new System.Drawing.Point(9, 9);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(73, 21);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "Bàn số 1";
            // 
            // btnTable
            // 
            this.btnTable.AnimationHoverSpeed = 0.07F;
            this.btnTable.AnimationSpeed = 0.03F;
            this.btnTable.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.btnTable.BorderColor = System.Drawing.Color.Black;
            this.btnTable.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTable.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTable.CheckedForeColor = System.Drawing.Color.White;
            this.btnTable.CheckedImage = null;
            this.btnTable.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnTable.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTable.FocusedColor = System.Drawing.Color.Empty;
            this.btnTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTable.ForeColor = System.Drawing.Color.White;
            this.btnTable.Image = null;
            this.btnTable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTable.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTable.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTable.Location = new System.Drawing.Point(0, 0);
            this.btnTable.Name = "btnTable";
            this.btnTable.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnTable.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTable.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTable.OnHoverImage = null;
            this.btnTable.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTable.OnPressedColor = System.Drawing.Color.Black;
            this.btnTable.Size = new System.Drawing.Size(170, 150);
            this.btnTable.TabIndex = 4;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // TableWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.Controls.Add(this.pnlTable);
            this.Name = "TableWidget";
            this.Size = new System.Drawing.Size(170, 150);
            this.pnlTable.ResumeLayout(false);
            this.pnlTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel pnlTable;
        private Guna.UI.WinForms.GunaLabel lblStatus;
        private Guna.UI.WinForms.GunaLabel lblTableName;
        private Guna.UI.WinForms.GunaLabel lblPPnum;
        private Guna.UI.WinForms.GunaAdvenceButton btnTable;
        private Guna.UI.WinForms.GunaPictureBox pboIcon;
    }
}
