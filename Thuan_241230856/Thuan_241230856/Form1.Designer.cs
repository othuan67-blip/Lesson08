namespace Thuan_241230856
{
    internal class ChiTietMon
    {
        public string TenMon { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public string GhiChu { get; set; }
        public decimal ThanhTien => DonGia * SoLuong;

namespace QuanLyNhaHang
    {
        partial class Form1
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
                this.btnThemMon = new System.Windows.Forms.Button();
                this.lstTenMon = new System.Windows.Forms.ListBox();
                this.numSoLuong = new System.Windows.Forms.NumericUpDown();
                this.txtGhiChu = new System.Windows.Forms.TextBox();
                this.txtDonGia = new System.Windows.Forms.TextBox();
                this.radTrangMieng = new System.Windows.Forms.RadioButton();
                this.radDoUong = new System.Windows.Forms.RadioButton();
                this.radMonChinh = new System.Windows.Forms.RadioButton();
                this.cmbSoBan = new System.Windows.Forms.ComboBox();
                this.label6 = new System.Windows.Forms.Label();
                this.label5 = new System.Windows.Forms.Label();
                this.label4 = new System.Windows.Forms.Label();
                this.label3 = new System.Windows.Forms.Label();
                this.label2 = new System.Windows.Forms.Label();
                this.label1 = new System.Windows.Forms.Label();
                this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
                this.groupBox2 = new System.Windows.Forms.GroupBox();
                this.btnThoat = new System.Windows.Forms.Button();
                this.btnThanhToan = new System.Windows.Forms.Button();
                this.btnXoaMon = new System.Windows.Forms.Button();
                this.lblTongCong = new System.Windows.Forms.Label();
                this.lblVAT = new System.Windows.Forms.Label();
                this.lblPhiPhucVu = new System.Windows.Forms.CheckBox();
                this.lblTamTinh = new System.Windows.Forms.Label();
                this.textBox3 = new System.Windows.Forms.TextBox();
                this.lstHoaDon = new System.Windows.Forms.ListBox();
                this.groupBox1.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
                this.groupBox2.SuspendLayout();
                this.SuspendLayout();
                // 
                // groupBox1
                //
                this.groupBox1.Controls.Add(this.btnThemMon);
                this.groupBox1.Controls.Add(this.lstTenMon);
                this.groupBox1.Controls.Add(this.numSoLuong);
                this.groupBox1.Controls.Add(this.txtGhiChu);
                this.groupBox1.Controls.Add(this.txtDonGia);
                this.groupBox1.Controls.Add(this.radTrangMieng);
                this.groupBox1.Controls.Add(this.radDoUong);
                this.groupBox1.Controls.Add(this.radMonChinh);
                this.groupBox1.Controls.Add(this.cmbSoBan);
                this.groupBox1.Controls.Add(this.label6);
                this.groupBox1.Controls.Add(this.label5);
                this.groupBox1.Controls.Add(this.label4);
                this.groupBox1.Controls.Add(this.label3);
                this.groupBox1.Controls.Add(this.label2);
                this.groupBox1.Controls.Add(this.label1);
                this.groupBox1.Location = new System.Drawing.Point(12, 12);
                this.groupBox1.Name = "groupBox1";
                this.groupBox1.Size = new System.Drawing.Size(488, 502);
                this.groupBox1.TabIndex = 0;
                this.groupBox1.TabStop = false;
                this.groupBox1.Text = "Gọi món";
                // 
                // btnThemMon
                // 
                this.btnThemMon.Location = new System.Drawing.Point(176, 428);
                this.btnThemMon.Name = "btnThemMon";
                this.btnThemMon.Size = new System.Drawing.Size(98, 41);
                this.btnThemMon.TabIndex = 14;
                this.btnThemMon.Text = "&Thêm món";
                this.btnThemMon.UseVisualStyleBackColor = true;
                this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
                // 
                // lstTenMon
                // 
                this.lstTenMon.FormattingEnabled = true;
                this.lstTenMon.ItemHeight = 16;
                this.lstTenMon.Location = new System.Drawing.Point(115, 143);
                this.lstTenMon.Name = "lstTenMon";
                this.lstTenMon.Size = new System.Drawing.Size(209, 132);
                this.lstTenMon.TabIndex = 13;
                // 
                // numSoLuong
                // 
                this.numSoLuong.Location = new System.Drawing.Point(115, 352);
                this.numSoLuong.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
                this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
                this.numSoLuong.Name = "numSoLuong";
                this.numSoLuong.Size = new System.Drawing.Size(44, 22);
                this.numSoLuong.TabIndex = 12;
                this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
                // 
                // txtGhiChu
                // 
                this.txtGhiChu.Location = new System.Drawing.Point(115, 390);
                this.txtGhiChu.Name = "txtGhiChu";
                this.txtGhiChu.Size = new System.Drawing.Size(234, 22);
                this.txtGhiChu.TabIndex = 11;
                // 
                // txtDonGia
                // 
                this.txtDonGia.Location = new System.Drawing.Point(115, 311);
                this.txtDonGia.Name = "txtDonGia";
                this.txtDonGia.ReadOnly = true;
                this.txtDonGia.Size = new System.Drawing.Size(100, 22);
                this.txtDonGia.TabIndex = 10;
                // 
                // radTrangMieng
                // 
                this.radTrangMieng.AutoSize = true;
                this.radTrangMieng.Location = new System.Drawing.Point(379, 88);
                this.radTrangMieng.Name = "radTrangMieng";
                this.radTrangMieng.Size = new System.Drawing.Size(104, 20);
                this.radTrangMieng.TabIndex = 9;
                this.radTrangMieng.TabStop = true;
                this.radTrangMieng.Text = "Tráng miệng";
                this.radTrangMieng.UseVisualStyleBackColor = true;
                this.radTrangMieng.CheckedChanged += new System.EventHandler(this.XulyDoiNhomMon);
                // 
                // radDoUong
                // 
                this.radDoUong.AutoSize = true;
                this.radDoUong.Location = new System.Drawing.Point(246, 88);
                this.radDoUong.Name = "radDoUong";
                this.radDoUong.Size = new System.Drawing.Size(78, 20);
                this.radDoUong.TabIndex = 8;
                this.radDoUong.TabStop = true;
                this.radDoUong.Text = "Đồ uống";
                this.radDoUong.UseVisualStyleBackColor = true;
                this.radDoUong.CheckedChanged += new System.EventHandler(this.XulyDoiNhomMon);
                // 
                // radMonChinh
                // 
                this.radMonChinh.AutoSize = true;
                this.radMonChinh.Location = new System.Drawing.Point(115, 88);
                this.radMonChinh.Name = "radMonChinh";
                this.radMonChinh.Size = new System.Drawing.Size(88, 20);
                this.radMonChinh.TabIndex = 7;
                this.radMonChinh.TabStop = true;
                this.radMonChinh.Text = "Món chính";
                this.radMonChinh.UseVisualStyleBackColor = true;
                this.radMonChinh.CheckedChanged += new System.EventHandler(this.XulyDoiNhomMon);
                // 
                // cmbSoBan
                // 
                this.cmbSoBan.FormattingEnabled = true;
                this.cmbSoBan.Location = new System.Drawing.Point(115, 32);
                this.cmbSoBan.Name = "cmbSoBan";
                this.cmbSoBan.Size = new System.Drawing.Size(200, 24);
                this.cmbSoBan.TabIndex = 6;
                // 
                // label6
                // 
                this.label6.AutoSize = true;
                this.label6.Location = new System.Drawing.Point(15, 396);
                this.label6.Name = "label6";
                this.label6.Size = new System.Drawing.Size(51, 16);
                this.label6.TabIndex = 5;
                this.label6.Text = "Ghi chú";
                // 
                // label5
                // 
                this.label5.AutoSize = true;
                this.label5.Location = new System.Drawing.Point(15, 358);
                this.label5.Name = "label5";
                this.label5.Size = new System.Drawing.Size(60, 16);
                this.label5.TabIndex = 4;
                this.label5.Text = "Số lượng";
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(15, 317);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(53, 16);
                this.label4.TabIndex = 3;
                this.label4.Text = "Đơn giá";
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(15, 143);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(60, 16);
                this.label3.TabIndex = 2;
                this.label3.Text = "Tên món";
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(15, 90);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(72, 16);
                this.label2.TabIndex = 1;
                this.label2.Text = "Nhóm món";
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(15, 40);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(50, 16);
                this.label1.TabIndex = 0;
                this.label1.Text = "Số bàn";
                // 
                // groupBox2
                // 
                this.groupBox2.Controls.Add(this.btnThoat);
                this.groupBox2.Controls.Add(this.btnThanhToan);
                this.groupBox2.Controls.Add(this.btnXoaMon);
                this.groupBox2.Controls.Add(this.lblTongCong);
                this.groupBox2.Controls.Add(this.lblVAT);
                this.groupBox2.Controls.Add(this.lblPhiPhucVu);
                this.groupBox2.Controls.Add(this.lblTamTinh);
                this.groupBox2.Controls.Add(this.textBox3);
                this.groupBox2.Controls.Add(this.lstHoaDon);
                this.groupBox2.Location = new System.Drawing.Point(521, 12);
                this.groupBox2.Name = "groupBox2";
                this.groupBox2.Size = new System.Drawing.Size(481, 502);
                this.groupBox2.TabIndex = 1;
                this.groupBox2.TabStop = false;
                this.groupBox2.Text = "Hóa đơn-Bàn 05";
                // 
                // btnThoat
                // 
                this.btnThoat.Location = new System.Drawing.Point(379, 463);
                this.btnThoat.Name = "btnThoat";
                this.btnThoat.Size = new System.Drawing.Size(70, 23);
                this.btnThoat.TabIndex = 8;
                this.btnThoat.Text = "&Thoát";
                this.btnThoat.UseVisualStyleBackColor = true;
                this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
                // 
                // btnThanhToan
                //
                this.btnThanhToan.Location = new System.Drawing.Point(241, 463);
                this.btnThanhToan.Name = "btnThanhToan";
                this.btnThanhToan.Size = new System.Drawing.Size(96, 23);
                this.btnThanhToan.TabIndex = 7;
                this.btnThanhToan.Text = "&Thanh toán";
                this.btnThanhToan.UseVisualStyleBackColor = true;
                this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
                // 
                // btnXoaMon
                // 
                this.btnXoaMon.Location = new System.Drawing.Point(114, 463);
                this.btnXoaMon.Name = "btnXoaMon";
                this.btnXoaMon.Size = new System.Drawing.Size(75, 23);
                this.btnXoaMon.TabIndex = 6;
                this.btnXoaMon.Text = "&Xóa món";
                this.btnXoaMon.UseVisualStyleBackColor = true;
                this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
                // 
                // lblTongCong
                // 
                this.lblTongCong.AutoSize = true;
                this.lblTongCong.Location = new System.Drawing.Point(24, 440);
                this.lblTongCong.Name = "lblTongCong";
                this.lblTongCong.Size = new System.Drawing.Size(91, 16);
                this.lblTongCong.TabIndex = 5;
                this.lblTongCong.Text = "TỔNG CỘNG:";
                // 
                // lblVAT
                // 
                this.lblVAT.AutoSize = true;
                this.lblVAT.Location = new System.Drawing.Point(24, 396);
                this.lblVAT.Name = "lblVAT";
                this.lblVAT.Size = new System.Drawing.Size(59, 16);
                this.lblVAT.TabIndex = 4;
                this.lblVAT.Text = "VAT 8%:";
                // 
                // lblPhiPhucVu
                // 
                this.lblPhiPhucVu.AutoSize = true;
                this.lblPhiPhucVu.Location = new System.Drawing.Point(27, 354);
                this.lblPhiPhucVu.Name = "lblPhiPhucVu";
                this.lblPhiPhucVu.Size = new System.Drawing.Size(122, 20);
                this.lblPhiPhucVu.TabIndex = 3;
                this.lblPhiPhucVu.Text = "Phí phục vụ 5%:";
                this.lblPhiPhucVu.UseVisualStyleBackColor = true;
                // 
                // lblTamTinh
                // 
                this.lblTamTinh.AutoSize = true;
                this.lblTamTinh.Location = new System.Drawing.Point(24, 317);
                this.lblTamTinh.Name = "lblTamTinh";
                this.lblTamTinh.Size = new System.Drawing.Size(58, 16);
                this.lblTamTinh.TabIndex = 2;
                this.lblTamTinh.Text = "Tạm tính";
                // 
                // textBox3
                // 
                this.textBox3.Location = new System.Drawing.Point(202, 311);
                this.textBox3.Name = "textBox3";
                this.textBox3.Size = new System.Drawing.Size(100, 22);
                this.textBox3.TabIndex = 1;
                // 
                // lstHoaDon
                // 
                this.lstHoaDon.FormattingEnabled = true;
                this.lstHoaDon.ItemHeight = 16;
                this.lstHoaDon.Location = new System.Drawing.Point(6, 17);
                this.lstHoaDon.Name = "lstHoaDon";
                this.lstHoaDon.Size = new System.Drawing.Size(469, 260);
                this.lstHoaDon.TabIndex = 0;
                // 
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(1014, 526);
                this.Controls.Add(this.groupBox2);
                this.Controls.Add(this.groupBox1);
                this.Name = "Form1";
                this.Text = "Gọi món nhà hàng";
                this.Load += new System.EventHandler(this.Form1_Load);
                this.groupBox1.ResumeLayout(false);
                this.groupBox1.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
                this.groupBox2.ResumeLayout(false);
                this.groupBox2.PerformLayout();
                this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.GroupBox groupBox1;
            private System.ComponentModel.BackgroundWorker backgroundWorker1;
            private System.Windows.Forms.GroupBox groupBox2;
            private System.Windows.Forms.ListBox lstHoaDon;
            private System.Windows.Forms.RadioButton radTrangMieng;
            private System.Windows.Forms.RadioButton radDoUong;
            private System.Windows.Forms.RadioButton radMonChinh;
            private System.Windows.Forms.ComboBox cmbSoBan;
            private System.Windows.Forms.Label label6;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.NumericUpDown numSoLuong;
            private System.Windows.Forms.TextBox txtGhiChu;
            private System.Windows.Forms.TextBox txtDonGia;
            private System.Windows.Forms.Label lblTamTinh;
            private System.Windows.Forms.TextBox textBox3;
            private System.Windows.Forms.Button btnThemMon;
            private System.Windows.Forms.ListBox lstTenMon;
            private System.Windows.Forms.Label lblTongCong;
            private System.Windows.Forms.Label lblVAT;
            private System.Windows.Forms.CheckBox lblPhiPhucVu;
            private System.Windows.Forms.Button btnThoat;
            private System.Windows.Forms.Button btnThanhToan;
            private System.Windows.Forms.Button btnXoaMon;
        }
    }