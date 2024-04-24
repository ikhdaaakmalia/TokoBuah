using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokoBuah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            while (true)
            {
                try
                {
                    Console.Write("\nKetik K untuk Terhubung ke Database atau E untuk Keluar dari Aplikasi: ");
                    char chr = Convert.ToChar(Console.ReadLine());
                    switch (chr)
                    {
                        case 'K':
                            {
                                Console.Clear();
                                Console.WriteLine("Masukkan Database yang Dituju Kemudian Klik Enter:");
                                string db = Console.ReadLine();
                                SqlConnection conn = null;
                                string strKoneksi = "Data source = IKHDAAMEL\\IKHDAAKMALIA; " +
                                "initial catalog = {0}; " +
                                "User ID = sa; password = Semangat45";
                                conn = new SqlConnection(string.Format(strKoneksi, db));
                                conn.Open();
                                Console.Clear();
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("\n====MENU====");
                                        Console.WriteLine("a. Melihat Data Pedagang");
                                        Console.WriteLine("b. Menambahkan Data Pedagang");
                                        Console.WriteLine("c. Menghapus Data Pedagang");
                                        Console.WriteLine("d. Melihat Data Buah");
                                        Console.WriteLine("e. Menambahkan Data Buah");
                                        Console.WriteLine("f. Menghapus Data Buah");
                                        Console.WriteLine("g. Melihat Data Pembeli");
                                        Console.WriteLine("h. Menambahkan Data Pembeli");
                                        Console.WriteLine("i. Menghapus Data Pembeli");
                                        Console.WriteLine("j. Melihat Data Transaksi");
                                        Console.WriteLine("k. Menambahkan Data Transaksi");
                                        Console.WriteLine("l. Menghapus Data Transaksi");
                                        Console.WriteLine("m. Melihat Data Stok");
                                        Console.WriteLine("n. Menambahkan Data Stok");
                                        Console.WriteLine("o. Menghapus Data Stok");
                                        Console.WriteLine("p. Edit Stok");
                                        Console.WriteLine("q. Keluar");
                                        Console.Write("\nEnter your choice (a-q): ");
                                        char ch = Convert.ToChar(Console.ReadLine());
                                        switch (ch)
                                        {
                                            case 'a':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Data Pedagang\n");
                                                    Console.WriteLine();
                                                    pr.readPedagang(conn);
                                                }
                                                break;
                                            case 'b':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("====Input Data Pedagang====\n");
                                                    Console.WriteLine("Masukkan id Pedagang :");
                                                    string id_pedagang = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nama Pedagang :");
                                                    string nama_pedagang = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nomor Telepon :");
                                                    string no_telp = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Alamat :");
                                                    string alamat = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.insertPedagang(id_pedagang, nama_pedagang, no_telp, alamat, conn);
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\nAnda tidak memiliki " + "akses untuk menambah Data atau Data yang anda masukkan salah");
                                                        Console.WriteLine(e.ToString());
                                                    }
                                                }
                                                break;
                                            case 'c':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Masukkan id Pedagang yang Ingin Dihapus:\n");
                                                    string id_pedagang = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.deletePedagang(id_pedagang, conn);
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\nAnda tidek memiliki " + "akses untuk menambah Data atau Data yang anda masukkan salah");
                                                        Console.WriteLine(e.ToString());
                                                    }
                                                }
                                                break;
                                            case 'd':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Data Buah\n");
                                                    Console.WriteLine();
                                                    pr.readBuah(conn);
                                                }
                                                break;
                                            case 'e':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("====Input Data Buah====\n");
                                                    Console.WriteLine("Masukkan id Buah :");
                                                    string id_buah = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nama Buah :");
                                                    string nama_buah = Console.ReadLine();
                                                    Console.WriteLine("Masukkan jenis Buah :");
                                                    string jenis_buah = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Harga Buah :");
                                                    string harga_buah = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.insertBuah(id_buah, nama_buah, jenis_buah, harga_buah, conn);
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\nAnda tidak memiliki " + "akses untuk menambah Data atau Data yang anda masukkan salah");
                                                        Console.WriteLine(e.ToString());
                                                    }
                                                }
                                                break;
                                            case 'f':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Masukkan id Buah yang Ingin Dihapus:\n");
                                                    string id_buah = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.deleteBuah(id_buah, conn);
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\nAnda tidek memiliki " + "akses untuk menambah Data atau Data yang anda masukkan salah");
                                                        Console.WriteLine(e.ToString());
                                                    }
                                                }
                                                break;
                                            case 'g':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Data Pembeli\n");
                                                    Console.WriteLine();
                                                    pr.readPembeli(conn);
                                                }
                                                break;
                                            case 'h':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("====Input Data Pembeli====\n");
                                                    Console.WriteLine("Masukkan id Pembeli :");
                                                    string id_pembeli = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nama Pembeli :");
                                                    string nama_pembeli = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nomor Telepon :");
                                                    string no_telp = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Alamat :");
                                                    string alamat = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.insertPembeli(id_pembeli, nama_pembeli, no_telp, alamat, conn);
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\nAnda tidak memiliki " + "akses untuk menambah Data atau Data yang anda masukkan salah");
                                                        Console.WriteLine(e.ToString());
                                                    }
                                                }
                                                break;
                                            case 'i':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Masukkan id Pembeli yang Ingin Dihapus:\n");
                                                    string id_pembeli = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.deletePembeli(id_pembeli, conn);
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\nAnda tidek memiliki " + "akses untuk menambah Data atau Data yang anda masukkan salah");
                                                        Console.WriteLine(e.ToString());
                                                    }
                                                }
                                                break;
                                            case 'j':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Data Transaksi\n");
                                                    Console.WriteLine();
                                                    pr.readTransaksi(conn);
                                                }
                                                break;
                                            case 'k':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("====Input Data Transaksi====\n");
                                                    Console.WriteLine("Masukkan Id Transaksi :");
                                                    string id_transaksi = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Id Pedagang :");
                                                    string id_pedagang = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Id Pembeli :");
                                                    string id_pembeli = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Tanggal Transaksi :");
                                                    string tgl_transaski = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.insertTransaksi(id_transaksi, id_pedagang, id_pembeli, tgl_transaski, conn); // Menggunakan insertTransaksi, bukan insertTransaski
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\nAnda tidak memiliki " + "akses untuk menambah Data atau Data yang anda masukkan salah");
                                                        Console.WriteLine(e.ToString());
                                                    }
                                                }
                                                break;
                                            case 'l':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Masukkan id Transaksi yang Ingin Dihapus:\n");
                                                    string id_transaksi = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.deleteTransaksi(id_transaksi, conn);
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\nAnda tidek memiliki " + "akses untuk menambah Data atau Data yang anda masukkan salah");
                                                        Console.WriteLine(e.ToString());
                                                    }
                                                }
                                                break;
                                            case 'm':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Data Stok\n");
                                                    Console.WriteLine();
                                                    pr.readStok(conn);
                                                }
                                                break;
                                            case 'n':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("====Input Data Stok====\n");
                                                    Console.WriteLine("Masukkan Id Stok :");
                                                    string id_stok = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Id Pedagang :");
                                                    string id_pedagang = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Id Buah :");
                                                    string id_buah = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nama Stok :");
                                                    string nama_stok = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Jumlah Stok :");
                                                    string jumlah_stok = Console.ReadLine();
                                                    try
                                                    {
                                                        // Ganti pemanggilan metode dengan metode yang sesuai, misalnya insertStok
                                                        pr.insertStok(id_stok, id_pedagang, id_buah, nama_stok, jumlah_stok, conn);
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\nAnda tidak memiliki " + "akses untuk menambah Data atau Data yang anda masukkan salah");
                                                        Console.WriteLine(e.ToString());
                                                    }
                                                }
                                                break;
                                            case 'o':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Masukkan Id Stok yang Ingin Dihapus:\n");
                                                    string id_stok = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.deleteStok(id_stok, conn);
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\nAnda tidek memiliki " + "akses untuk menambah Data atau Data yang anda masukkan salah");
                                                        Console.WriteLine(e.ToString());
                                                    }
                                                }
                                                break;
                                            case 'p':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("====Edit Data Stok====\n");
                                                    Console.WriteLine("Masukkan id stok :");
                                                    string id_stok_baru = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nama Stok Baru:");
                                                    string nama_stok_baru = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Jumlah Stok Baru:");
                                                    string jumlah_stok_baru = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.editStok(id_stok_baru, nama_stok_baru, jumlah_stok_baru, conn);
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\nAnda tidak memiliki akses untuk mengedit Data atau Data yang Anda masukkan salah");
                                                        Console.WriteLine(e.ToString());
                                                    }
                                                }
                                                break;
                                            case 'q':
                                                conn.Close();
                                                Console.Clear();
                                                Main(new String[0]);
                                                return;
                                            default:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\nInvalid option");
                                                }
                                                break;
                                        }
                                    }
                                    catch
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nCheck for the value entered.");
                                    }
                                }
                            }
                        case 'E':
                            return;
                        default:
                            {
                                Console.WriteLine("\nInvalid option");
                            }
                            break;
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
        //pedagang
        public void readPedagang(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("Select id_pedagang, nama_pedagang, no_telp, alamat From Pedagang", con);
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
        public void insertPedagang(string id, string Nama, string NoTlp, string almt, SqlConnection con)
        {
            string str = "insert into Pedagang (id_pedagang, nama_pedagang, no_telp, alamat) " +
                         "values(@id,@nm,@no,@a)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("id", id));
            cmd.Parameters.Add(new SqlParameter("nm", Nama));
            cmd.Parameters.Add(new SqlParameter("no", NoTlp));
            cmd.Parameters.Add(new SqlParameter("a", almt));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Ditambahkan");
        }

        public void deletePedagang(string id, SqlConnection con)
        {
            string str = "DELETE FROM Pedagang WHERE id_pedagang = @id";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("id", id));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Dihapus");
        }

        //Buah
        public void readBuah(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("SELECT id_buah, nama_buah, jenis_buah, harga_buah FROM Buah", con);
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

        public void insertBuah(string id, string Nama, string Jenis, string Harga, SqlConnection con)
        {
            string str = "INSERT INTO Buah (id_buah, nama_buah, jenis_buah, harga_buah) " +
                         "VALUES (@id, @nm, @jenis, @harga)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("id", id));
            cmd.Parameters.Add(new SqlParameter("nm", Nama));
            cmd.Parameters.Add(new SqlParameter("jenis", Jenis));
            cmd.Parameters.Add(new SqlParameter("harga", Harga));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Buah Berhasil Ditambahkan");
        }

        public void deleteBuah(string id, SqlConnection con)
        {
            string str = "DELETE FROM Buah WHERE id_buah = @id";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("id", id));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Buah Berhasil Dihapus");
        }

        //Pembeli
        public void readPembeli(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("SELECT id_pembeli, nama_pembeli, no_telp, alamat FROM DataPembeli", con);
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

        public void insertPembeli(string id, string Nama, string NoTlp, string Alamat, SqlConnection con)
        {
            string str = "INSERT INTO Pembeli (id_pembeli, nama_pembeli, no_telp, alamat) " +
                         "VALUES (@id, @nm, @no, @alamat)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("id", id));
            cmd.Parameters.Add(new SqlParameter("nm", Nama));
            cmd.Parameters.Add(new SqlParameter("no", NoTlp));
            cmd.Parameters.Add(new SqlParameter("alamat", Alamat));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Pembeli Berhasil Ditambahkan");
        }

        public void deletePembeli(string id, SqlConnection con)
        {
            string str = "DELETE FROM Pembeli WHERE id_pembeli = @id";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("id", id));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Pembeli Berhasil Dihapus");
        }

        //Transaksi
        public void readTransaksi(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("SELECT id_transaksi, id_pedagang, id_pembeli, tgl_transaksi FROM DataTransaksi", con);
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
        public void insertTransaksi(string id, string idPedagang, string idPembeli, string tanggal, SqlConnection con)
        {
            string str = "INSERT INTO Transaksi (id_transaksi, id_pedagang, id_pembeli, tgl_transaksi) " +
                         "VALUES (@id, @idPedagang, @idPembeli, @tanggal)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("id", id));
            cmd.Parameters.Add(new SqlParameter("idPedagang", idPedagang));
            cmd.Parameters.Add(new SqlParameter("idPembeli", idPembeli));
            cmd.Parameters.Add(new SqlParameter("tanggal", tanggal));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Transaksi Berhasil Ditambahkan");
        }

        public void deleteTransaksi(string id, SqlConnection con)
        {
            string str = "DELETE FROM Transaksi WHERE id_transaksi = @id";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("id", id));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Transaksi Berhasil Dihapus");
        }

        //Stok
        public void readStok(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("SELECT id_stok, id_pedagang, id_buah, nama_stok, jumlah_stok FROM DataStok", con);
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

        public void insertStok(string id_stok, string id_pedagang, string id_buah, string nama_stok, string jumlah_stok, SqlConnection con)
        {
            string str = "INSERT INTO Stok (id_stok, id_pedagang, id_buah, nama_stok, jumlah_stok) " +
                         "VALUES (@ids, @idg, @idb, @nm, @jm)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("ids", id_stok));
            cmd.Parameters.Add(new SqlParameter("idg", id_pedagang));
            cmd.Parameters.Add(new SqlParameter("idb", id_buah));
            cmd.Parameters.Add(new SqlParameter("nm", nama_stok));
            cmd.Parameters.Add(new SqlParameter("jm", jumlah_stok));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Pembeli Berhasil Ditambahkan");
        }

        public void deleteStok(string id, SqlConnection con)
        {
            string str = "DELETE FROM Stok WHERE id_stok = @id";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("id", id));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Stok Berhasil Dihapus");
        }
        public void editStok(string id_stok_baru, string nama_stok_baru, string jumlah_stok_baru, SqlConnection con)
        {
            string str = "UPDATE Stok SET nama_stok_baru = @nmsb, jumlah_stok_baru = @jmsb, WHERE id_stok_baru = @idsb";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("idsb", id_stok_baru));
            cmd.Parameters.Add(new SqlParameter("nmsb", nama_stok_baru));
            cmd.Parameters.Add(new SqlParameter("jmsb", jumlah_stok_baru));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Berhasil Diedit");
        }
    }
}