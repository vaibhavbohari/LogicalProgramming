﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Coupan Number !");
Random random = new Random();

var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

var stringChars = new char[6];

for (int i = 0; i < stringChars.Length; i++)
{
    stringChars[i] = chars[random.Next(chars.Length)];
    Console.WriteLine(" Coupon Number " + stringChars[i]);
}


