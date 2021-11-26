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
                Console.WriteLine("Enter the Program number which is to be executed \n 1. Unordered List \n 2. Ordered List  \n 3. Simple Balance Parethesis \n 4. Bank Cash Counter \n 5. PallinDrome-Checker  \n 6. Hashing Function to search  \n 7. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
       
                switch (option)
                {
                    case 1:
                        UnOrderedList list = new UnOrderedList();
                        list.UnOrdered();
                        break;
                    case 2:
                        flag = false;
                        break;
                        
                }
            }
        }
    }
        
}
