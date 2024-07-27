
﻿using Microsoft.Extensions.DependencyInjection;
using BankApp.Controller;
using BankApp.Repository;
using BankApp.Service;
using System;
using Microsoft.Data.SqlClient;

namespace BankApp;

    public class Program
    {
        public static void Main(string[] args)
        {
             
             
            var serviceProvider = new ServiceCollection()
                .AddScoped<IBankAccountRepository, BankAccountRepository>() // Register interface and implementation
                .AddScoped<BankAccountService>() // Register BankAppService
                .AddScoped<BankAccountController>() // Register BankAppController
                .BuildServiceProvider();

            
            var controller = serviceProvider.GetService<BankAccountController>();

            
            if (controller != null)
            {
                try{

                
                controller.Run();
                
                }catch(SqlException ex){
                   
                    Console.WriteLine("SQL Server Error");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(1);
                
                }catch(Exception ex){

                    Console.WriteLine("None SQL Related Error.");
                    Console.WriteLine("Closing the application");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(1);
                }
            }
            else
            {
                Console.WriteLine("Controller Issue"); 
                
            }

        }
    }
