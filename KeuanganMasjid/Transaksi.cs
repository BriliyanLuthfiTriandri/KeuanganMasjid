using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KeuanganMasjid
{
    internal class Transaksi
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
                            Console.WriteLine("2. Tambah Data Transaksi");
                            Console.WriteLine("3. Hapus Data Transaksi");
                            Console.WriteLine("4. Edit Data Transaksi");
                            Console.WriteLine("5. Cari Data Transaksi");
                            Console.WriteLine("6. Keluar");
                            Console.WriteLine("\n Enter your choice (1-6): ");
                            char ch = Convert.ToChar(Console.ReadLine());
                            switch (ch)
                            {
                                case '1':
                                    Console.Clear();
                                    Console.WriteLine("Data Transaksi\n");
                                    Console.WriteLine();
                                    ReadTransaction(conn);
                                    break;
                                case '2':
                                    Console.Clear();
                                    Console.WriteLine("Input Data Transaksi\n");
                                    Console.WriteLine("Masukkan Jenis Transaksi: ");
                                    string jenisTransaksi = Console.ReadLine();
                                    Console.WriteLine("Masukkan Jumlah Transaksi: ");
                                    int jumlahTransaksi = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Masukkan ID Staff: ");
                                    string idStaff = Console.ReadLine();
                                    Console.WriteLine("Masukkan NIK Donatur: ");
                                    string nikDonatur = Console.ReadLine();

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
                                                    InsertTransaction(jenisTransaksi, jumlahTransaksi, idStaff, nikDonatur, conn);
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

                                    ReadTransaction(conn);

                                    Console.WriteLine("Masukkan Kode Transaksi yang ingin dihapus:\n");
                                    int kodeHapus = Convert.ToInt32(Console.ReadLine());


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
                                                    DeleteTransaction(kodeHapus, conn);
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

                                    ReadTransaction(conn);

                                    Console.WriteLine("Update Data Transaksi\n");
                                    Console.WriteLine("Masukkan Kode Transaksi yang akan diupdate: ");
                                    int kodeToUpdate = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Masukkan data baru\n");
                                    Console.WriteLine("Masukkan Jenis Transaksi Baru: ");
                                    string newJenisTransaksi = Console.ReadLine();
                                    Console.WriteLine("Masukkan Jumlah Transaksi Baru: ");
                                    int newJumlahTransaksi = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Masukkan ID Staff Baru: ");
                                    string newIdStaff = Console.ReadLine();
                                    Console.WriteLine("Masukkan NIK Donatur Baru: ");
                                    string newNikDonatur = Console.ReadLine();


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
                                                    UpdateTransaction(kodeToUpdate, newJenisTransaksi, newJumlahTransaksi, newIdStaff, newNikDonatur, conn);
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
                                    Console.WriteLine("Cari Data Transaksi Berdasarkan Kode Transaksi\n");
                                    Console.WriteLine("Masukkan Kode Transaksi yang ingin dicari: ");
                                    int searchKode = Convert.ToInt32(Console.ReadLine());
                                    try
                                    {
                                        SearchByTransactionCode(searchKode, conn);
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

        public void ReadTransaction(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("SELECT Kd_Transaksi, Jenis_Transaksi, Jumlah_Transaksi, Tanggal_Transaksi, Id_Staff, NIK FROM Transaksi", con);
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

        public void InsertTransaction(string jenisTransaksi, int jumlahTransaksi, string idStaff, string nikDonatur, SqlConnection conn)
        {
            if (string.IsNullOrWhiteSpace(jenisTransaksi) || string.IsNullOrWhiteSpace(jenisTransaksi) || string.IsNullOrWhiteSpace(idStaff) || string.IsNullOrWhiteSpace(nikDonatur))
            {
                Console.WriteLine("Semua data harus terisi. Gagal melakukan insert data.");
                return;
            }
            if (!IsAllDigits(idStaff))
            {
                Console.WriteLine("ID hanya boleh berisi angka. Gagal menambahkan data.");
                return;
            }
            if (!IsAllDigits(nikDonatur))
            {
                Console.WriteLine("NIK hanya boleh berisi angka. Gagal menambahkan data.");
                return;
            }

            string str = "INSERT INTO Transaksi (Jenis_Transaksi, Jumlah_Transaksi, Id_Staff, NIK)" +
                "VALUES (@jenisTransaksi, @jumlahTransaksi, @idStaff, @nikDonatur)";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@jenisTransaksi", jenisTransaksi);
            cmd.Parameters.AddWithValue("@jumlahTransaksi", jumlahTransaksi);
            cmd.Parameters.AddWithValue("@idStaff", idStaff);
            cmd.Parameters.AddWithValue("@nikDonatur", nikDonatur);

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

        public void DeleteTransaction(int kodeTransaksi, SqlConnection con)
        {
            string str = "DELETE FROM Transaksi WHERE Kd_Transaksi = @kodeTransaksi";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@kodeTransaksi", kodeTransaksi);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Dihapus");
        }

        public void UpdateTransaction(int kodeTransaksi, string newJenisTransaksi, int newJumlahTransaksi, string newIdStaff, string newNikDonatur, SqlConnection con)
        {
            string updateQuery = "UPDATE Transaksi SET ";
            List<string> updates = new List<string>();

            if (!string.IsNullOrEmpty(newJenisTransaksi))
            {
                updates.Add("Jenis_Transaksi = @NewJenisTransaksi");
            }
            if (newJumlahTransaksi != 0)
            {
                updates.Add("Jumlah_Transaksi = @NewJumlahTransaksi");
            }
            if (!string.IsNullOrEmpty(newIdStaff))
            {
                updates.Add("Id_Staff = @NewIdStaff");
            }
            if (!string.IsNullOrEmpty(newNikDonatur))
            {
                updates.Add("NIK = @NewNikDonatur");
            }

            updateQuery += string.Join(", ", updates);

            updateQuery += " WHERE Kd_Transaksi = @kodeTransaksi";

            SqlCommand command = new SqlCommand(updateQuery, con);

            if (!string.IsNullOrEmpty(newJenisTransaksi))
            {
                command.Parameters.Add("@NewJenisTransaksi", SqlDbType.NVarChar).Value = newJenisTransaksi;
            }
            if (newJumlahTransaksi != 0)
            {
                command.Parameters.Add("@NewJumlahTransaksi", SqlDbType.Int).Value = newJumlahTransaksi;
            }
            if (!string.IsNullOrEmpty(newIdStaff))
            {
                command.Parameters.Add("@NewIdStaff", SqlDbType.Char, 16).Value = newIdStaff;
            }
            if (!string.IsNullOrEmpty(newNikDonatur))
            {
                command.Parameters.Add("@NewNikDonatur", SqlDbType.Char, 16).Value = newNikDonatur;
            }

            command.Parameters.Add("@kodeTransaksi", SqlDbType.Int).Value = kodeTransaksi;

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

        public void SearchByTransactionCode(int kodeTransaksi, SqlConnection con)
        {
            string query = "SELECT * FROM Transaksi WHERE Kd_Transaksi = @kodeTransaksi";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@kodeTransaksi", kodeTransaksi);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Console.WriteLine("Hasil Pencarian:\n");
                while (reader.Read())
                {
                    Console.WriteLine($"Kode Transaksi: {reader["Kd_Transaksi"]}, Jenis Transaksi: {reader["Jenis_Transaksi"]}, Jumlah Transaksi: {reader["Jumlah_Transaksi"]}, Tanggal Transaksi: {reader["Tanggal_Transaksi"]}, ID Staff: {reader["Id_Staff"]}, NIK: {reader["NIK"]}");
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
