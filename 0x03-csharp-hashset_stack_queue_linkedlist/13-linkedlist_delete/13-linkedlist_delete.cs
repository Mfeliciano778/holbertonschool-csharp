﻿using System;
using System.Collections.Generic;
class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int idx = 0;

        foreach (int item in myLList)
        {
            if (idx == index)
            {
                myLList.Remove(item);
                break;
            }
            idx++;
        }
    }
}
