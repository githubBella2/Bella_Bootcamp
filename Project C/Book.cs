namespace Buku
{
    class Book
    {
        string judul;
        string warna;
        int panjang;
        int lebar;
        int halaman;
        int harga;
        int jumlah;

        public int Luas(int panjang, int lebar)
        {
            return panjang * lebar;

        }

        public int Keliling(int panjang, int lebar)
        {
            return 2 * (panjang + lebar);
        }

        public void Jumlah()
        {
            Console.WriteLine("Jumlah buku yang tersedia" + jumlah);
        }

        public string Deskripsi(string judul, int harga, string halaman)
        {
            return "Judul buku " + judul + "dengan harga Rp." + harga + " sebanyak" + halaman;
        }

        public int Total(int jumlah, int harga)
        {
            return jumlah * harga;
        }

    }

}


