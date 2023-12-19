namespace NguyenVanNguyen_2180606793
{
    partial class FrmNguyenVanNguyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTong = new System.Windows.Forms.RadioButton();
            this.rdbTich = new System.Windows.Forms.RadioButton();
            this.rdbChan = new System.Windows.Forms.RadioButton();
            this.rdbChiaHet2va3 = new System.Windows.Forms.RadioButton();
            this.rdbLietkeSnt = new System.Windows.Forms.RadioButton();
            this.rdbLietkeSCP = new System.Windows.Forms.RadioButton();
            this.rdbDemSNT = new System.Windows.Forms.RadioButton();
            this.rdbDemSCP = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(326, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program WF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập n:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(123, 69);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(141, 22);
            this.txtN.TabIndex = 2;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(123, 124);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(141, 22);
            this.txtM.TabIndex = 4;
            this.txtM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtM_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập n:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.ForeColor = System.Drawing.Color.Red;
            this.txtKetQua.Location = new System.Drawing.Point(123, 183);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(385, 70);
            this.txtKetQua.TabIndex = 6;
            this.txtKetQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "kết quả";
            // 
            // btnGiai
            // 
            this.btnGiai.Location = new System.Drawing.Point(63, 274);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(115, 51);
            this.btnGiai.TabIndex = 7;
            this.btnGiai.Text = "Giai";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(201, 274);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 51);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(341, 274);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(115, 51);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDemSCP);
            this.groupBox1.Controls.Add(this.rdbDemSNT);
            this.groupBox1.Controls.Add(this.rdbLietkeSCP);
            this.groupBox1.Controls.Add(this.rdbLietkeSnt);
            this.groupBox1.Controls.Add(this.rdbChiaHet2va3);
            this.groupBox1.Controls.Add(this.rdbChan);
            this.groupBox1.Controls.Add(this.rdbTich);
            this.groupBox1.Controls.Add(this.rdbTong);
            this.groupBox1.Location = new System.Drawing.Point(559, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 342);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // rdbTong
            // 
            this.rdbTong.AutoSize = true;
            this.rdbTong.Location = new System.Drawing.Point(23, 27);
            this.rdbTong.Name = "rdbTong";
            this.rdbTong.Size = new System.Drawing.Size(104, 20);
            this.rdbTong.TabIndex = 0;
            this.rdbTong.TabStop = true;
            this.rdbTong.Text = "Tổng dãy số";
            this.rdbTong.UseVisualStyleBackColor = true;
            // 
            // rdbTich
            // 
            this.rdbTich.AutoSize = true;
            this.rdbTich.Location = new System.Drawing.Point(23, 64);
            this.rdbTich.Name = "rdbTich";
            this.rdbTich.Size = new System.Drawing.Size(98, 20);
            this.rdbTich.TabIndex = 1;
            this.rdbTich.TabStop = true;
            this.rdbTich.Text = "Tích dãy số";
            this.rdbTich.UseVisualStyleBackColor = true;
            // 
            // rdbChan
            // 
            this.rdbChan.AutoSize = true;
            this.rdbChan.Location = new System.Drawing.Point(23, 100);
            this.rdbChan.Name = "rdbChan";
            this.rdbChan.Size = new System.Drawing.Size(117, 20);
            this.rdbChan.TabIndex = 2;
            this.rdbChan.TabStop = true;
            this.rdbChan.Text = "Liệt kê số chẵn";
            this.rdbChan.UseVisualStyleBackColor = true;
            // 
            // rdbChiaHet2va3
            // 
            this.rdbChiaHet2va3.AutoSize = true;
            this.rdbChiaHet2va3.Location = new System.Drawing.Point(23, 142);
            this.rdbChiaHet2va3.Name = "rdbChiaHet2va3";
            this.rdbChiaHet2va3.Size = new System.Drawing.Size(179, 20);
            this.rdbChiaHet2va3.TabIndex = 3;
            this.rdbChiaHet2va3.TabStop = true;
            this.rdbChiaHet2va3.Text = "Liệt kê số chia hết cho 2,3";
            this.rdbChiaHet2va3.UseVisualStyleBackColor = true;
            // 
            // rdbLietkeSnt
            // 
            this.rdbLietkeSnt.AutoSize = true;
            this.rdbLietkeSnt.Location = new System.Drawing.Point(23, 178);
            this.rdbLietkeSnt.Name = "rdbLietkeSnt";
            this.rdbLietkeSnt.Size = new System.Drawing.Size(146, 20);
            this.rdbLietkeSnt.TabIndex = 4;
            this.rdbLietkeSnt.TabStop = true;
            this.rdbLietkeSnt.Text = "Liệt kê số nguyên tô";
            this.rdbLietkeSnt.UseVisualStyleBackColor = true;
            // 
            // rdbLietkeSCP
            // 
            this.rdbLietkeSCP.AutoSize = true;
            this.rdbLietkeSCP.Location = new System.Drawing.Point(23, 221);
            this.rdbLietkeSCP.Name = "rdbLietkeSCP";
            this.rdbLietkeSCP.Size = new System.Drawing.Size(167, 20);
            this.rdbLietkeSCP.TabIndex = 5;
            this.rdbLietkeSCP.TabStop = true;
            this.rdbLietkeSCP.Text = "Liệt kê số chính phương";
            this.rdbLietkeSCP.UseVisualStyleBackColor = true;
            // 
            // rdbDemSNT
            // 
            this.rdbDemSNT.AutoSize = true;
            this.rdbDemSNT.Location = new System.Drawing.Point(23, 262);
            this.rdbDemSNT.Name = "rdbDemSNT";
            this.rdbDemSNT.Size = new System.Drawing.Size(117, 20);
            this.rdbDemSNT.TabIndex = 6;
            this.rdbDemSNT.TabStop = true;
            this.rdbDemSNT.Text = "Đếm nguyên tố";
            this.rdbDemSNT.UseVisualStyleBackColor = true;
            // 
            // rdbDemSCP
            // 
            this.rdbDemSCP.AutoSize = true;
            this.rdbDemSCP.Location = new System.Drawing.Point(23, 304);
            this.rdbDemSCP.Name = "rdbDemSCP";
            this.rdbDemSCP.Size = new System.Drawing.Size(138, 20);
            this.rdbDemSCP.TabIndex = 7;
            this.rdbDemSCP.TabStop = true;
            this.rdbDemSCP.Text = "Đếm chính phương";
            this.rdbDemSCP.UseVisualStyleBackColor = true;
            // 
            // FrmNguyenVanNguyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 597);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNguyenVanNguyen";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDemSCP;
        private System.Windows.Forms.RadioButton rdbDemSNT;
        private System.Windows.Forms.RadioButton rdbLietkeSCP;
        private System.Windows.Forms.RadioButton rdbLietkeSnt;
        private System.Windows.Forms.RadioButton rdbChiaHet2va3;
        private System.Windows.Forms.RadioButton rdbChan;
        private System.Windows.Forms.RadioButton rdbTich;
        private System.Windows.Forms.RadioButton rdbTong;
    }
}

