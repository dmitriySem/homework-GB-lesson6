using System;

class lesson5{

    static void Main(){
        Console.Clear();
        //firstTask();
        //secondTask();
        thirdTask();
    }
    //Задача 1: Задайте двумерный массив символов (тип char [,]). 
    //Создать строку из символов этого массива.
    static void firstTask(){
        Console.Clear();

        Random rand = new Random();
        int endI = rand.Next(1, 20);
        int endJ = rand.Next(1, 20);

        char[ , ] array = new char [endI,endJ];
        for(int i = 0; i < endI; i++){
                for (int j = 0; j < endJ; j++){
                    array[i, j] = (char)rand.Next(0x0410, 0x44F);
                    Console.Write(array[i, j] + " ");
                }                             
                Console.WriteLine();
        }

        string s10 = "";
        foreach(char ch in array)
            //s10 = string.Join(s10, ch);
            s10 = s10 + ch;

        Console.WriteLine($"Строка: {s10}"); 

    }
    //Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
    //Сформируйте строку, в которой все заглавные буквы заменены на строчные.
    static void secondTask(){
        Console.Clear();

        Random rand = new Random();
        string str = "";

        int lengthStr = rand.Next(1, 20);


        for(int i = 0; i < lengthStr; i++)
            str = str +  (char)rand.Next(0x0041, 0x007A);


        Console.WriteLine($"Исходная строка: {str} "); 
        Console.WriteLine($"Преобразованная строка: {str.ToLower()} "); 
    }

    //Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
     static void thirdTask(){

        Console.Clear();

        //Random rand = new Random();
        string str = "papa";

        /*int lengthStr = rand.Next(1, 20);


        for(int ii = 0; ii < lengthStr; ii++)
            str = str +  (char)rand.Next(0x0041, 0x007A);
        */

    
        int i = 0, j = str.Length - 1;
        while (i < j)
            if (str[i++] != str[j--]) 
                Console.WriteLine($"Строка: {str} не является палиндромом"); 
            else 
                Console.WriteLine($"Строка: {str}  является палиндромом");
        
     }


}