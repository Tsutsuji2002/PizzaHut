namespace PizzaHutManagement
{
    partial class frmEXExportWH
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
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnImport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.numNum = new Guna.UI.WinForms.GunaNumeric();
            this.lblGender = new Guna.UI.WinForms.GunaLabel();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtID = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtDescription = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Location = new System.Drawing.Point(299, 22);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(72, 31);
            this.btnChoose.TabIndex = 86;
            this.btnChoose.Text = "Chọn";
            this.btnChoose.UseVisualStyleBackColor = false;
            // 
            // btnImport
            // 
            this.btnImport.AnimationHoverSpeed = 0.07F;
            this.btnImport.AnimationSpeed = 0.03F;
            this.btnImport.BaseColor = System.Drawing.Color.Black;
            this.btnImport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnImport.BorderSize = 3;
            this.btnImport.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnImport.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnImport.CheckedForeColor = System.Drawing.Color.White;
            this.btnImport.CheckedImage = null;
            this.btnImport.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnImport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImport.FocusedColor = System.Drawing.Color.Empty;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.Red;
            this.btnImport.Image = null;
            this.btnImport.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImport.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnImport.Location = new System.Drawing.Point(299, 273);
            this.btnImport.Name = "btnImport";
            this.btnImport.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnImport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImport.OnHoverImage = null;
            this.btnImport.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnImport.OnPressedColor = System.Drawing.Color.Black;
            this.btnImport.Size = new System.Drawing.Size(184, 42);
            this.btnImport.TabIndex = 85;
            this.btnImport.Text = "Nhập";
            this.btnImport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numNum
            // 
            this.numNum.BaseColor = System.Drawing.Color.White;
            this.numNum.BorderColor = System.Drawing.Color.Silver;
            this.numNum.ButtonColor = System.Drawing.Color.Black;
            this.numNum.ButtonForeColor = System.Drawing.Color.White;
            this.numNum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numNum.ForeColor = System.Drawing.Color.Black;
            this.numNum.Location = new System.Drawing.Point(410, 55);
            this.numNum.Maximum = ((long)(1000));
            this.numNum.Minimum = ((long)(0));
            this.numNum.Name = "numNum";
            this.numNum.Size = new System.Drawing.Size(75, 30);
            this.numNum.TabIndex = 77;
            this.numNum.Text = "numQuantity";
            this.numNum.Value = ((long)(0));
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(410, 21);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(73, 21);
            this.lblGender.TabIndex = 76;
            this.lblGender.Text = "Số lượng";
            // 
            // txtName
            // 
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtName.Location = new System.Drawing.Point(147, 59);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(224, 32);
            this.txtName.TabIndex = 75;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(24, 67);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(103, 21);
            this.gunaLabel1.TabIndex = 74;
            this.gunaLabel1.Text = "Tên mặt hàng";
            // 
            // txtID
            // 
            this.txtID.BaseColor = System.Drawing.Color.White;
            this.txtID.BorderColor = System.Drawing.Color.Silver;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtID.Location = new System.Drawing.Point(147, 21);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(143, 32);
            this.txtID.TabIndex = 73;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.Location = new System.Drawing.Point(24, 29);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(102, 21);
            this.gunaLabel10.TabIndex = 72;
            this.gunaLabel10.Text = "Mã mặt hàng";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(25, 166);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(53, 21);
            this.gunaLabel2.TabIndex = 80;
            this.gunaLabel2.Text = "Mô tả:";
            // 
            // txtDescription
            // 
            this.txtDescription.BaseColor = System.Drawing.Color.White;
            this.txtDescription.BorderColor = System.Drawing.Color.Silver;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescription.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDescription.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtDescription.Location = new System.Drawing.Point(28, 190);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(457, 68);
            this.txtDescription.TabIndex = 81;
            // 
            // frmEXExportWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(509, 337);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.numNum);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.gunaLabel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEXExportWH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEXExportWH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoose;
        private Guna.UI.WinForms.GunaAdvenceButton btnImport;
        private Guna.UI.WinForms.GunaNumeric numNum;
        private Guna.UI.WinForms.GunaLabel lblGender;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtID;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtDescription;
    }
}