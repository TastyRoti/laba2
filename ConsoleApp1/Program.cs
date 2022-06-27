using System;
using System.Collections.Generic;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            void Task1()
            {
                Console.WriteLine("Завдання 1: ");
                Bird S = new Sitter("Ряба");
                S.Fly();
                S.Sing();
                S.Eggs();
                S.Child();
            
                
                Bird s = new Sitter("Ряба");
                Console.WriteLine(S.Equals(s));
           

                Bird s2 = new Sitter("Ряба2");
           

                Bird k = new Cuckoo("Ряба");
              


                
            }


            //////////////////////////////////////////////////////////////////



            void Task2()
            {
                List<Smartphone> Phones_list = new List<Smartphone>
                {
                    new Smartphone("Gallaxy A51", "Samsung", 6.5, 10000),
                    new Smartphone("iPhone 13", "Apple", 6.1, 29999),
                    new Smartphone("Redmi Note 11", "Xiaomi", 6.43, 8499),
                    new Smartphone("iPhone 11", "Apple", 6.1, 19999),
                    new Smartphone("Gellaxy S22", "Samsung", 6.1, 13999),
                    new Smartphone("Redmi 9A", "Xiaomi", 6.53, 4149)
                };

                Shop S = new Shop(Phones_list);
                Console.WriteLine("Total phones " + S.Number_of_phones());
                Shop S1 = new Shop(S.Sort_by_model("iPhone 13"));
                S1.Print_phones("Sorted by model: ");
                Shop S2 = new Shop(S.Sort_by_produser("Samsung"));
                S2.Print_phones("Sorted by producer: ");
                Shop S3 = new Shop(S.Sort_by_size(6.1));
                S3.Print_phones("Sorted by diagonal: ");
                Shop S4 = new Shop(S.Sort_by_price(5000, 10000));
                S4.Print_phones("Sorted by value: ");
                Shop S5 = new Shop(S.Find_by_parameters("Gallaxy A51", "Samsung", 6.5));             
                

            }




            Task1();
            Console.WriteLine("\n\n");
            Console.WriteLine("======================================================");
            Console.WriteLine("EX2:");
            Task2();

        }
    }
}