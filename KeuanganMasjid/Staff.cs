using KeuanganMasjid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace KeuanganMasjid
{
    internal class Staff
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
                            Console.WriteLine("2. Tambah Data Staff");
                            Console.WriteLine("3. Hapus Data Staff");
                            Console.WriteLine("4. Edit Data Staff");
                            Console.WriteLine("5. Cari Data Staff");
                            Console.WriteLine("6. Keluar");
                            Console.WriteLine("\n Enter your choice (1-6): ");
                            char ch = Convert.ToChar(Console.ReadLine());
                            switch (ch)
                            {
                                case '1':
                                    Console.Clear();
                                    Console.WriteLine("Data Staf\n");
                                    Console.WriteLine();
                                    baca(conn);
                                    break;
                                case '2':
                                    Console.Clear();
                                    Console.WriteLine("Input Data Staf\n");
                                    Console.WriteLine("Masukkan ID Staf ( 16 character ) : ");
                                    string id = Console.ReadLine();
                                    Console.WriteLine("Masukkan Nama Staf : ");
                                    string nama = Console.ReadLine();
                                    Console.WriteLine("Masukkan Alamat Staf : ");
                                    string alamat = Console.ReadLine();
                                    Console.WriteLine("Masukkan Nomor Telephone Staf :");
                                    string noTelp = Console.ReadLine();
                                    Console.WriteLine("Masukkan Email Staf : ");
                                    string email = Console.ReadLine();


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
                                                    insert(id, nama, alamat, noTelp, email, conn);
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

                                    baca(conn);

                                    Console.WriteLine("Masukkan Data Staf ingin dihapus:\n");
                                    string idHapus = Console.ReadLine();


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
                                                    delete(idHapus, conn);
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

                                    Console.WriteLine("List data yag sudah di input");

                                    baca(conn);

                                    Console.WriteLine("Update Data Staf\n");
                                    Console.WriteLine("Masukkan ID Staf yang akan diupdate: ");
                                    string idpd = Console.ReadLine();
                                    Console.WriteLine("Masukkan data baru\n");
                                    Console.WriteLine("Masukkan Nama Staf Baru : ");
                                    string newNama = Console.ReadLine();
                                    Console.WriteLine("Masukkan Alamat Staf Baru : ");
                                    string newAlamat = Console.ReadLine();
                                    Console.WriteLine("Masukkan Nomor Telephone Staf Baru : ");
                                    string newNoTelp = Console.ReadLine();
                                    Console.WriteLine("Masukkan Email Staf Baru : ");
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
                                                    update(idpd, newNama, newAlamat, newNoTelp, newEmail, conn);
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
                                    Console.WriteLine("Cari Data Staf Berdasarkan ID\n");
                                    Console.WriteLine("Masukkan ID Staf yang ingin dicari: ");
                                    string searchId = Console.ReadLine();
                                    try
                                    {
                                        searchById(searchId, conn);
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

        public void baca(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("SELECT Id_Staff, Nama_Staff, Alamat, No_tlpn, Email FROM Staff", con);
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

        public void insert(string id, string nama, string alamat, string noTelp, string email, SqlConnection conn)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(alamat) || string.IsNullOrWhiteSpace(noTelp) || string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Semua data harus terisi. Gagal melakukan insert data.");
                return;
            }
            if (!IsAllDigits(id))
            {
                Console.WriteLine("ID hanya boleh berisi angka. Gagal menambahkan data.");
                return;
            }
            if (!IsAllDigits(noTelp))
            {
                Console.WriteLine("noTelp hanya boleh berisi angka. Gagal menambahkan data.");
                return;
            }
            string str = "INSERT INTO Staff (Id_Staff, Nama_Staff, Alamat, No_tlpn, Email)" +
                "VALUES (@id, @nama, @alamat, @noTelp, @email)";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@alamat", alamat);
            cmd.Parameters.AddWithValue("@noTelp", noTelp);
            cmd.Parameters.AddWithValue("@email", email);

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

        public void delete(string id, SqlConnection con)
        {
            string str = "DELETE FROM Staff WHERE Id_Staff = @id";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Dihapus");
        }

        public void update(string idpd, string newNama, string newAlamat, string newNoTelp, string newEmail, SqlConnection con)
        {
            string updateQuery = "UPDATE Staff SET ";
            List<string> updates = new List<string>();

            if (!string.IsNullOrEmpty(newNama))
            {
                updates.Add("Nama_Staff = @NewNm");
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

            updateQuery += " WHERE Id_Staff = @NewidKe";

            SqlCommand command = new SqlCommand(updateQuery, con);

            if (!string.IsNullOrEmpty(newNama))
            {
                command.Parameters.Add("@NewNm", SqlDbType.NVarChar).Value = newNama;
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
            command.Parameters.Add("@NewidKe", SqlDbType.NVarChar).Value = idpd;

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


        public void searchById(string id, SqlConnection con)
        {
            string query = "SELECT * FROM Staff WHERE Id_Staff = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Console.WriteLine("Hasil Pencarian:\n");
                while (reader.Read())
                {
                    Console.WriteLine($"ID Staf: {reader["Id_Staff"]}, Nama: {reader["Nama_Staff"]}, Alamat: {reader["Alamat"]}, No Telp: {reader["No_tlpn"]}, Email: {reader["Email"]}");
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