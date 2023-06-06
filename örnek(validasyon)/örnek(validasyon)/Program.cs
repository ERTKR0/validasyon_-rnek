
namespace örnek_validasyon_;

        class Urun
        {
            public int No { get; set; }
            public string Ad { get; set; }
            public string Acıklama { get; set; }
            public decimal Fiyat { get; set; }
    
   

    public Urun()
    {
        Random r = new Random();
        this.No = r.Next(0, 10000);

    }

    public virtual string Validasyon()
    {
        string hataMesajı="";
        if ((this.Ad == "") || (this.Ad == null)){
            hataMesajı +="Ad alanın boş bırakılamaz" + Environment.NewLine;// bunun "\n" den farkı yok onun gibi aşağı gecmeye yarar
        }
        if (this.Fiyat == 0)
        {
            hataMesajı += "Fiyat alanı boş olamaz" + Environment.NewLine;//calışmasını istiyosansa + koymak zorundasun 
        }
        return hataMesajı;
    }



}

class Kitap:Urun 
        {
            public int ISBN { get; set; }
            public string Yazar { get; set; }

    public Kitap()
    {
        Random r = new Random();
        this.No = r.Next(0, 10000);
        
    }


    public override  string Validasyon()
                {
        string hataMesajı = base.Validasyon();
        if ((this.Yazar  == "") || (this.Yazar  == null))
        {
            hataMesajı += "Yazar alanın boş bırakılamaz" + Environment.NewLine;
        }
        if (this.ISBN  == 0)
        {
            hataMesajı += "ISBN alanı boş olamaz" + Environment.NewLine;
        }
        return hataMesajı;
    }



            }




class Telefon:Urun 
         {
            public string Marka { get; set; }
            public string Model { get; set; }
    public Telefon()
    {
        Random r = new Random();
        this.No = r.Next(0, 10000);
        
    }
    public override string Validasyon()
    {
        string hataMesajı =base.Validasyon();//bunu burada yazarak basecalass taki valıdayon metotunu cağırdık eğer demeseydik kendi bu sınıfa ayit metotu cağrırdık
        if ((this.Model  == "") || (this.Model == null))
        {
            hataMesajı += "Model alanın boş bırakılamaz" + Environment.NewLine;
        }
        if ((this.Marka  == "") || (this.Marka == null))
        {
            hataMesajı += "Marka alanı boş olamaz" + Environment.NewLine; 
        }
        return hataMesajı;
    }


}

class test
            {
               public static void Main(string[] args)
                {

                Urun u1 = new Urun();
        Console.Write("Ad girin : ");
               u1.Ad =Console.ReadLine();
        Console.Write("Ürün numarası girebilirmisin : ");

               u1.No = Convert.ToInt32 ( Console.ReadLine() );

        Console.WriteLine(u1.Validasyon());
        Console.WriteLine(u1.No.ToString());
          
                Kitap k2 = new Kitap();
        Console.Write("Kitap adı : ");
        k2.Ad = Console.ReadLine();
        Console.Write("Acıklama yapmak istermisiniz : ");
                k2.Acıklama =Console.ReadLine();
        Console.Write("Fiyat Giriniz : ");
                k2.Fiyat = Convert.ToInt32(Console.ReadLine());
        Console.Write("Kitap Numarası Giriniz :");
                k2.No = Convert.ToInt32(Console.ReadLine());
        Console.Write("Yazar adı Girin :  " );
                k2.Yazar = Console.ReadLine();
        Console.Write("ISBN Numarası Giriniz : ");
                k2.ISBN = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(k2.No.ToString());
        Console.WriteLine(k2.Validasyon() + u1.Validasyon());

        Telefon t3 = new Telefon();
        Console.Write("Telefo Adı Girin : ");
                t3.Ad = Console.ReadLine();
        Console.Write("Model : ");
                t3.Model = Console.ReadLine();
        Console.Write("Marka : ");
                t3.Marka = Console.ReadLine();
        Console.Write("Marka Numarasını Girin : ");
                t3.No =Convert.ToInt32( Console.ReadLine());
        Console.Write("Telefonun Fiyatını Girin : ");
                t3.Fiyat = Convert.ToInt32(Console.ReadLine());
        Console.Write("Bir Acıklama Yapmak istermisiniz : ");
                t3.Acıklama = Console.ReadLine() ;
        Console.WriteLine(t3.No.ToString());
        Console.WriteLine(t3.Validasyon() + u1.Validasyon());

        Console.ReadLine(); 
                }  
            }


