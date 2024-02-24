//1. Doira yuzi va aylana uzunligini hisoblash

Console.WriteLine("Radiusni kiriting: ");
double radFirst = Convert.ToDouble(Console.ReadLine());
decimal rad = (decimal)radFirst;
double pi = Math.PI;
decimal piBig = (decimal)pi;
decimal aylanaS = piBig * rad * rad;
decimal aylanaL = 2 * piBig * rad;
Console.WriteLine($"S= {aylanaS}");
Console.WriteLine($"L= {aylanaL}");

//2.  Valyuta konvertri

System.Console.WriteLine("qiymatni kiriting: ");
double qiymat= Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("valyuta qiymatini kiriting: ");
double valyuta= Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine($"Qiymat= {qiymat} kurs= {valyuta}");
System.Console.WriteLine($"{qiymat*valyuta} so\'m");

//3. yoshni hisob


System.Console.WriteLine("Iltimos yilingizni kiriting: ");
int yilIngiz = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{(2023 - yilIngiz)*365} kun");

