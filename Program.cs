// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.IO;
using System.Linq;

namespace AtmTransactions
{
    class AtmProject
    {
        //fields
    

        //methods
        static void Main()
        {
            Console.WriteLine("Please Enter Your Pin Number");
//Check for invalid pin, account number will be derived from reading card or pin number



            
 //Select an option - timeout if no action?         

 //           bool loop = true;
 //           while(loop)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("A: Make a Deposit");
                Console.WriteLine("B: Make a Withdrawal");
                Console.WriteLine("C: Display Amount in Account");
//              Console.WriteLine("D: Make a Money Transfer");
                Console.WriteLine("0: Exit.");

                string? choice = Console.ReadLine(); // the "?" makes it nullable

                switch(choice)
                {
                    case "A": // if (choice == "1")
                        float depositAMT = 0;
                        Console.WriteLine("Make A Deposit, Enter Amount to Deposit", depositAMT);
                        
                        break;

                    case "B":
                        float withdrawalAMT = 0;
                        Console.WriteLine("Withdrawal Amount");
// Check for sufficient funds in account
                        if (amtAccount < withdrawalAMT)
                        {
                            Console.WriteLine("Insufficient Funds, Would you like to withdraw a smaller amount");
//Check for smaller amount wanted and sufficient funds
                        }
                        else
                        {
//withdraw money from account, hand out cash, subtract withdrawal from amtAccount and print receipt                           
                        }                
                        break;

                    case "C":
//Ask if they want account amount displayed online or printed out
//Ask if they are finished with transaction
                        
                        if 
                        {
                            
                           
                         
                        
                        else
                        {
                            
                        } 
                       
                        break;

//                    case "D":
//Not certain if keep this in there                        
                        break;

                    case "0":
                        loop = false;
                        break;
                    
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
            Console.WriteLine("End of ATM Transaction");
        }





      

    }
}
