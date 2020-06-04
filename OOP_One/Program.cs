using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_One
{
    class Buyer
    {
        public string FirstName;
        public string LastName;
        public string Patronymic;
        internal string address;
        protected int CreditCardNumber;
        protected int BankAccountNumber;
        
    }

    class Subscriber
    {
        internal int IdNum;
        public string FirstName;
        public string LastName;
        public string Patronymic;
        internal string address;
        protected int CreditCardNumber;
        internal int Distance;   
    }

    class ZooShop
    {
        public string Animals;
        public string Names;
        public string Sex;
        public int Cost;
        internal int Quantity;
    }

    class TVSet
    {
        public int Channel = 0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            int Num = Convert.ToInt32(Console.ReadLine());

            switch (Num)
            {
                case 1:
                    {
                        Buyer BuyerOne = new Buyer();
                        Console.Write("Введите Имя покупателя: ");
                        BuyerOne.FirstName = Convert.ToString(Console.ReadLine());

                        Console.Write("Введите фамилию покупателя: ");
                        BuyerOne.LastName = Convert.ToString(Console.ReadLine());

                        Console.Write("Введите отчество покупателя: ");
                        BuyerOne.Patronymic = Convert.ToString(Console.ReadLine());

                        Console.Write("Введите адресс покупателя: ");
                        BuyerOne.address = Convert.ToString(Console.ReadLine());
                        Console.WriteLine(BuyerOne.FirstName + " " + BuyerOne.LastName + " " + BuyerOne.Patronymic + " " + BuyerOne.address);
                    }
                    break;

                case 2:
                    {
                        Subscriber SubscriberOne = new Subscriber();
                        Console.Write("Введите Имя абонента: ");
                        SubscriberOne.IdNum = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите Имя абонента: ");
                        SubscriberOne.FirstName = Convert.ToString(Console.ReadLine());

                        Console.Write("Введите фамилию абонента: ");
                        SubscriberOne.LastName = Convert.ToString(Console.ReadLine());

                        Console.Write("Введите отчество абонента: ");
                        SubscriberOne.Patronymic = Convert.ToString(Console.ReadLine());

                        Console.Write("Введите адресс абонента: ");
                        SubscriberOne.address = Convert.ToString(Console.ReadLine());

                        Console.Write("Введите Имя абонента: ");
                        SubscriberOne.Distance = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(SubscriberOne.FirstName + " " + SubscriberOne.LastName + " " + SubscriberOne.Patronymic + " " + SubscriberOne.address);
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("Сколько животных в зопарке");
                        int NumZoo = Convert.ToInt32(Console.ReadLine());

                        //var Zoo = new List<ZooShop>(NumZoo);

                        ZooShop[] Zoo = new ZooShop[NumZoo];

                        for (int i = 0; i < NumZoo; i++)
                        {
                            Zoo[i] = new ZooShop();
                            Console.Write("Введите животное " + (i + 1) + ": ");
                            Zoo[i].Animals = Console.ReadLine();
                            Console.Write("Введите имя " + (i + 1) + ": ");
                            Zoo[i].Names = Console.ReadLine();
                            Console.Write("Введите пол " + (i + 1) + ": ");
                            Zoo[i].Sex = Console.ReadLine();
                            Console.Write("Введите цену " + (i + 1) + ": ");
                            Zoo[i].Cost = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите количество " + (i + 1) + ": ");
                            Zoo[i].Quantity = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.Clear();
                        Console.WriteLine("Животное\tИмя\tПол\tЦена\tКоличество");

                        for (int i = 0; i < NumZoo; i++)
                        {
                            Console.WriteLine(Zoo[i].Animals + "\t\t" + Zoo[i].Names + "\t" + Zoo[i].Sex + "\t" + Zoo[i].Cost + "\t" + Zoo[i].Quantity);
                        }
                    }
                    break;

                case 4:
                    {
                        Console.WriteLine("Перелючение канала + либо - это 1\nПереключение канала по номеру это 2\nМаксимум 100 каналов\n Если хотите выйти из выбора канала введите для первого случая +--+ для второго 1111");
                        int NumTemp = Convert.ToInt32(Console.ReadLine());
                        TVSet Chan = new TVSet();
                        bool help = true;
                        if (NumTemp == 1)
                        {
                            while (help)
                            {
                                string StrTemp = Console.ReadLine();
                                if (StrTemp == "+")
                                {
                                    Chan.Channel++;
                                }
                                else if(StrTemp == "+--+")
                                {
                                    help = false;
                                }
                                else if (StrTemp == "+" && Chan.Channel == 100)
                                {
                                    Chan.Channel = 0;
                                }
                                else if (StrTemp == "-" && Chan.Channel == 0)
                                {
                                    Chan.Channel = 100;
                                }
                                else
                                {
                                    Chan.Channel--;
                                }
                                Console.WriteLine("Выбран канал " + Chan.Channel);
                                
                            }

                        }
                        else
                        {
                            while (help)
                            {
                                int temp = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Выбран канал " + temp);
                                if(temp == 1111)
                                {
                                    help = false;
                                }
                            }
                        }
                    }
                    break;
                    
            }
            Console.ReadKey();
        }
    }
}
