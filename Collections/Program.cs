using System;
using System.Collections;
using System.Collections.Generic;

public class MostRepeatedWord
{
    public static void Main()
    {
        String line, word = "";
        int count = 0, maxCount = 0;
       // ArrayList words = new ArrayList();
        var words = new List<string>();



        //Opens file in read mode  
        System.IO.StreamReader file = new System.IO.StreamReader(@"E:\TestFolder\Text11.txt");

        //Reads each line  
        while ((line = file.ReadLine()) != null)
        {
            String[] string1 = line.ToLower().Split(new Char[] { ',', '.', ' ', '-', }, StringSplitOptions.RemoveEmptyEntries);
            //Adding all words generated in previous step into words  
            foreach (String s in string1)
            {
                words.Add(s);
            }
        }

        //Determine the most repeated word in a file 
        for (int i = 0; i < words.Count; i++)
        {
            count = 1;
            //Count each word in the file and store it in variable count  
            for (int j = i + 1; j < words.Count; j++)
            {
                if (words[i].Equals(words[j]))
                {
                    count++;
                }
            }
            //If maxCount is less than count then store value of count in maxCount   
            //and corresponding word to variable word  
            if (count > maxCount)
            {
                maxCount = count;
                word = (string)words[i];
            }
        }

        Console.WriteLine("Most repeated word: " + word);
        file.Close();
    }
}