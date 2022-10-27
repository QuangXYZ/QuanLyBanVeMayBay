using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeMayBay.DTO
{

    internal class VeDTO
    {
        private String maKhachHang;
        private String maChuyenBay;
        private String maVe;
        private String hangVe;
        private long giaVe;
        
        /*
        public VeDTO(string maKhachHang, string maChuyenBay, string maVe, string hangVe, long giaVe)
        {
            this.maKhachHang = maKhachHang;
            this.maChuyenBay = maChuyenBay;
            this.maVe = maVe;
            this.hangVe = hangVe;
            this.giaVe = giaVe;
        }
        */
        public String MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public String MaChuyenBay { get => maChuyenBay;set => maChuyenBay = value; }
        public String MaVe { get => maVe; set => maVe = value; }
        public String HangVe { get => hangVe; set => hangVe = value; }
        public long GiaVe { get => GiaVe; set => giaVe = value; }




    }
}
