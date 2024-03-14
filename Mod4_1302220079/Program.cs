public class KodeBuah
{
    public enum Nama
    {
        Apel,
        Aprikot,
        Alpukat,
        Pisang,
        Paprika,
        Blackberry,
        Ceri,
        Kelapa,
        Jagung,
        Kurma,
        Durian,
        Anggur,
        Melon,
        Semangka
    }

    private static Dictionary<Nama, string> kodeBuahTabel = new Dictionary<Nama, string>
    {
        { Nama.Apel, "A00" },
        { Nama.Aprikot, "B00" },
        { Nama.Alpukat, "C00" },
        { Nama.Pisang, "D00" },
        { Nama.Paprika, "E00" },
        { Nama.Blackberry, "K00" },
        { Nama.Ceri, "H00" },
        { Nama.Kelapa, "I00" },
        { Nama.Jagung, "J00" },
        { Nama.Kurma, "K00" },
        { Nama.Durian, "L00" },
        { Nama.Anggur, "M00" },
        { Nama.Melon, "N00" },
        { Nama.Semangka, "O00" },
    };

    public static string getKodeBuah(Nama nama)
    {
        return kodeBuahTabel.GetValueOrDefault(nama, "Kode buah tidak ditemukan");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kode Durian : " + KodeBuah.getKodeBuah(KodeBuah.Nama.Durian));
        Console.WriteLine("Kode Ceri : " + KodeBuah.getKodeBuah(KodeBuah.Nama.Ceri));
        Console.WriteLine("Kode Semangka : " + KodeBuah.getKodeBuah(KodeBuah.Nama.Semangka));
    }
}