namespace generic_list;
class Program
{
    static void Main(string[] args)
    {
        List<int> sayilar=new List<int>();
        sayilar.Add(5);
        sayilar.Add(2);
        sayilar.Add(13);
        sayilar.Add(51);
        sayilar.Add(15);
        sayilar.Add(3);

        List<string> renkler=new List<string>();
        renkler.Add("Mavi");
        renkler.Add("Yeşil");
        renkler.Add("Sarı");
        renkler.Add("Kırmızı");
        renkler.Add("Kahverengi");

        //count ile eleman sayısı
        Console.WriteLine(renkler.Count);
        Console.WriteLine(sayilar.Count);

        //Foreach 
        sayilar.ForEach(sayi => Console.WriteLine(sayi));
        renkler.ForEach(renk=> Console.WriteLine(renk));

        //Remove ile eleman çıkarma
        renkler.Remove("Kırmızı");
        sayilar.Remove(2);

        sayilar.ForEach(sayi=> Console.WriteLine(sayi));
        renkler.ForEach(renk=> Console.WriteLine(renk));

        //Arama
        if(sayilar.Contains(51))Console.WriteLine("51 listede var!");

        //değer ile indexe erişme
        Console.WriteLine(renkler.BinarySearch("Kahverengi"));

        //diziyi liste çevirme
        string[] çiçekler={"leylak","papatya","nane"};
        List<string> cicekler=new List<string>(çiçekler);

        //temizleme
        cicekler.Clear();

        //List ile nesne
        List<Humans> humanList= new List<Humans>();
        Humans human1=new Humans();
        human1.Isim="Metehan";
        human1.Soyisim="Metinoğlu";
        human1.Yas=25;

        Humans human2=new Humans();
        human2.Isim="Ömer Talha";
        human2.Soyisim="Metinoğlu";
        human2.Yas=22;
        humanList.Add(human1);
        humanList.Add(human2);

        List<Humans> newList=new List<Humans>();

        newList.Add(new Humans(){
            Isim="Emriye",
            Soyisim="Metinoğlu",
            Yas=50
        });

        foreach (var human in humanList)
        {
            Console.WriteLine(human.Isim);
            Console.WriteLine(human.Soyisim);
            Console.WriteLine(human.Yas);
        }
        newList.Clear();


    }
    public class Humans{
        string isim;
        string soyisim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
