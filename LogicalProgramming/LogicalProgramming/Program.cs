﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Fibonacci Series !");


    {
        int n1 = 0,
        n2 = 1, 
        n3, i, 
        number;
        Console.Write("Enter the number of elements: ");
       number= Convert.ToInt32(Console.ReadLine());
        Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
        for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
        {
            n3 = ( n1 + n2);
            Console.Write(n3 + " ");
            n1 = n2;
            n2 = n3;
        }
    }
