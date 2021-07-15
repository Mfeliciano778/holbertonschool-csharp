using System;
using System.Collections.Generic;
class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> currNode = myLList.First;
        while (currNode != null)
        {
            if (n < currNode.Value)
            {
                currNode = myLList.AddBefore(currNode, n);
                return currNode;
            }
            currNode = currNode.Next;
        }
        currNode = myLList.AddLast(n);
        return currNode;
    }
}