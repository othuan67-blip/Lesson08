using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace QuanLyNhaHang
{
    public partial class Form1 : Form
    {

        Dictionary<string, decimal> dictMonChinh = new Dictionary<string, decimal>();
        Dictionary<string, decimal> dictDoUong = new Dictionary<string, decimal>();
        Dictionary<string, decimal> dictTrangMieng = new Dictionary<string, decimal>();

        class ChiTietMon
        {
            public string TenMon { get; set; }
            public decimal DonGia { get; set; }
            public int SoLuong { get; set; }
            public string GhiChu { get; set; }
            public decimal ThanhTien => DonGia * SoLuong;


            public override string ToString()
            {
                string txtGhiChu = string.IsNullOrEmpty(GhiChu) ? "" : $" ({GhiChu})";
                return $"{TenMon} x {SoLuong} = {ThanhTien:N0}{txtGhiChu}";
            }
        }


        List<ChiTietMon> danhSachOrder = new List<ChiTietMon>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 20; i++)
            {
                cmbSoBan.Items.Add(i < 10 ? $"Bàn 0{i}" : $"Bàn {i}");
            }


            numSoLuong.Minimum = 1;
            numSoLuong.Maximum = 20;
            txtDonGia.ReadOnly = true;


            dictMonChinh.Add("Phở bò", 50000);
            dictMonChinh.Add("Bún chả", 55000);
            dictMonChinh.Add("Com rang", 60000);
            dictMonChinh.Add("Nem Chua", 45000);

            dictDoUong.Add("Coca", 5000);
            dictDoUong.Add("Pepsi", 30000);
            dictDoUong.Add("Sting", 25000);
            dictDoUong.Add("Trà đá", 20000);

            dictTrangMieng.Add("Chè", 35000);
            dictTrangMieng.Add("Bánh flan", 25000);
            dictTrangMieng.Add("Bánh chuối", 40000);

            radMonChinh.Checked = true;
        }


        private void CapNhatHoaDon()
        {
            lstHoaDon.Items.Clear();
            decimal tamTinh = 0;


            foreach (var item in danhSachOrder)
            {
                lstHoaDon.Items.Add(item.ToString());
                tamTinh += item.ThanhTien;
            }


            decimal phiPhucVu = lblPhiPhucVu.Checked ? tamTinh * 0.05m : 0;
            decimal vat = (tamTinh + phiPhucVu) * 0.08m;
            decimal tongCong = tamTinh + phiPhucVu + vat;


            lblTamTinh.Text = tamTinh.ToString("N0");
            lblPhiPhucVu.Text = phiPhucVu.ToString("N0");
            lblVAT.Text = vat.ToString("N0");
            lblTongCong.Text = tongCong.ToString("N0");
        }


        private decimal LayDonGia(string tenMon)
        {
            if (dictMonChinh.ContainsKey(tenMon)) return dictMonChinh[tenMon];
            if (dictDoUong.ContainsKey(tenMon)) return dictDoUong[tenMon];
            if (dictTrangMieng.ContainsKey(tenMon)) return dictTrangMieng[tenMon];
            return 0;
        }


        private void XulyDoiNhomMon(object sender, EventArgs e)
        {
            lstTenMon.Items.Clear();
            txtDonGia.Clear();

            if (radMonChinh.Checked)
            {
                foreach (var mon in dictMonChinh.Keys) lstTenMon.Items.Add(mon);
            }
            else if (radDoUong.Checked)
            {
                foreach (var mon in dictDoUong.Keys) lstTenMon.Items.Add(mon);
            }
            else if (radTrangMieng.Checked)
            {
                foreach (var mon in dictTrangMieng.Keys) lstTenMon.Items.Add(mon);
            }
        }

        private void lstTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTenMon.SelectedIndex != -1)
            {
                string monChon = lstTenMon.SelectedItem.ToString();
                txtDonGia.Text = LayDonGia(monChon).ToString("N0");
            }
        }


        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (cmbSoBan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn số bàn trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lstTenMon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenMon = lstTenMon.SelectedItem.ToString();
            decimal donGia = LayDonGia(tenMon);
            int soLuong = (int)numSoLuong.Value;
            string ghiChu = txtGhiChu.Text.Trim();


            var monDaCo = danhSachOrder.FirstOrDefault(m => m.TenMon == tenMon);

            if (monDaCo != null)
            {

                monDaCo.SoLuong += soLuong;

                if (!string.IsNullOrEmpty(ghiChu)) monDaCo.GhiChu = ghiChu;
            }
            else
            {

                danhSachOrder.Add(new ChiTietMon
                {
                    TenMon = tenMon,
                    DonGia = donGia,
                    SoLuong = soLuong,
                    GhiChu = ghiChu
                });
            }

            CapNhatHoaDon();
        }


        private void chkPhiPhucVu_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatHoaDon();
        }


        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (lstHoaDon.SelectedIndex != -1)
            {

                danhSachOrder.RemoveAt(lstHoaDon.SelectedIndex);
                CapNhatHoaDon();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món trong hóa đơn để xóa!", "Thông báo");
            }
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (danhSachOrder.Count == 0)
            {
                MessageBox.Show("Hóa đơn đang rỗng, không thể thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string input = Interaction.InputBox("Nhập số tiền khách đưa (VNĐ):", "Thanh Toán Hóa Đơn", "0");

            if (decimal.TryParse(input, out decimal tienKhach))
            {

                decimal tongCong = decimal.Parse(lblTongCong.Text.Replace(",", "").Replace(".", ""));

                if (tienKhach >= tongCong)
                {
                    decimal tienThua = tienKhach - tongCong;
                    MessageBox.Show($"Thanh toán thành công!\nSố tiền trả lại khách: {tienThua:N0} VNĐ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    danhSachOrder.Clear();
                    CapNhatHoaDon();
                    txtGhiChu.Clear();
                    numSoLuong.Value = 1;
                }
                else
                {
                    MessageBox.Show("Số tiền khách đưa nhỏ hơn tổng tiền hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}