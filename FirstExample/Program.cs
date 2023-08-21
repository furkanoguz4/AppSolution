// See https://aka.ms/new-console-template for more information


//***** ömerden sonraki *****


// Değer tipler , Referans Tipler 
// Değer tipler : bool (Doğruluk değeri tutan veri tipidir.)
// int : sayısal değerler tutar.
// Float veya Double : Ondalıklı sayı tutar.
// Sayısal Değerler
//int sayi1 = 10;
//Console.WriteLine(sayi1);

//bool
//bool dogruluk = false;
//bool dogruluk1= true;
//Console.WriteLine(dogruluk1);
//Console.WriteLine(dogruluk);
// Değer Tiplerin Özellikleri
// Hafızanın stack kısmında tutulur.
// null değer alamazlar.
//int? sayi2=null;
//Console.WriteLine(sayi2);
// Referans Tipler 
// Hafızanın Heap kısmında tutulur
// string, Array,HashMap,List,class, interface 


//string metin = " İlk metin örneği";
//Console.WriteLine(metin);
//todo: iki tane dğişken olsun ve bu 2 değişkeni toplasın ekrana bastırsın. 
int a = 10;
int b = 15;
int toplam = a + b;
// 1.Senaryo
Console.WriteLine(toplam);
// 2. Senaryo 
Console.WriteLine("iki sayının toplamı = " + a + "+" + b + "= " + toplam);
// String interpolation
Console.WriteLine($"iki sayının toplamı = {a} + {b} = {toplam}");
//metin1metin2
string metin1 = "metin1";
string metin2 = "metin2";
string birlestirilmisMetin = metin1 + metin2;
Console.WriteLine(birlestirilmisMetin);

//Stringden sonra int değer istersek 
Console.WriteLine("İki sayının toplamı" + a + b);
Console.WriteLine(a + b);


char aa = 'A';
Console.WriteLine((int)aa);

string example = "Küçük Büyük veya String örneği";
// Stringin içindei her karakteri büyük harf yapar.
Console.WriteLine(example.ToUpper());
//Stringin içindei her karakteri küçük harf yapar.
Console.WriteLine(example.ToLower());
// K harfi ile başlıyor mu
Console.WriteLine(example.StartsWith("k"));

// O harfi ile bitiyormu
Console.WriteLine(example.EndsWith("O"));

// metnin ilk 4 harfini ekrana bastırsın.
Console.WriteLine(example[..4]);

// metinin ilk 4 hanesinden swonraki bütün karakterleri getir
Console.WriteLine(example[3..]);
Console.WriteLine(example.GetType());

// kod satırları sırasıyla toplama çıkarma bölme ve çarpma işlemleri yapsın sonuç olarak

// iki sayının çarpımı ....
// formül : kilo/ boy*boy

Console.WriteLine("Boyunuz :");
int     boy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kilonuz ");
int kilo = Convert.ToInt32(Console.ReadLine());


double endex = kilo / Math.Pow(boy,2); // boy*boy



// *** Dairenin Çevresini ve alanını hesaplayan kodları yazınız ***
// alan : pi * r^2
// çevre : 2*pi*r
//  Console.WriteLine("yaricap : ");
//  double r = Convert.ToDouble(Console.ReadLine());

//  double pi = 3.14;

//  double cevre = 2 * pi * r;
//  Console.WriteLine("cevre :" + cevre);
//  double alan = pi * r * r;
//  Console.WriteLine("alan :" + alan);

//Math Fonksiyonu ile
double yaricap = 10.0;
double pi = Math.PI;
double alan = pi * Math.Pow(yaricap, 2);
double cevre = 2 * pi * yaricap;
Console.WriteLine($" yarıçapı : \n {yaricap} olan dairenin alanı : {alan}");
Console.WriteLine("çevresi : " + cevre);

Console.ReadLine();


