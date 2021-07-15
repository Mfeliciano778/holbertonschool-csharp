using System;
using System.Collections.Generic;
class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> currNode = myLList.First;
        while (currNode.Next != null)
        {
            if (n < currNode.Next.Value)
            {
                currNode = myLList.AddAfter(currNode, n);
                return currNode;
            }
            currNode = currNode.Next;
        }
        currNode = myLList.AddLast(n);
        return currNode;
    }
}