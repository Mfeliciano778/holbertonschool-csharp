using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> DifferentElements(List<int> list1, List<int> list2)
        {
            HashSet<int> firstList = new HashSet<int>(list1);
            HashSet<int> secondList = new HashSet<int>(list2);
            firstList.SymmetricExceptWith(secondList);

            List<int> newList = new List<int>();
            foreach (int item in firstList)
                newList.Add(item);

            return newList;
        }
    }
