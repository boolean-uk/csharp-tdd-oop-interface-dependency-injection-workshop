﻿using workshop.console.Examples.Calculator;
using workshop.console.Examples.Calculator.Interfaces;
using workshop.console.Examples.Car;
using workshop.console.Examples.Car.Engines;
using workshop.console.Examples.ConsoleOrSpeak;
using workshop.console.Examples.Shop;

Console.WriteLine("Hello Interfaces....");


//starts with an I then a capital letter!

//Calculator
//AddCalc calc = new AddCalc();
//MultiplyCalc calc = new MultiplyCalc();
//Calculator calculator = new Calculator(calc);
//Console.WriteLine(calculator.Calculate(5, 4));



//ConsoleOrSpeak

Communicate comms = new Communicate();
comms.SendMessage("hello having fun on a monday");


//Shop

//Basket basket = new Basket();
//Guitar guitar1 = new Guitar() { Id=1, Name="Gibson SG", Price=1200.99M};
//IProduct guitar2 = new Guitar() { Id =2, Name = "Fender Stratocaster", Price = 899.99M };
//IProduct drums = new Drums() { Id = 3, Name = "Pearl Export", Price = 1400.95M, ComesWithFreeSticks = true };

//basket.AddProduct(guitar1);
//basket.AddProduct(guitar2);
//basket.AddProduct(drums);

//Console.WriteLine(basket.BasketTotal);




//car example
//Beetle beetle = new Beetle(new PetrolEngine());
//beetle.Start();
//beetle.Drive();
