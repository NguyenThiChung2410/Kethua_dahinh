using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class QuanLySanPham
    {
        const string _ten = "Cua hang ban le Chung Chung";
        List<SanPham> _listSP = new List<SanPham>();
        public void Nhap()
        {
            SanPham sp;
            int loaiSP;
            char choose = 'a';
            while (choose == 'a' || choose == 'A')
            {
                Console.WriteLine("Chon loai san pham(1.Socola,2.Nuoc uong):");
                loaiSP = int.Parse(Console.ReadLine());
                switch (loaiSP)
                {
                    case 1:
                        sp = new Socola();
                        sp.Nhap();
                        sp.TinhGiaBan();
                        _listSP.Add(sp);
                        break;
                    case 2:
                        sp = new NuocUong();
                        sp.Nhap();
                        sp.TinhGiaBan();
                        _listSP.Add(sp);
                        break;
                    defaut:
                        Console.WriteLine("Nhap sai mat tieu roi, hay nhap lai giup nha:");
                        break;
                }
                Console.WriteLine("Ban co muon nhap lai nua khong?(a/n)");
                choose = char.Parse(Console.ReadLine());
            }
         
        }
         public void InListSP()
        {
            Console.WriteLine(_ten+"\n*********Thong tin san pham********");
            foreach (SanPham a in _listSP)
            {
                Console.WriteLine(a.InChiTiet());
            }
        }
    }
}
