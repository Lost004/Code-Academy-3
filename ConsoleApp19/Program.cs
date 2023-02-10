﻿using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Pharmacy pharmacy = new Pharmacy();
            string opt;
            do
            {
                Console.WriteLine("\n1.Derman yarat");
                Console.WriteLine("2.Dermanlara bax");
                Console.WriteLine("3.Endirimli dermanlari goster");
                Console.WriteLine("4.Verilmis endirim araliginda olan dermanlari goster");
                Console.WriteLine("5.Verilmis kateqoriya ucun dermanlari goster");
                Console.WriteLine("6.Verilmis kateqoriyada stokda nece dene derman qalib");
                Console.WriteLine("0.Proses bitdi");

                Console.WriteLine("\nSecim edin!");

                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("Derman adi qeyd edin:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Category:");
                        string category = Console.ReadLine();

                        Console.WriteLine("Price:");
                        string priceStr = Console.ReadLine();
                        double price = Convert.ToDouble(priceStr);

                        Console.WriteLine("Discount price:");
                        string discountStr = Console.ReadLine();
                        double discount = Convert.ToDouble(discountStr);

                        Medicine medicine = new Medicine
                        {
                            Name = name,
                            Price = price,
                            Category = category,
                            DiscountPrice = discount,
                        };
                        pharmacy.AddMedicine(medicine);
                        
                    break;

                    case "2":
                        for ( int i = 0; i < pharmacy.Medicines.Length; i++)
                        {
                            Console.WriteLine($"\nName: {pharmacy.Medicines[i].Name}");
                            Console.WriteLine($"Price: {pharmacy.Medicines[i].Price}");
                            Console.WriteLine($"Discount: {pharmacy.Medicines[i].DiscountPrice}");
                            Console.WriteLine($"Category: {pharmacy.Medicines[i].Category}");
                        }
                    break;

                    case "3":
                        for (int i = 0; i < pharmacy.Medicines.Length; i++)
                        {
                            if (pharmacy.Medicines[i].DiscountPrice > 0)
                            {
                                Console.WriteLine($"\nName: {pharmacy.Medicines[i].Name}");
                                Console.WriteLine($"Price: {pharmacy.Medicines[i].Price}");
                                Console.WriteLine($"Discount: {pharmacy.Medicines[i].DiscountPrice}");
                                Console.WriteLine($"Category: {pharmacy.Medicines[i].Category}");
                               
                            }
                        }
                        break;

                    case "4":
                        Console.WriteLine("Min deyer daxil edin!:");
                        string numstr1 = Console.ReadLine();
                        var min = Convert.ToInt32(numstr1);

                        Console.WriteLine("Max deyer daxil edin!:");
                        string numstr2 = Console.ReadLine();
                        var max = Convert.ToInt32(numstr2);


                        for (int i = 0; i < pharmacy.Medicines.Length; i++)

                        {
                            if (pharmacy.Medicines[i].DiscountPrice > min && pharmacy.Medicines[i].DiscountPrice < max)
                            {
                                Console.WriteLine($"\nName{pharmacy.Medicines[i].Name}");
                                Console.WriteLine($"Price{pharmacy.Medicines[i].Price}");
                                Console.WriteLine($"DiscountPrice{pharmacy.Medicines[i].DiscountPrice}");
                                Console.WriteLine($"Category{pharmacy.Medicines[i].Category}");
                            }

                        }
                        break;

                    case "5":
                        Console.WriteLine("Bas agri dermani");
                        string Vusal = Console.ReadLine();
                        for (int i = 0; i < pharmacy.Medicines.Length; i++)
                        {
                            if (pharmacy.Medicines[i].Category.Contains(Vusal))
                            {
                                Console.WriteLine($"\nName{pharmacy.Medicines[i].Name}");
                                Console.WriteLine($"Price{pharmacy.Medicines[i].Price}");
                                Console.WriteLine($"DiscountPrice{pharmacy.Medicines[i].DiscountPrice}");
                            }
                        }
                     
                    break;

                    case "6":
                        Console.WriteLine( "kateqoriya daxil edin");
                        string categoryy = Console.ReadLine();
                        int count = 0;
                        for (int i = 0; i < pharmacy.Medicines.Length; i++)
                        {
                            if (pharmacy.Medicines[i].Category==categoryy)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine($"Bu kateqoriyada {count} derman qalib");
                        break;

                    case "0":
                        Console.WriteLine("Proses bitdi");
                    break;

                    default:
                        Console.WriteLine("Secim duzgun deyil!");
                        break;
                }


            }
            while (opt != "0");
        }
    }
}
