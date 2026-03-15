using System;
//bagian kode pos
public enum Kelurahan
{
    Batununggal, Kujangsari, Mengger, Wates, Cijaura,
    Jatisari, Margasari, Sekejati, Kebonwaru, Maleer
}

public class KodePos
{
    public static int getKodePos(Kelurahan kelurahan)
    {
        int[] tableKodePos = {
            40266, 
            40287, 
            40267, 
            40256, 
            40287,
            40286, 
            40286, 
            40286, 
            40272, 
            40274  
        };

        return tableKodePos[(int)kelurahan];
    }
}

// bagian doormachine
public class DoorMachine
{
    public enum State { Terkunci, Terbuka };

    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void BukaPintu()
    {
        currentState = State.Terbuka;
        Console.WriteLine("Pintu tidak terkunci");
    }

    public void KunciPintu()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== IMPLEMENTASI KODE POS ===");
        Kelurahan kelurahan1 = Kelurahan.Batununggal;
        Console.WriteLine("Kode Pos " + kelurahan1 + " adalah " + KodePos.getKodePos(kelurahan1));

        Kelurahan kelurahan2 = Kelurahan.Maleer;
        Console.WriteLine("Kode Pos " + kelurahan2 + " adalah " + KodePos.getKodePos(kelurahan2));
        
        Kelurahan kelurahan3 = Kelurahan.Cijaura;
        Console.WriteLine("Kode Pos " + kelurahan3 + " adalah " + KodePos.getKodePos(kelurahan3));

        Kelurahan kelurahan4 = Kelurahan.Kujangsari;
        Console.WriteLine("Kode Pos " + kelurahan4 + " adalah " + KodePos.getKodePos(kelurahan4));

        Kelurahan kelurahan5 = Kelurahan.Kebonwaru;
        Console.WriteLine("Kode Pos " + kelurahan5 + " adalah " + KodePos.getKodePos(kelurahan5));

        Kelurahan kelurahan6 = Kelurahan.Wates;
        Console.WriteLine("Kode Pos " + kelurahan6 + " adalah " + KodePos.getKodePos(kelurahan6));

        Kelurahan kelurahan7 = Kelurahan.Sekejati;
        Console.WriteLine("Kode Pos " + kelurahan7 + " adalah " + KodePos.getKodePos(kelurahan7));

        Kelurahan kelurahan8 = Kelurahan.Mengger;
        Console.WriteLine("Kode Pos " + kelurahan8 + " adalah " + KodePos.getKodePos(kelurahan8));

        Kelurahan kelurahan9 = Kelurahan.Jatisari;
        Console.WriteLine("Kode Pos " + kelurahan9 + " adalah " + KodePos.getKodePos(kelurahan9));

        Kelurahan kelurahan10 = Kelurahan.Margasari;
        Console.WriteLine("Kode Pos " + kelurahan10 + " adalah " + KodePos.getKodePos(kelurahan10));

        Console.WriteLine("\n=== IMPLEMENTASI DOOR MACHINE ===");
        DoorMachine pintu = new DoorMachine(); 
        pintu.BukaPintu();                    
        pintu.BukaPintu();                     
        pintu.KunciPintu();                    
        pintu.KunciPintu();                    
    }
}