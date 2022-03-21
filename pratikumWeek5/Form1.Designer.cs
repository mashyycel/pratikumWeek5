
namespace pratikumWeek5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbljudulOutput = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lBoxKoleksi = new System.Windows.Forms.ListBox();
            this.txtBoxData = new System.Windows.Forms.TextBox();
            this.cBoxAktif = new System.Windows.Forms.CheckBox();
            this.rBtnMerah = new System.Windows.Forms.RadioButton();
            this.rBtnBiru = new System.Windows.Forms.RadioButton();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Koleksi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Setting:";
            // 
            // lbljudulOutput
            // 
            this.lbljudulOutput.AutoSize = true;
            this.lbljudulOutput.Location = new System.Drawing.Point(553, 282);
            this.lbljudulOutput.Name = "lbljudulOutput";
            this.lbljudulOutput.Size = new System.Drawing.Size(58, 20);
            this.lbljudulOutput.TabIndex = 3;
            this.lbljudulOutput.Text = "Output:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(633, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(573, 442);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(403, 42);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lBoxKoleksi
            // 
            this.lBoxKoleksi.FormattingEnabled = true;
            this.lBoxKoleksi.ItemHeight = 20;
            this.lBoxKoleksi.Location = new System.Drawing.Point(48, 137);
            this.lBoxKoleksi.Name = "lBoxKoleksi";
            this.lBoxKoleksi.Size = new System.Drawing.Size(361, 364);
            this.lBoxKoleksi.TabIndex = 6;
            this.lBoxKoleksi.SelectedIndexChanged += new System.EventHandler(this.lBoxKoleksi_SelectedIndexChanged);
            // 
            // txtBoxData
            // 
            this.txtBoxData.Location = new System.Drawing.Point(109, 44);
            this.txtBoxData.Name = "txtBoxData";
            this.txtBoxData.Size = new System.Drawing.Size(464, 27);
            this.txtBoxData.TabIndex = 7;
            // 
            // cBoxAktif
            // 
            this.cBoxAktif.AutoSize = true;
            this.cBoxAktif.Location = new System.Drawing.Point(649, 127);
            this.cBoxAktif.Name = "cBoxAktif";
            this.cBoxAktif.Size = new System.Drawing.Size(62, 24);
            this.cBoxAktif.TabIndex = 8;
            this.cBoxAktif.Text = "Aktif";
            this.cBoxAktif.UseVisualStyleBackColor = true;
            this.cBoxAktif.CheckedChanged += new System.EventHandler(this.cBoxAktif_CheckedChanged);
            // 
            // rBtnMerah
            // 
            this.rBtnMerah.AutoSize = true;
            this.rBtnMerah.Checked = true;
            this.rBtnMerah.Location = new System.Drawing.Point(649, 170);
            this.rBtnMerah.Name = "rBtnMerah";
            this.rBtnMerah.Size = new System.Drawing.Size(118, 24);
            this.rBtnMerah.TabIndex = 9;
            this.rBtnMerah.TabStop = true;
            this.rBtnMerah.Text = "Warna Merah";
            this.rBtnMerah.UseVisualStyleBackColor = true;
            this.rBtnMerah.CheckedChanged += new System.EventHandler(this.rBtnMerah_CheckedChanged);
            // 
            // rBtnBiru
            // 
            this.rBtnBiru.AutoSize = true;
            this.rBtnBiru.Location = new System.Drawing.Point(649, 216);
            this.rBtnBiru.Name = "rBtnBiru";
            this.rBtnBiru.Size = new System.Drawing.Size(102, 24);
            this.rBtnBiru.TabIndex = 10;
            this.rBtnBiru.Text = "Warna Biru";
            this.rBtnBiru.UseVisualStyleBackColor = true;
            this.rBtnBiru.CheckedChanged += new System.EventHandler(this.rBtnBiru_CheckedChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.Location = new System.Drawing.Point(698, 327);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(151, 62);
            this.lblOutput.TabIndex = 11;
            this.lblOutput.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 572);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.rBtnBiru);
            this.Controls.Add(this.rBtnMerah);
            this.Controls.Add(this.cBoxAktif);
            this.Controls.Add(this.txtBoxData);
            this.Controls.Add(this.lBoxKoleksi);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbljudulOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbljudulOutput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lBoxKoleksi;
        private System.Windows.Forms.TextBox txtBoxData;
        private System.Windows.Forms.CheckBox cBoxAktif;
        private System.Windows.Forms.RadioButton rBtnMerah;
        private System.Windows.Forms.RadioButton rBtnBiru;
        private System.Windows.Forms.Label lblOutput;
    }
}

