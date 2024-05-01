using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KeuanganMasjid
{
    internal class Kegiatan
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
                            Console.WriteLine("2. Tambah Data Kegiatan");
                            Console.WriteLine("3. Hapus Data Kegiatan");
                            Console.WriteLine("4. Edit Data Kegiatan");
                            Console.WriteLine("5. Cari Data Kegiatan");
                            Console.WriteLine("6. Keluar");
                            Console.WriteLine("\n Enter your choice (1-6): ");
                            char ch = Convert.ToChar(Console.ReadLine());
                            switch (ch)
                            {
                                case '1':
                                    Console.Clear();
                                    Console.WriteLine("Data Kegiatan\n");
                                    Console.WriteLine();
                                    BacaData(conn);
                                    break;
                                case '2':
                                    Console.Clear();
                                    Console.WriteLine("Input Data Kegiatan\n");
                                    Console.WriteLine("Masukkan Kode Kegiatan (4 karakter): ");
                                    string Kd_Kegiatan = Console.ReadLine();
                                    Console.WriteLine("Masukkan Nama Kegiatan: ");
                                    string NamaKegiatan = Console.ReadLine();
                                    Console.WriteLine("Masukkan Tanggal Kegiatan (YYYY-MM-DD): ");
                                    string TanggalKegiatan = Console.ReadLine();

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
                                                    InsertData(Kd_Kegiatan, NamaKegiatan, TanggalKegiatan, conn);
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

                                    BacaData(conn);

                                    Console.WriteLine("Masukkan Kode Kegiatan yang ingin dihapus:\n");
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
                                                    DeleteData(kodeHapus, conn);
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

                                    BacaData(conn);

                                    Console.WriteLine("Update Data Kegiatan\n");
                                    Console.WriteLine("Masukkan Kode Kegiatan yang akan diupdate: ");
                                    string kodeToUpdate = Console.ReadLine();
                                    Console.WriteLine("Masukkan data baru\n");
                                    Console.WriteLine("Masukkan Nama Kegiatan Baru: ");
                                    string newNamaKegiatan = Console.ReadLine();
                                    Console.WriteLine("Masukkan Tanggal Kegiatan Baru (YYYY-MM-DD): ");
                                    string newTanggalKegiatan = Console.ReadLine();

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
                                                    UpdateData(kodeToUpdate, newNamaKegiatan, newTanggalKegiatan, conn);
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
                                    Console.WriteLine("Cari Data Kegiatan Berdasarkan Kode Kegiatan\n");
                                    Console.WriteLine("Masukkan Kode Kegiatan yang ingin dicari: ");
                                    string searchKode = Console.ReadLine();
                                    try
                                    {
                                        SearchByKodeKegiatan(searchKode, conn);
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

        public void BacaData(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("SELECT Kd_Kegiatan, Nama_Kegiatan, Tanggal_Kegiatan FROM Kegiatan", con);
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

        public void InsertData(string Kd_Kegiatan, string NamaKegiatan, string TanggalKegiatan, SqlConnection conn)
        {
            if (string.IsNullOrWhiteSpace(Kd_Kegiatan) || string.IsNullOrWhiteSpace(NamaKegiatan) || string.IsNullOrWhiteSpace(TanggalKegiatan))
            {
                Console.WriteLine("Semua data harus terisi. Gagal melakukan insert data.");
                return;
            }
            if (!IsAllDigits(Kd_Kegiatan))
            {
                Console.WriteLine("Kode hanya boleh berisi angka. Gagal menambahkan data.");
                return;
            }

            string str = "INSERT INTO Kegiatan (Kd_Kegiatan, Nama_Kegiatan, Tanggal_Kegiatan)" +
                "VALUES (@Kd_Kegiatan, @NamaKegiatan, @TanggalKegiatan)";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@Kd_Kegiatan", Kd_Kegiatan);
            cmd.Parameters.AddWithValue("@NamaKegiatan", NamaKegiatan);
            cmd.Parameters.AddWithValue("@TanggalKegiatan", DateTime.Parse(TanggalKegiatan));

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


        public void DeleteData(string Kd_Kegiatan, SqlConnection con)
        {
            string str = "DELETE FROM Kegiatan WHERE Kd_Kegiatan = @Kd_Kegiatan";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@Kd_Kegiatan", Kd_Kegiatan);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Dihapus");
        }

        public void UpdateData(string Kd_Kegiatan, string newNamaKegiatan, string newTanggalKegiatan, SqlConnection con)
        {
            string updateQuery = "UPDATE Kegiatan SET ";
            List<string> updates = new List<string>();

            if (!string.IsNullOrEmpty(newNamaKegiatan))
            {
                updates.Add("Nama_Kegiatan = @NewNm");
            }
            if (!string.IsNullOrEmpty(newTanggalKegiatan))
            {
                updates.Add("Tanggal_Kegiatan = @NewTgl");
            }

            updateQuery += string.Join(", ", updates);

            updateQuery += " WHERE Kd_Kegiatan = @NewKd_Kegiatan";

            SqlCommand command = new SqlCommand(updateQuery, con);

            if (!string.IsNullOrEmpty(newNamaKegiatan))
            {
                command.Parameters.Add("@NewNm", SqlDbType.NVarChar).Value = newNamaKegiatan;
            }
            if (!string.IsNullOrEmpty(newTanggalKegiatan))
            {
                command.Parameters.Add("@NewTgl", SqlDbType.Date).Value = DateTime.Parse(newTanggalKegiatan);
            }

            command.Parameters.Add("@NewKd_Kegiatan", SqlDbType.Char, 4).Value = Kd_Kegiatan;

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

        public void SearchByKodeKegiatan(string Kd_Kegiatan, SqlConnection con)
        {
            string query = "SELECT * FROM Kegiatan WHERE Kd_Kegiatan = @Kd_Kegiatan";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Kd_Kegiatan", Kd_Kegiatan);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Console.WriteLine("Hasil Pencarian:\n");
                while (reader.Read())
                {
                    Console.WriteLine($"Kode Kegiatan: {reader["Kd_Kegiatan"]}, Nama Kegiatan: {reader["Nama_Kegiatan"]}, Tanggal Kegiatan: {reader["Tanggal_Kegiatan"]}");
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
