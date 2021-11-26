using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DS_Algorithm
{
    class BalanceParanthesis
    {
        public void Balance()
        {
            Utility.QueueList<string> QL = new Utility.QueueList<string>();
            string NumfilePath = File.ReadAllText(@"D:\DS AlgorithmProgram\DS-Algorithm-And-Programming\DS Algorithm\DS Algorithm\Utility\Arithmatic.txt");

            string[] words = NumfilePath.Split(",");

            foreach (var result in words)
            {
               // if (result == "(")
                {
                 //   QL.Push("(");
                }

               // else
                {
                  //  QL.Pop(")");
                }

                //if (QL.IsEmpty())
                {
                    Console.WriteLine(" Is Balanced Paranthesis");
                }

                //else
                {
                    Console.WriteLine("Is Not a Balanced Paranthesis");
                }
            }
        }
    }
}
