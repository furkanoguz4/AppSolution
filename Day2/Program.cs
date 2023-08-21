
//Console.WriteLine("vize notunuz : ");
//double vize = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("final notunuz : ");
//double final = Convert.ToDouble(Console.ReadLine());

//double ort = (vize * 4 / 10) + (final * 6 / 10);

//Console.WriteLine("Ortalamanız : " + ort);

//if (ort >= 50)
//{
//    Console.WriteLine("geçtiniz");
//}
//else if (ort == 100)
//{
//    Console.WriteLine("Tam puan aldınız");
//}
//else
//{
//    Console.WriteLine("kaldınız");
//}
//Console.WriteLine("1. sayı  : ");
//double s1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("İşleminiz  : ");
//String @islem = (Console.ReadLine());

//Console.WriteLine("2. sayı  : ");
//double s2 = Convert.ToDouble(Console.ReadLine());

//if (@islem == "+")
//{
//    Console.WriteLine(s1 + s2);
//}
//else if (@islem == "*")
//{
//    Console.WriteLine(s1 * s2);
//}
//else if (@islem == "/")
//{
//    Console.WriteLine(s1 / s2);
//}
//else if (@islem == "-")
//{
//    Console.WriteLine(s1 - s2);
//}


//String[] meyveler = { "elma", "armut", "ayva", "domates" };
//foreach(var i in meyveler)
//{
//    Console.WriteLine(i);
//}

//int[] notlar = { 12, 45, 73, 21, 78 };
//for (int i = 0; i < notlar.Length; i++)
//{
//    Console.WriteLine(notlar[i]);
//}



//List<int> numbers = new() { 1,2,3,4,5,6,7,8,9};
//List<int> evennumbers = new();
//List<int> oddnumbers = new();

//// 1. yöntem
//foreach (var number in numbers)
//{
//    if (number % 2 == 0)
//    {
//       evennumbers.Add(number);
//    }
//    else
//    {
//        evennumbers.Add(number);
//    }
//}
////2. Yöntem 

//oddnumbers = numbers.FindAll(o => o % 2 != 0);
//evennumbers = numbers.FindAll(e => e % 2 != 0);     



//foreach (var number in oddnumbers)
//{
//    Console.WriteLine(number);
//}



//// tek satırlık foreachi öğren anni :)
///


// sıcaklığa göre durum ( if-else)

//Console.WriteLine("Sıcaklığınız : ");
//double temp = Convert.ToDouble(Console.ReadLine());

//if(temp < 0)
//{
//    Console.WriteLine("Katıdır");
//}
//else if (temp >0 || temp < 100)
//{
//    Console.WriteLine("Sıvıdır");
//}
//else
//{
//    Console.WriteLine("Gazdır");
//}


// while ;

for(int i = 20; i > 0; i--)
{
    
    if (i == 16)
    {
        continue;
    }
    Console.WriteLine(i);

}


//OOP

public class ogrenci
{

}




