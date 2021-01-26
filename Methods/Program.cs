using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            int result = Add2(15, 21);
            Console.WriteLine(result);
            Console.WriteLine("------------");

            int number1 = 20;
            int number2 = 100;
            int result2 = Add3(ref number1, number2); //ref keywordü ile değer tip yerine referans tip olarak kullanım sağlar
            //Yani değer tipi referans tip olarak göndermektir.
            //ref yerine out yazarsak yine değer tip yerine referans tip olarak gönderiririz.
            //ref ile out farkı tip tanımlamada değeri başta set etme ihtiyacı varsa ref kullanılır.
            //Burada out kullanıp değer set edilirse method kullanıldığında yine method içerisinde değer set etme zorunluluğu olur. 
            //Buda ilk set edilen değeri geçersiz ve gereksiz kılar.
            Console.WriteLine(result2);
            Console.WriteLine(number1); //referans olduğundan değeri metot içinde değiştirlen değer olur =30
            Console.WriteLine("------------");
            Console.WriteLine("----Overload--------");
            Console.WriteLine(Multiply(2, 3));
            Console.WriteLine(Multiply(4, 5, 6));
            Console.WriteLine("----------------");
            Console.WriteLine(Add4(1, 2, 4, 54, 2)); //İstediğimiz kadar değer girip Add4 ün işlem yapmasını sağlarız.


        }
        static void Add()
        {
            Console.WriteLine("Added! ");
        }
        static int Add2(int number1 = 7, int number2 = 9) //Parametre gönderilmezse buradaki default değerleri kullanır.
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(ref int number1, int number2)
        {
            number1 = 30; //ref olarak tanımlandığından ve çağırıldığından maindeki number1 de 30 olur.
            return number1 + number2;
        }
        //İsimleri aynı parametreleri farklı olan metotlara overload denir. Gelen parametre hangisiyle eşleşiyorsa o çalışır.
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static int Add4(params int[] numbers) //Parametreleri aynı tip ama farklı sayılarda methodlar varsa overload çok uzun ve karmaşık olur onun yerine
           //params kullanılarak kaç parametreli gelirse gelsin hepsine dizi gelmiş gibi işlem yapar. 
        {

            return numbers.Length;
            
        }

    }
}
