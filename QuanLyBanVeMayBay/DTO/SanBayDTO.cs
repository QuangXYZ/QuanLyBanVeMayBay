using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeMayBay.DTO
{
    internal class SanBayDTO
    {
        private String maSanBay;
        private String tenSanBay;
        private String quocGia;

        public String MaSanBay { get => maSanBay; set => maSanBay = value; }
        public String TenSanBay { get => tenSanBay; set => tenSanBay = value; }
        public String QuocGia { get => quocGia; set => quocGia = value; }
    }
}
