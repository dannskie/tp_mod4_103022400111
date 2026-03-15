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
