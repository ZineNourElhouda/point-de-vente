
using System;

namespace POIT_DE_VENTE.PL
{
    partial class FRM_ADD_PRODUCT
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPicture = new System.Windows.Forms.Button();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRef);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnPicture);
            this.groupBox1.Controls.Add(this.pbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtQte);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbCategories);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(630, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المنتج :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(131, 224);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(356, 29);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyDown);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(495, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "سعر المنتج:";
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(131, 68);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(356, 29);
            this.txtRef.TabIndex = 0;
            this.txtRef.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRef_KeyDown);
            this.txtRef.Validated += new System.EventHandler(this.txtRef_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(495, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "معرف المنتج:";
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.Color.DarkGray;
            this.btnPicture.Location = new System.Drawing.Point(131, 421);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(357, 34);
            this.btnPicture.TabIndex = 4;
            this.btnPicture.Text = "تحديد ملف الصورة";
            this.btnPicture.UseVisualStyleBackColor = false;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // pbox
            // 
            this.pbox.BackColor = System.Drawing.Color.DarkGray;
            this.pbox.Location = new System.Drawing.Point(131, 272);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(357, 143);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox.TabIndex = 12;
            this.pbox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(495, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "صورة المنتج:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(131, 185);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(356, 29);
            this.txtQte.TabIndex = 2;
            this.txtQte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQte_KeyDown);
            this.txtQte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQte_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "الكمية المخزنة:";
            this.label5.Click += new System.EventHandler(this.labe15_Click);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(131, 109);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDes.Size = new System.Drawing.Size(356, 60);
            this.txtDes.TabIndex = 1;
            this.txtDes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDes_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "وصف المنتج:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(131, 29);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(356, 30);
            this.cmbCategories.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "صنف المنتج:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(190, 481);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(201)))), ((int)(((byte)(38)))));
            this.btnOk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnOk.Location = new System.Drawing.Point(15, 481);
            this.btnOk.Name = "btnOk";
            this.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOk.Size = new System.Drawing.Size(132, 35);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "موافق";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FRM_ADD_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 528);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FRM_ADD_PRODUCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "إضافة منتج جديد";
            this.Load += new System.EventHandler(this.FRM_ADD_PRODUCT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);

        }

       // private void txtRef_TextChanged(object sender, EventArgs e)
       // {
         //   throw new NotImplementedException();
        //}

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void labe15_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    



        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.ComboBox cmbCategories;
        public System.Windows.Forms.TextBox txtQte;
        public System.Windows.Forms.TextBox txtDes;
        public System.Windows.Forms.Button btnPicture;
        public System.Windows.Forms.PictureBox pbox;
        public System.Windows.Forms.TextBox txtRef;
        public System.Windows.Forms.TextBox txtPrice;
    }
}