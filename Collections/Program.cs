using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


public class MostRepeatedWord
{
    public static void Main()
    {
        String line, word = "";
        int count = 0, maxCount = 0;
        var words = new List<string>();
        




        //Opens file in read mode  
        System.IO.StreamReader file = new StreamReader(@"E:\TestFolder\Text1.txt");

        //Reads each line  
        while ((line = file.ReadLine()) != null)
        {
            String[] string1 = line.ToLower().Split(new Char[] { ',', '.', ' ', '-', }, StringSplitOptions.RemoveEmptyEntries);
            //добавляем слова

            foreach (String s in string1)
            {
                words.Add(s);
            }
        }

        //ищем самый повтор слова в файле
        for (int i = 0; i < words.Count; i++)
        {
            count = 1;
            //считаем каждое слово в файле и сохраним его в переменной count
            for (int j = i + 1; j < words.Count; j++)
            {
                if (words[i].Equals(words[j]))
                {
                    count++;
                }
            }
         
            if (count > maxCount)
            {
                maxCount = count;
                word = (string)words[i];
            }
        }

        Console.WriteLine("самые повторяемые слова: " + word);
        file.Close();
    }
}