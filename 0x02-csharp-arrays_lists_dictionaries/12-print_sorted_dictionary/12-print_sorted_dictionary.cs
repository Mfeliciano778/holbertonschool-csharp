using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<String> keySort = new List<string>();
        int index = 0;

        foreach (string key in myDict.Keys)
        {
            keySort.Add(key);
        }
        keySort.Sort();
        foreach (KeyValuePair<String, String> outter in myDict)
        {
            foreach (KeyValuePair<String, String> item in myDict)
            {
                if (keySort[index] == item.Key)
                    Console.WriteLine(item.Key + ": " + item.Value);
            }
            index++;
        }
    }
}
