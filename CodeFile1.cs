using System;
using System.Collections.Generic;

class Taras       //класс Тарас с полем футболка
{
    public string Shirt;
}

class MyClass          //главный класс
{
    public static readonly DateTime START_DATE = new DateTime(2022, 1, 1);   //время начала отсчета


    static void Main()                                   //главная функция
    {
        Taras taras = new Taras();                    //экземпляр класса Тарас
        DateTime realTime = new DateTime(2022, 1, 1);     //время которое будет менятся
        realTime = realTime.AddDays(1);                   
        string oldShirt;                                 //футболка Тараса в предедущий день
        int sum = 0;                                     //количество совпадений футболок
        for (int k = 0; k <= 10000; k++, realTime = realTime.AddDays(1))    
        {
            oldShirt = taras.Shirt;
            if ((realTime - MyClass.START_DATE).TotalDays % 2 == 0)  //если пройденых дней с начала отсчета четное колиество, то у Тараса будет синяя футболка
            {
                taras.Shirt = "Blue";    
            }
            else taras.Shirt = "Yellow";          //если не четное то желтая футболка

            if (oldShirt == taras.Shirt)               //нужно для проверки
            {
                Console.WriteLine("_____________________________________________________________");
                ++sum;
            }
            Console.WriteLine(realTime.ToString());    //время 
            Console.WriteLine(taras.Shirt);            //какя футболка на Тарасе

        }


    }
}