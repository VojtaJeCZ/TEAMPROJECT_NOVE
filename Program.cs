bool proceed = true;
string result = "";

while (proceed)
{
    Console.WriteLine("Zadej slovo");
    string userInput = Console.ReadLine();

    if (string.IsNullOrWhiteSpace (userInput))
    {                    
proceed = false;
    }
    result += userInput;
}
Console.WriteLine(result);









//bool proced = true;

//string veta = "";
//string userInput1;
//while (proced)
//{
//    Console.WriteLine("Zadej slovo");
//    userInput1 = Console.ReadLine();
//    if (string.IsNullOrWhiteSpace(userInput1))
//    {
//        proced = false;
//        Console.WriteLine(veta);
//    }
//    else
//    {
//        veta += userInput1;
//    }
//}



//bool proceed2 = true;
//while (proceed2)
//{
//    Console.WriteLine("Zadej slovo");
//    string slovo = Console.ReadLine();
//    Console.WriteLine(slovo + slovo);

//}

























//using System;

//class Program
//{
//    static void Main()
//    {


//        string veta = "";
//        string slovo;

//        do
//        {
//            Console.Write("Zadejte slovo: ");
//            slovo = Console.ReadLine();
//            if (!string.IsNullOrWhiteSpace(slovo))
//            {
//                veta += slovo;
//            }
//        } while (!string.IsNullOrWhiteSpace(slovo));

//        Console.WriteLine($"> {veta}");
//    }
//}
















//bool hodnota = true;
//while (hodnota)
//{
//    Console.WriteLine("Zadejte slovo");
//    string slovo = Console.ReadLine();

//    Console.WriteLine($"zadané slovo je: {slovo}");

//    Console.WriteLine("Zadejte slovo");
//    string slovo2 = Console.ReadLine();

//    Console.WriteLine($"zadané slovo je: {slovo2}");

//    Console.WriteLine("Zadejte slovo");
//    string slovo3 = Console.ReadLine();

//    Console.WriteLine($"zadané slovo je: {slovo3}");

//    Console.WriteLine("Zadejte slovo");
//    string slovo4 = Console.ReadLine();

//    Console.WriteLine($"zadané slovo je: {slovo4}");

//    Console.WriteLine($"vaše věta: {slovo} {slovo2} {slovo3} {slovo4}");
//}