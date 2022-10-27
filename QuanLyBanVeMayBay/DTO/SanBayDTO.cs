using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeMayBay.DTO
{
    internal class SanBayDTO
    {
        private string maSanBay;
        private string tenSanBay;
        private string quocGia;

        public string MaSanBay { get => maSanBay; set => maSanBay = value; }
        public string TenSanBay { get => tenSanBay; set => tenSanBay = value; }
        public string QuocGia { get => quocGia; set => quocGia = value; }
    }
}
