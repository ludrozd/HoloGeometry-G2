using System;
using System.Collections.Generic;
using System.ComponentModel;

[Description("Class made for managing random numbers for quiz")]
public class RandomQuiz
{
    public static List<int> ReturnRandomNumberSet(int size)
    {
        List<int> randomNumbersSet = new List<int>();
        Random r = new Random();
        int randomNumber;
        for(int i=0; i<size; i++)
        {
            do
                randomNumber = r.Next(0, size);
            while (!randomNumbersSet.Contains(randomNumber));
            randomNumbersSet.Add(randomNumber);
        }
        return randomNumbersSet;
    }
}
