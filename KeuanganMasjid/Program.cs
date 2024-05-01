using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeuanganMasjid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n Halaman Utama");
                Console.WriteLine("1. Menu Staff");
                Console.WriteLine("2. Menu Donatur");
                Console.WriteLine("3. Menu Transaksi");
                Console.WriteLine("4. Menu Kegiatan");
                Console.WriteLine("5. Menu Anggaran Kegiatan");

                Console.Write("Masukan Pilihan (1-5) : ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Staff staff = new Staff();
                        staff.Main();
                        break;
                    case "2":
                        Donatur donatur = new Donatur();
                        donatur.Main();
                        break;
                    case "3":
                        Transaksi transaksi = new Transaksi();
                        transaksi.Main();
                        break;
                    case "4":
                        Kegiatan kegiatan = new Kegiatan();
                        kegiatan.Main();
                        break;
                    case "5":
                        AnggaranKegiatan anggarankegiatan = new AnggaranKegiatan();
                        anggarankegiatan.Main();
                        break;
                    default:
                        Console.WriteLine("Pilihan Tidak Tersedia!");
                        break;
                }
            }
        }

        internal void insert(string jenisTransaksi, int jumlahTransaksi, string idStaff, string nik, SqlConnection conn)
        {
            throw new NotImplementedException();
        }
    }
}