using System;
using System.Collections.Generic;
using System.Text;

namespace DS_Algorithm
{
    class BankingCashCounter
    {
        Utility.QueueList<string> List = new Utility.QueueList<string>();
        public void CashCounter()
        {
            int amount = 17000;

            Console.WriteLine("\n Type No. of People in a Queue  ");

            int number = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[number];

            Console.WriteLine("\n Type the People's Name ");

            for (int i = 0; i < number; i++)

            {
                names[i] = Console.ReadLine();
                List.Enqueue(names[i]);
            }
            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine("Customer: {0}", names[j]);

                Console.WriteLine("\n Choose Option\n 1.Deposit \n 2.Withdrawl");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n Enter a Amount to Deposit");
                        int deposit = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Amount Deposited = " + deposit);
                        amount = amount + deposit;

                        Console.WriteLine("Total Balance = " + amount);
                        List.Dequeue();
                        break;

                    case 2:
                        Console.WriteLine("\n Enter the Amount to Withdrawn");
                        int withdrawal = Convert.ToInt32(Console.ReadLine());
                        if (withdrawal <= amount && amount > 0)
                        {
                            Console.WriteLine("Amount Withdrawn = " + withdrawal);
                            amount = amount - withdrawal;

                            Console.WriteLine("Total Balance = " + amount);
                            List.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("\n Insufficient Funds");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\n Enter Correct Option");
                        break;
                }
            }
        }
    }
}
