using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int num = 0;
        foreach (KeyValuePair<string, string> pair in myDict)
        {
            num += 1;
        }
        return num;
    }
}
