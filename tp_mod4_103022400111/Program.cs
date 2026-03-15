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

        // Simulasi Bagian E
        Console.WriteLine("\n=== IMPLEMENTASI DOOR MACHINE ===");
        DoorMachine pintu = new DoorMachine(); 
        pintu.BukaPintu();                    
        pintu.BukaPintu();                     
        pintu.KunciPintu();                    
        pintu.KunciPintu();                    
    }
}