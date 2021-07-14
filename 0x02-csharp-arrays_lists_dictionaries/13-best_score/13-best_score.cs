using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count < 0)
            return "None";
        string maxKey = "";
        int max = 0;

        foreach (KeyValuePair<String, int> item in myList)
        {
            if (item.Value > max)
            {
                max = item.Value;
                maxKey = item.Key;
            }
        }
        return maxKey;
    }
}
