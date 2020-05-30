namespace _50UnitedMapTool
{
    partial class frmAddSector
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
            this.txtCord1 = new System.Windows.Forms.TextBox();
            this.txtCord2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlRadio2 = new System.Windows.Forms.Panel();
            this.robMinus2 = new System.Windows.Forms.RadioButton();
            this.robPlus2 = new System.Windows.Forms.RadioButton();
            this.pnlRadio1 = new System.Windows.Forms.Panel();
            this.robMinus1 = new System.Windows.Forms.RadioButton();
            this.robPlus1 = new System.Windows.Forms.RadioButton();
            this.pnlRadio2.SuspendLayout();
            this.pnlRadio1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCord1
            // 
            this.txtCord1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCord1.Location = new System.Drawing.Point(45, 20);
            this.txtCord1.Name = "txtCord1";
            this.txtCord1.Size = new System.Drawing.Size(100, 30);
            this.txtCord1.TabIndex = 1;
            // 
            // txtCord2
            // 
            this.txtCord2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCord2.Location = new System.Drawing.Point(185, 20);
            this.txtCord2.Name = "txtCord2";
            this.txtCord2.Size = new System.Drawing.Size(100, 30);
            this.txtCord2.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(129, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pnlRadio2
            // 
            this.pnlRadio2.Controls.Add(this.robMinus2);
            this.pnlRadio2.Controls.Add(this.robPlus2);
            this.pnlRadio2.Location = new System.Drawing.Point(147, 20);
            this.pnlRadio2.Name = "pnlRadio2";
            this.pnlRadio2.Size = new System.Drawing.Size(36, 30);
            this.pnlRadio2.TabIndex = 9;
            // 
            // robMinus2
            // 
            this.robMinus2.AutoSize = true;
            this.robMinus2.Location = new System.Drawing.Point(2, 15);
            this.robMinus2.Name = "robMinus2";
            this.robMinus2.Size = new System.Drawing.Size(28, 17);
            this.robMinus2.TabIndex = 1;
            this.robMinus2.Text = "-";
            this.robMinus2.UseVisualStyleBackColor = true;
            // 
            // robPlus2
            // 
            this.robPlus2.AutoSize = true;
            this.robPlus2.Checked = true;
            this.robPlus2.Location = new System.Drawing.Point(2, -1);
            this.robPlus2.Name = "robPlus2";
            this.robPlus2.Size = new System.Drawing.Size(31, 17);
            this.robPlus2.TabIndex = 0;
            this.robPlus2.TabStop = true;
            this.robPlus2.Text = "+";
            this.robPlus2.UseVisualStyleBackColor = true;
            // 
            // pnlRadio1
            // 
            this.pnlRadio1.Controls.Add(this.robMinus1);
            this.pnlRadio1.Controls.Add(this.robPlus1);
            this.pnlRadio1.Location = new System.Drawing.Point(6, 19);
            this.pnlRadio1.Name = "pnlRadio1";
            this.pnlRadio1.Size = new System.Drawing.Size(36, 33);
            this.pnlRadio1.TabIndex = 10;
            // 
            // robMinus1
            // 
            this.robMinus1.AutoSize = true;
            this.robMinus1.Location = new System.Drawing.Point(4, 16);
            this.robMinus1.Name = "robMinus1";
            this.robMinus1.Size = new System.Drawing.Size(28, 17);
            this.robMinus1.TabIndex = 1;
            this.robMinus1.Text = "-";
            this.robMinus1.UseVisualStyleBackColor = true;
            // 
            // robPlus1
            // 
            this.robPlus1.AutoSize = true;
            this.robPlus1.Checked = true;
            this.robPlus1.Location = new System.Drawing.Point(4, 0);
            this.robPlus1.Name = "robPlus1";
            this.robPlus1.Size = new System.Drawing.Size(31, 17);
            this.robPlus1.TabIndex = 0;
            this.robPlus1.TabStop = true;
            this.robPlus1.Text = "+";
            this.robPlus1.UseVisualStyleBackColor = true;
            // 
            // frmAddSector
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(294, 91);
            this.Controls.Add(this.pnlRadio1);
            this.Controls.Add(this.pnlRadio2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCord2);
            this.Controls.Add(this.txtCord1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAddSector";
            this.Text = "Add Sector";
            this.pnlRadio2.ResumeLayout(false);
            this.pnlRadio2.PerformLayout();
            this.pnlRadio1.ResumeLayout(false);
            this.pnlRadio1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCord1;
        private System.Windows.Forms.TextBox txtCord2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlRadio2;
        private System.Windows.Forms.RadioButton robMinus2;
        private System.Windows.Forms.RadioButton robPlus2;
        private System.Windows.Forms.Panel pnlRadio1;
        private System.Windows.Forms.RadioButton robMinus1;
        private System.Windows.Forms.RadioButton robPlus1;
    }
}