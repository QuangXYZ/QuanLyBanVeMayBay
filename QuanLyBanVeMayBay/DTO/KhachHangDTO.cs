using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeMayBay.DTO
{
    internal class KhachHangDTO
    {
        private string maKhachHang;
        private string tenKhachHang;
        private bool gioiTinh;
        private string CMND;
        private string soDienThoai;
        private string quocTich;

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string CMNDKhachHang { get => CMND; set => CMND = value; }
        public string SDT { get => soDienThoai; set => soDienThoai = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }


    }
}
