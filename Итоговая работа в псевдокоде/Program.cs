using System;
using static System.Console;

string[]array = {"Hello,",  "2,",  "world,",   "1234,",     "1567,", "123,", "qws", "+_)", "computer science,"};       
WriteLine();  //Создаём массив строк array содердажащий некоторые значения
MethodCreateInputArray(array); //Выводим метод первый 
WriteLine();
MethodCreateOutputArray(array);//Выводим метод второй 
WriteLine();//Результат работы выводится в консоль при dotnet new console 


void MethodCreateInputArray(string[] InputArray) //Функция MethodCreateInputArray принимает массив строк InputArray 
{                                                //в качестве аргумента и выводит все его элементы на экран. Она 
    Write($"InputArray: ");                      //использует цикл for для пробега по всем элементам массива и
    for (int i = 0; i < InputArray.Length; i++)  //выводит каждый элемент строкой.
    {
        Write($"{InputArray[i]}");
    }
}

void MethodCreateOutputArray(string[] OutputArray) //Функция MethodCreateOutputArray также принимает массив строк
{                                                  //OutputArray в качестве аргумента и выводит только те элементы, 
    Write($"Output array: ");                      //которые содержат не более трех символов. Она также использует цикл 
    string[] newarr = new string[OutputArray.Length];//for, чтобы пробежаться по всем элементам массива. Используя 
    for (int i = 0; i < OutputArray.Length; i++)    //условную конструкцию if, она проверяет длину каждого элемента и
    {                                               //если он содержит не более трех символов, выводит его на экран.
        if (OutputArray[i].Length <=3)
        {
            newarr[i] = OutputArray[i];
            Write($"{newarr[i]}");
        }
    }
    WriteLine();
}

//В данном алгоритме ничего не возвращается т.к используем void методы