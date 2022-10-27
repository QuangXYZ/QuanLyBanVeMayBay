using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeMayBay.DTO
{
    internal class ChuyenBayDTO
    {
        private string maChuyenBay;
        private string sanBayDi;
        private string sanBayDen;
        private int soLuongGhe;
        private int soLuongGheHang1;
        private int soLuongGheHang2;
        private DateTime ngayBay;
        private int thoiGianBay;

        public string MaChuyenBay { get => maChuyenBay; set => maChuyenBay = value; }
        public string SanBayDi { get => sanBayDi; set => sanBayDi = value; }
        public string SanBayDen { get => sanBayDen; set => sanBayDen = value; }
        public int SoLuongGhe { get => soLuongGhe; set => soLuongGhe = value; }
        public int SoLuongGheHang1 { get => soLuongGheHang1; set => soLuongGheHang1 = value; }
        public int SoLuongGheHang2 { get => soLuongGheHang2; set => soLuongGheHang2 = value; }
        public DateTime NgayBay { get => ngayBay; set => ngayBay = value; }
        public int ThoiGianBay { get => thoiGianBay; set => thoiGianBay = value; }





    }
}
