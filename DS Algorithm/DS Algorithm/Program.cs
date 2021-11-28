using System;

namespace DS_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the Program number which is to be executed \n 1. Unordered List \n 2. Ordered List  \n 3. Simple Balance Parethesis \n 4. Bank Cash Counter \n 5. PalinDrome-Checker  \n 6. Hashing Function to search  \n 7. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
       
                switch (option)
                {
                    case 1:
                        UnOrderedList list = new UnOrderedList();
                        list.UnOrdered();
                        break;
                    case 2:
                        OrderedList assending = new OrderedList();
                        assending.Ordered();
                        break;
                    case 3:
                        BalanceParanthesis paranthesis = new BalanceParanthesis();
                        paranthesis.Balance();
                        break;
                    case 4:
                        BankingCashCounter counter = new BankingCashCounter();
                        counter.CashCounter();
                        break;

                    case 5:
                        PalindromeChecker checker = new PalindromeChecker();
                        checker.Palindrome();
                        break;

                    case 6:
                        flag = false;
                        break;
                        
                }
            }
        }
    }
        
}
