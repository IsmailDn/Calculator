namespace Hesapmakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. sayıyı giriniz: ");
            var sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı giriniz: ");
            var sayi2 = Convert.ToInt32(Console.ReadLine());


            var toplam = (sayi1 + sayi2);
            var fark = (sayi1 - sayi2);
            var carpım = (sayi1 * sayi2);
            var bolme = (sayi1 / sayi2);

            Console.WriteLine("Toplam : " + toplam);
            Console.WriteLine("Fark : " + fark);
            Console.WriteLine("Çarpım : " + carpım);
            Console.WriteLine("Bölme : " + bolme);





        }
    }
}
