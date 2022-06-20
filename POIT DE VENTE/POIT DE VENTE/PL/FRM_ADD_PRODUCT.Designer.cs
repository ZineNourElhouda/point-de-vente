
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtQte);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbCategories);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(540, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المنتج :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(112, 224);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(306, 25);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(424, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "سعر المنتج:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(112, 68);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(306, 25);
            this.txtRef.TabIndex = 0;
            //this.txtRef.TextChanged += new System.EventHandler(this.txtRef_TextChanged);
            this.txtRef.Validated += new System.EventHandler(this.txtRef_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(424, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "معرف المنتج:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(112, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "تحديد ملف الصورة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbox
            // 
            this.pbox.BackColor = System.Drawing.Color.DarkGray;
            this.pbox.Location = new System.Drawing.Point(112, 272);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(306, 143);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox.TabIndex = 12;
            this.pbox.TabStop = false;
            this.pbox.Click += new System.EventHandler(this.pbox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(424, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "صورة المنتج:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(112, 185);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(306, 25);
            this.txtQte.TabIndex = 2;
            this.txtQte.TextChanged += new System.EventHandler(this.txtQte_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(424, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "الكمية المخزنة:";
            this.label5.Click += new System.EventHandler(this.labe15_Click);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(112, 109);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDes.Size = new System.Drawing.Size(306, 60);
            this.txtDes.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(424, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "وصف المنتج:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(112, 29);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(306, 25);
            this.cmbCategories.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(424, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "صنف المنتج:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(163, 481);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(201)))), ((int)(((byte)(38)))));
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOk.Location = new System.Drawing.Point(13, 481);
            this.btnOk.Name = "btnOk";
            this.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOk.Size = new System.Drawing.Size(113, 35);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "موافق";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FRM_ADD_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 528);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FRM_ADD_PRODUCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox pbox;
        public System.Windows.Forms.TextBox txtRef;
        public System.Windows.Forms.TextBox txtPrice;
    }
}