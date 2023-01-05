using System;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook asus = new Notebook
            {
                Name = "Asus",
                Price = 2000,
                RAM = 5,
                Storage = 256

            };
            Notebook hp = new Notebook
            {
                Name = "Hp",
                Price = 3500,
                RAM = 10,
                Storage = 300

            };
            Notebook acer = new Notebook
            {
                Name = "Acer",
                Price = 1780,
                RAM = 7,
                Storage = 700

            };

            Phone iphone = new Phone
            {
                Name = "Iphone",
                Price = 720,
                SimCount = 2
            };

            Product[] products = { iphone, acer, hp, asus };

            string numStr;
            do
            {
                Console.WriteLine("\n1. Butun mehsullara bax\n");
                Console.WriteLine("\n2. Notebooklara bax\n");
                Console.WriteLine("\n3. Telefonlara bax\n");
                Console.WriteLine("\n4. Notebooklarin sayina bax\n");
                Console.WriteLine("\n5. Telefonlarin sayina bax\n");
                Console.WriteLine("\n6. Notebooklarin ortalama qiymetine bax\n");
                Console.WriteLine("\n7. Telefonlarin ortalama qiymetine bax\n");
                Console.WriteLine("\n0. Cix\n");
                numStr = Console.ReadLine();

                switch (numStr)
                {
                    case "1":
                        ShowAllProducts(products);
                        break;
                    case "2":
                        ShowAllNotebooks(products);
                        break;
                    case "3":
                        ShowAllPhones(products);
                        break;
                    case "4":
                        Console.WriteLine("\n Notbuklarin sayi: ", GetNotebookCount(products));
                        break;
                    case "5":
                        Console.WriteLine("\n Telefonlarin sayi: ", GetPhoneCount(products));
                        break;
                    case "6":
                        Console.WriteLine("\n Notbuklarin ortalama qiymeti: ", GetNotebookPriceAvg(products));
                        break;
                    case "7":
                        Console.WriteLine("\n Telefonlarin ortalam qiymeti: ", GetPhonePriceAvg(products));
                        break;
                    case "0":
                        Console.WriteLine("Menudan cixdiniz ");
                        break;
                    default:
                        Console.WriteLine("Duzgun secim daxil edin!");
                        break;
                }

            } while (numStr != "0");
        }

        static void ShowAllProducts(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] is Notebook)
                {
                    var nt = products[i] as Notebook;
                    Console.WriteLine($"\n Notbukun adi: {products[i].Name} - Notbukun qiymeti: {products[i].Price} - Notbukun RAM'i: {nt.RAM} - Notbukun yaddasi: {nt.Storage}");
                }
                else if (products[i] is Phone)
                {
                    var ph = products[i] as Phone;
                    Console.WriteLine($"\n Telefonun adi: {products[i].Name} - Telefonun qiymeti: {products[i].Price} - Telonun sim sayi: {ph.SimCount}");
                }
                else
                    Console.WriteLine($"\n Produktun adi: {products[i].Name} - Produktun qiymeti: {products[i].Price}\n");
            }

        }

        static void ShowAllNotebooks(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {

                if (products[i] is Notebook)
                {
                    var nt = products[i] as Notebook;
                    Console.WriteLine($"\n Notbukun adi: {products[i].Name} - Notbukun qiymeti: {products[i].Price} - Notbukun RAM'i: {nt.RAM} - Notbukun yaddasi: {nt.Storage}\n");
                }
            }
        }
        static void ShowAllPhones(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] is Phone)
                {
                    var ph = products[i] as Phone;
                    Console.WriteLine($"\n Telefonun adi: {products[i].Name} - Telefonun qiymeti: {products[i].Price} - Telonun sim sayi: {ph.SimCount}\n");
                }
            }
        }

        static int GetNotebookCount(Product[] products)
        {
            int notebookCount = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] is Notebook)
                {

                    notebookCount++;
                }
            }
            return notebookCount;
        }

        static int GetPhoneCount(Product[] products)
        {
            int phoneCount = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] is Phone)
                {
                    phoneCount++;
                }
            }
            return phoneCount;
        }

        static double GetNotebookPriceAvg(Product[] products)
        {
            double sum = 0;
            int count = 0;

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] is Notebook)
                {
                    count++;
                    sum += products[i].Price;
                }
            }
            return sum / count;
        }

        static double GetPhonePriceAvg(Product[] products)
        {
            double sum = 0;
            int count = 0;

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] is Phone)
                {
                    count++;
                    sum += products[i].Price;
                }
            }
            return sum / count;
        }











        //public static bool HasDigit(string input)
        //{
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        if (char.IsDigit(input[i]))
        //Console.WriteLine("Hello World!");
        //string aa = MakeNewString("aa  aaaa      aaaaa");
        //Console.WriteLine(aa);

        //            return true;

        //    }
        //    return false;
        //}

        //public static string MakeNewString(string input)
        //{
        //    string newstr = "";


        //    input = input.Trim();

        //    string[] splitted = input.Split(' ');

        //    for (int i = 0; i < splitted.Length; i++)
        //    {
        //        if (i != splitted.Length)
        //        {
        //            if (splitted[i] != "")
        //            {
        //                splitted[i].Trim();
        //                newstr += splitted[i];
        //                newstr += ' ';

        //            }

        //        }
        //    }

        //    return newstr;

        //}
    }
}
