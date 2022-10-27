using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeMayBay.DTO
{
    internal class HangVeDTO
    {
        private string maHangVe;
        private string tenHangVe;
        private int gia;

        public string MaHangVe { get => maHangVe; set => maHangVe = value; }
        public string TenHangVe { get => tenHangVe; set => tenHangVe = value; }
        public int Gia { get => gia; set => gia = value; }

    }
}
