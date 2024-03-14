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

public class PosisiKarakterGame
{
    public enum State { Tengkurap, Jongkok, Berdiri, Terbang };
    public State currentState;

    public PosisiKarakterGame()
    {
        currentState = State.Berdiri;
        Console.WriteLine("Berdiri");
    }

    public void TombolW()
    {
        if (currentState == State.Tengkurap)
        {
            currentState = State.Jongkok;
            Console.WriteLine("Jongkok");
        } else if (currentState == State.Jongkok)
        {
            currentState = State.Berdiri;
            Console.WriteLine("Berdiri");
        } else if ( currentState == State.Berdiri) 
        {
            currentState = State.Terbang;
            Console.WriteLine("Terbang");
        }
        
    }

    public void TombolS()
    {
        if (currentState == State.Jongkok)
        {
            currentState = State.Tengkurap;
            Console.WriteLine("Tengkurap");
        }
        else if (currentState == State.Berdiri)
        {
            currentState = State.Jongkok;
            Console.WriteLine("Jongkok");
        }
        else if (currentState == State.Terbang)
        {
            currentState = State.Berdiri;
            Console.WriteLine("Berdiri");
        }
    }
    public void TombolX()
    {
        if (currentState == State.Terbang)
        {
            currentState= State.Jongkok;
            Console.WriteLine("Jongkok");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kode Durian : " + KodeBuah.getKodeBuah(KodeBuah.Nama.Durian));
        Console.WriteLine("Kode Ceri : " + KodeBuah.getKodeBuah(KodeBuah.Nama.Ceri));
        Console.WriteLine("Kode Semangka : " + KodeBuah.getKodeBuah(KodeBuah.Nama.Semangka));
        
        String Gerak;
        String Out = Console.ReadLine();
        PosisiKarakterGame posisi = new PosisiKarakterGame();
        Gerak = Console.ReadLine();
        for (int i = 0; i < 20;  i++)
        {
            if (Gerak == "W" || Gerak == "w")
            {
                posisi.TombolW();
                Console.WriteLine("Tombol arah atas ditekan");
            } else if (Gerak == "S" || Gerak == "s")
            {
                posisi.TombolS();
                Console.WriteLine("Tombol arah bawah ditekan");
            } else if (Gerak == "X" || Gerak == "x")
            {
                posisi.TombolX();
            }
            Gerak = Console.ReadLine();
            Console.WriteLine(posisi.currentState);
        }
    }
}