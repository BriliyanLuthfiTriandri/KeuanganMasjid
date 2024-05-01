using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KeuanganMasjid
{
    internal class Donatur
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
                            Console.WriteLine("2. Tambah Data Donatur");
                            Console.WriteLine("3. Hapus Data Donatur");
                            Console.WriteLine("4. Edit Data Donatur");
                            Console.WriteLine("5. Cari Data Donatur");
                            Console.WriteLine("6. Keluar");
                            Console.WriteLine("\n Enter your choice (1-6): ");
                            char ch = Convert.ToChar(Console.ReadLine());
                            switch (ch)
                            {
                                case '1':
                                    Console.Clear();
                                    Console.WriteLine("Data Donatur\n");
                                    Console.WriteLine();
                                    BacaData(conn);
                                    break;
                                case '2':
                                    Console.Clear();
                                    Console.WriteLine("Input Data Donatur\n");
                                    Console.WriteLine("Masukkan NIK Donatur (16 karakter): ");
                                    string NIK = Console.ReadLine();
                                    Console.WriteLine("Masukkan Nama Donatur: ");
                                    string NamaDonatur = Console.ReadLine();
                                    Console.WriteLine("Masukkan Alamat Donatur: ");
                                    string Alamat = Console.ReadLine();
                                    Console.WriteLine("Masukkan Nomor Telepon Donatur:");
                                    string NoTelp = Console.ReadLine();
                                    Console.WriteLine("Masukkan Email Donatur: ");
                                    string Email = Console.ReadLine();

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
                                                    InsertData(NIK, NamaDonatur, Alamat, NoTelp, Email, conn);
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

                                    Console.WriteLine("Masukkan NIK Donatur yang ingin dihapus:\n");
                                    string nikHapus = Console.ReadLine();


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
                                                    DeleteData(nikHapus, conn);
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

                                    Console.WriteLine("Update Data Donatur\n");
                                    Console.WriteLine("Masukkan NIK Donatur yang akan diupdate: ");
                                    string nikToUpdate = Console.ReadLine();
                                    Console.WriteLine("Masukkan data baru\n");
                                    Console.WriteLine("Masukkan Nama Donatur Baru: ");
                                    string newNamaDonatur = Console.ReadLine();
                                    Console.WriteLine("Masukkan Alamat Donatur Baru: ");
                                    string newAlamat = Console.ReadLine();
                                    Console.WriteLine("Masukkan Nomor Telepon Donatur Baru: ");
                                    string newNoTelp = Console.ReadLine();
                                    Console.WriteLine("Masukkan Email Donatur Baru: ");
                                    string newEmail = Console.ReadLine();

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
                                                    UpdateData(nikToUpdate, newNamaDonatur, newAlamat, newNoTelp, newEmail, conn);
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
                                    Console.WriteLine("Cari Data Donatur Berdasarkan NIK\n");
                                    Console.WriteLine("Masukkan NIK Donatur yang ingin dicari: ");
                                    string searchNik = Console.ReadLine();
                                    try
                                    {
                                        SearchByNIK(searchNik, conn);
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
            SqlCommand cmd = new SqlCommand("SELECT NIK, Nama_Donatur, Alamat, No_tlpn, Email FROM Donatur", con);
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

        public void InsertData(string NIK, string NamaDonatur, string Alamat, string NoTelp, string Email, SqlConnection conn)
        {
            if (string.IsNullOrWhiteSpace(NIK) || string.IsNullOrWhiteSpace(NamaDonatur) || string.IsNullOrWhiteSpace(Alamat) || string.IsNullOrWhiteSpace(NoTelp) || string.IsNullOrWhiteSpace(Email))
            {
                Console.WriteLine("Semua data harus terisi. Gagal melakukan insert data.");
                return;
            }
            if (!IsAllDigits(NIK))
            {
                Console.WriteLine("NIK hanya boleh berisi angka. Gagal menambahkan data.");
                return;
            }
            if (!IsAllDigits(NoTelp))
            {
                Console.WriteLine("NoTelp hanya boleh berisi angka. Gagal menambahkan data.");
                return;
            }
            string str = "INSERT INTO Donatur (NIK, Nama_Donatur, Alamat, No_tlpn, Email)" +
                "VALUES (@NIK, @NamaDonatur, @Alamat, @NoTelp, @Email)";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@NIK", NIK);
            cmd.Parameters.AddWithValue("@NamaDonatur", NamaDonatur);
            cmd.Parameters.AddWithValue("@Alamat", Alamat);
            cmd.Parameters.AddWithValue("@NoTelp", NoTelp);
            cmd.Parameters.AddWithValue("@Email", Email);

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

        public void DeleteData(string NIK, SqlConnection con)
        {
            string str = "DELETE FROM Donatur WHERE NIK = @NIK";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@NIK", NIK);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Dihapus");
        }

        public void UpdateData(string NIK, string newNamaDonatur, string newAlamat, string newNoTelp, string newEmail, SqlConnection con)
        {
            string updateQuery = "UPDATE Donatur SET ";
            List<string> updates = new List<string>();

            if (!string.IsNullOrEmpty(newNamaDonatur))
            {
                updates.Add("Nama_Donatur = @NewNm");
            }
            if (!string.IsNullOrEmpty(newAlamat))
            {
                updates.Add("Alamat = @NewAlmt");
            }
            if (!string.IsNullOrEmpty(newNoTelp))
            {
                updates.Add("No_tlpn = @NewTl");
            }
            if (!string.IsNullOrEmpty(newEmail))
            {
                updates.Add("Email = @NewEm");
            }

            updateQuery += string.Join(", ", updates);

            updateQuery += " WHERE NIK = @NewNIK";

            SqlCommand command = new SqlCommand(updateQuery, con);

            if (!string.IsNullOrEmpty(newNamaDonatur))
            {
                command.Parameters.Add("@NewNm", SqlDbType.NVarChar).Value = newNamaDonatur;
            }
            if (!string.IsNullOrEmpty(newAlamat))
            {
                command.Parameters.Add("@NewAlmt", SqlDbType.NVarChar).Value = newAlamat;
            }
            if (!string.IsNullOrEmpty(newNoTelp))
            {
                command.Parameters.Add("@NewTl", SqlDbType.NVarChar).Value = newNoTelp;
            }
            if (!string.IsNullOrEmpty(newEmail))
            {
                command.Parameters.Add("@NewEm", SqlDbType.NVarChar).Value = newEmail;
            }

            command.Parameters.Add("@NewNIK", SqlDbType.NVarChar).Value = NIK;

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


        public void SearchByNIK(string NIK, SqlConnection con)
        {
            string query = "SELECT * FROM Donatur WHERE NIK = @NIK";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NIK", NIK);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Console.WriteLine("Hasil Pencarian:\n");
                while (reader.Read())
                {
                    Console.WriteLine($"NIK Donatur: {reader["NIK"]}, Nama: {reader["Nama_Donatur"]}, Alamat: {reader["Alamat"]}, No Telp: {reader["No_tlpn"]}, Email: {reader["Email"]}");
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
