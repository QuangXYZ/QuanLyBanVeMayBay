using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeMayBay.DTO
{
    internal class NhanVienDTO
    {
        private string maNhanVien;
        private string tenNhanVien;
        private bool gioiTinh;
        private string chucVu;
        private string CMND;
        private string soDienThoai;
        private string quocTich;


        public string MaKhachHang { get => maNhanVien; set => maNhanVien = value; }
        public string TenKhachHang { get => tenNhanVien; set => tenNhanVien = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string CMNDKhachHang { get => CMND; set => CMND = value; }
        public string SDT { get => soDienThoai; set => soDienThoai = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
    }
}
