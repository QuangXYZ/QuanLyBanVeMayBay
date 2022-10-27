using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeMayBay.DTO
{
    internal class MayBayDTO
    {
        private string maMayBay;
        private string tenMayBay;
        private string loai;
        private int soGhe;

        public string MaMayBay { get => maMayBay; set => maMayBay = value; }
        public string TenMayBay { get => tenMayBay; set => tenMayBay = value; }
        public string Loai { get => loai; set => loai = value; }
        public int SoGhe { get => soGhe; set => soGhe = value; }
        
    }
}
