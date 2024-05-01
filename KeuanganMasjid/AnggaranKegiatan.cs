using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KeuanganMasjid
{
    internal class AnggaranKegiatan
    {
        public void Main()
        {
            Program prg = new Program();
            while (true)
            {
                try
                {
                    SqlConnection conn = null;
                    string strKoneksi = "Data Source = LAPTOP-2HMGULU6\\BRILIYANLUTHFI;" +
                        "Initial Catalog = KeuanganMasjid;User ID=sa;Password=luthfi104";
                    conn = new SqlConnection(strKoneksi);
                    conn.Open();
                    Console.Clear();
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("\nMenu");
                            Console.WriteLine("1. Melihat Seluruh Data");
                            Console.WriteLine("2. Tambah Data Anggaran Kegiatan");
                            Console.WriteLine("3. Hapus Data Anggaran Kegiatan");
                            Console.WriteLine("4. Edit Data Anggaran Kegiatan");
                            Console.WriteLine("5. Cari Data Anggaran Kegiatan");
                            Console.WriteLine("6. Keluar");
                            Console.WriteLine("\n Enter your choice (1-6): ");
                            char ch = Convert.ToChar(Console.ReadLine());
                            switch (ch)
                            {
                                case '1':
                                    Console.Clear();
                                    Console.WriteLine("Data Anggaran Kegiatan\n");
                                    Console.WriteLine();
                                    ReadAnggaranKegiatan(conn);
                                    break;
                                case '2':
                                    Console.Clear();
                                    Console.WriteLine("Input Data Anggaran Kegiatan\n");
                                    Console.WriteLine("Masukkan Nama Kegiatan: ");
                                    string namaKegiatan = Console.ReadLine();
                                    Console.WriteLine("Masukkan Jumlah Pengeluaran: ");
                                    int jumlahPengeluaran = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Masukkan ID Staff: ");
                                    string idStaff = Console.ReadLine();
                                    Console.WriteLine("Masukkan Kode Kegiatan: ");
                                    string kdKegiatan = Console.ReadLine();

                                    Console.WriteLine("VALIDATION\n");
                                    Console.WriteLine("1. SAVE");
                                    Console.WriteLine("2. CANCEL\n");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("3. BACK");
                                    Console.ResetColor();
                                    Console.Write("\nEnter your choice (1-3): ");

                                    char ch1 = Convert.ToChar(Console.ReadLine());
                                    Console.Clear();
                                    switch (ch1)
                                    {
                                        case '1':
                                            {
                                                try
                                                {
                                                    InsertAnggaranKegiatan(namaKegiatan, jumlahPengeluaran, idStaff, kdKegiatan, conn);
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("\nAnda tidak memiliki " +
                                                "akses untuk menambah data");
                                                }
                                                break;
                                            }
                                        case '2':
                                            {
                                                Console.Clear();
                                                break;
                                            }
                                        case '3':
                                            {
                                                Console.Clear();
                                                break;
                                            }
                                        default:
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nInvalid option");
                                                Console.ResetColor();
                                            }
                                            break;
                                    }
                                    if (ch1 == '3')
                                    {
                                        Console.Clear();
                                        break;
                                    }
                                    if (ch1 == '1')
                                    {
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    }
                                    break;

                                case '3':
                                    Console.Clear();

                                    ReadAnggaranKegiatan(conn);

                                    Console.WriteLine("Masukkan Kode Anggaran Kegiatan yang ingin dihapus:\n");
                                    string kodeHapus = Console.ReadLine();


                                    Console.WriteLine("VALIDATION\n");
                                    Console.WriteLine("1. DELETE");
                                    Console.WriteLine("2. CANCEL\n");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("3. BACK");
                                    Console.ResetColor();
                                    Console.Write("\nEnter your choice (1-3): ");

                                    char ch2 = Convert.ToChar(Console.ReadLine());
                                    Console.Clear();
                                    switch (ch2)
                                    {
                                        case '1':
                                            {
                                                try
                                                {
                                                    DeleteAnggaranKegiatan(kodeHapus, conn);
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("\nAnda tidak memiliki " +
                                                "akses untuk menghapus data");
                                                }
                                                break;
                                            }
                                        case '2':
                                            {
                                                Console.Clear();
                                                break;
                                            }
                                        case '3':
                                            {
                                                Console.Clear();
                                                break;
                                            }
                                        default:
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nInvalid option");
                                                Console.ResetColor();
                                            }
                                            break;
                                    }
                                    if (ch2 == '3')
                                    {
                                        Console.Clear();
                                        break;
                                    }
                                    if (ch2 == '1')
                                    {
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    }
                                    break;
                                case '4':
                                    Console.Clear();

                                    Console.WriteLine("List data yang sudah diinput");

                                    ReadAnggaranKegiatan(conn);

                                    Console.WriteLine("Update Data Anggaran Kegiatan\n");
                                    Console.WriteLine("Masukkan Kode Anggaran Kegiatan yang akan diupdate: ");
                                    string kodeToUpdate = Console.ReadLine();
                                    Console.WriteLine("Masukkan data baru\n");
                                    Console.WriteLine("Masukkan Nama Kegiatan Baru: ");
                                    string newNamaKegiatan = Console.ReadLine();
                                    Console.WriteLine("Masukkan Jumlah Pengeluaran Baru: ");
                                    int newJumlahPengeluaran = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Masukkan ID Staff Baru: ");
                                    string newIdStaff = Console.ReadLine();
                                    Console.WriteLine("Masukkan Kode Kegiatan Baru: ");
                                    string newKdKegiatan = Console.ReadLine();


                                    Console.WriteLine("VALIDATION\n");
                                    Console.WriteLine("1. UPDATE");
                                    Console.WriteLine("2. CANCEL\n");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("3. BACK");
                                    Console.ResetColor();
                                    Console.Write("\nEnter your choice (1-3): ");

                                    char ch3 = Convert.ToChar(Console.ReadLine());
                                    Console.Clear();
                                    switch (ch3)
                                    {
                                        case '1':
                                            {
                                                try
                                                {
                                                    UpdateAnggaranKegiatan(kodeToUpdate, newNamaKegiatan, newJumlahPengeluaran, newIdStaff, newKdKegiatan, conn);
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("\nAnda tidak memiliki " +
                                                "akses untuk mengubah data");
                                                }
                                                break;
                                            }
                                        case '2':
                                            {
                                                Console.Clear();
                                                break;
                                            }
                                        case '3':
                                            {
                                                Console.Clear();
                                                break;
                                            }
                                        default:
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nInvalid option");
                                                Console.ResetColor();
                                            }
                                            break;
                                    }
                                    if (ch3 == '3')
                                    {
                                        Console.Clear();
                                        break;
                                    }
                                    if (ch3 == '1')
                                    {
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    }
                                    break;
                                case '5':
                                    Console.Clear();
                                    Console.WriteLine("Cari Data Anggaran Kegiatan Berdasarkan Kode Anggaran Kegiatan\n");
                                    Console.WriteLine("Masukkan Kode Anggaran Kegiatan yang ingin dicari: ");
                                    string searchKode = Console.ReadLine();
                                    try
                                    {
                                        SearchByAnggaranKegiatanCode(searchKode, conn);
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("\nTerjadi kesalahan dalam pencarian data: " + e.Message);
                                    }
                                    break;
                                case '6':
                                    conn.Close();
                                    Console.Clear();
                                    return;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("\n Invalid option");
                                    break;
                            }
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("\nCheck for the value entered");
                        }
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tidak Dapat Mengakses Database Tersebut\n");
                    Console.ResetColor();
                }
            }
        }

        public void ReadAnggaranKegiatan(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("SELECT Kd_Anggaran, Nama_Kegiatan, Jumlah_Pengeluaran, Id_Staff, Kd_Kegiatan FROM AnggaranKegiatan", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }

        public void InsertAnggaranKegiatan(string namaKegiatan, int jumlahPengeluaran, string idStaff, string kdKegiatan, SqlConnection conn)
        {
            if (string.IsNullOrWhiteSpace(namaKegiatan) || string.IsNullOrWhiteSpace(idStaff) || string.IsNullOrWhiteSpace(kdKegiatan))
            {
                Console.WriteLine("Semua data harus terisi. Gagal melakukan insert data.");
                return;
            }
            if (!IsAllDigits(idStaff))
            {
                Console.WriteLine("ID hanya boleh berisi angka. Gagal menambahkan data.");
                return;
            }
            if (!IsAllDigits(kdKegiatan))
            {
                Console.WriteLine("Kode hanya boleh berisi angka. Gagal menambahkan data.");
                return;
            }

            string str = "INSERT INTO AnggaranKegiatan (Nama_Kegiatan, Jumlah_Pengeluaran, Id_Staff, Kd_Kegiatan)" +
                "VALUES (@namaKegiatan, @jumlahPengeluaran, @idStaff, @kdKegiatan)";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@namaKegiatan", namaKegiatan);
            cmd.Parameters.AddWithValue("@jumlahPengeluaran", jumlahPengeluaran);
            cmd.Parameters.AddWithValue("@idStaff", idStaff);
            cmd.Parameters.AddWithValue("@kdKegiatan", kdKegiatan);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Ditambahkan");

        }
        private bool IsAllDigits(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public void DeleteAnggaranKegiatan(string kodeAnggaran, SqlConnection con)
        {
            string str = "DELETE FROM AnggaranKegiatan WHERE Kd_Anggaran = @kodeAnggaran";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@kodeAnggaran", kodeAnggaran);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Dihapus");
        }

        public void UpdateAnggaranKegiatan(string kodeAnggaran, string newNamaKegiatan, int newJumlahPengeluaran, string newIdStaff, string newKdKegiatan, SqlConnection con)
        {
            string updateQuery = "UPDATE AnggaranKegiatan SET ";
            List<string> updates = new List<string>();

            if (!string.IsNullOrEmpty(newNamaKegiatan))
            {
                updates.Add("Nama_Kegiatan = @NewNamaKegiatan");
            }
            if (newJumlahPengeluaran != 0)
            {
                updates.Add("Jumlah_Pengeluaran = @NewJumlahPengeluaran");
            }
            if (!string.IsNullOrEmpty(newIdStaff))
            {
                updates.Add("Id_Staff = @NewIdStaff");
            }
            if (!string.IsNullOrEmpty(newKdKegiatan))
            {
                updates.Add("Kd_Kegiatan = @NewKdKegiatan");
            }

            updateQuery += string.Join(", ", updates);

            updateQuery += " WHERE Kd_Anggaran = @kodeAnggaran";

            SqlCommand command = new SqlCommand(updateQuery, con);

            if (!string.IsNullOrEmpty(newNamaKegiatan))
            {
                command.Parameters.Add("@NewNamaKegiatan", SqlDbType.NVarChar).Value = newNamaKegiatan;
            }
            if (newJumlahPengeluaran != 0)
            {
                command.Parameters.Add("@NewJumlahPengeluaran", SqlDbType.Int).Value = newJumlahPengeluaran;
            }
            if (!string.IsNullOrEmpty(newIdStaff))
            {
                command.Parameters.Add("@NewIdStaff", SqlDbType.Char, 16).Value = newIdStaff;
            }
            if (!string.IsNullOrEmpty(newKdKegiatan))
            {
                command.Parameters.Add("@NewKdKegiatan", SqlDbType.Char, 4).Value = newKdKegiatan;
            }

            command.Parameters.Add("@kodeAnggaran", SqlDbType.Char, 5).Value = kodeAnggaran;

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Console.WriteLine("Data berhasil diupdate.");
            }
            else
            {
                Console.WriteLine("Data tidak ditemukan atau gagal diupdate.");
            }
        }

        public void SearchByAnggaranKegiatanCode(string kodeAnggaran, SqlConnection con)
        {
            string query = "SELECT * FROM AnggaranKegiatan WHERE Kd_Anggaran = @kodeAnggaran";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@kodeAnggaran", kodeAnggaran);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Console.WriteLine("Hasil Pencarian:\n");
                while (reader.Read())
                {
                    Console.WriteLine($"Kode Anggaran: {reader["Kd_Anggaran"]}, Nama Kegiatan: {reader["Nama_Kegiatan"]}, Jumlah Pengeluaran: {reader["Jumlah_Pengeluaran"]}, ID Staff: {reader["Id_Staff"]}, Kode Kegiatan: {reader["Kd_Kegiatan"]}");
                }
            }
            else
            {
                Console.WriteLine("Data tidak ditemukan.");
            }

            reader.Close();
        }
    }
}
