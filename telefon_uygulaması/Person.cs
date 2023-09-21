public class Person{
    private string ad;
    private string soyad;
    private string numara;

    public Person(){}

    public Person(string ad, string soyad, string numara){
        this.Ad=ad;
        this.Soyad=soyad;
        this.Numara=numara;
    }

    public string Ad {
        get { return ad; }
        set { ad = value;}
    }

    public string Soyad {
        get {return soyad;}
        set { soyad = value;}
    }

    public string Numara {
        get {return numara;}
        set { numara = value;}
    }
}