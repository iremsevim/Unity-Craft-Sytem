using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Worker
{

    public static bool MatchingTwoList<T>(this List<T> List1, List<T> List2)
    {
        //1-2-3-4 
        //2-3-1-4-6
        if (List1.Count != List2.Count) return false;

        bool result = false;
        int list_1 = List1.Count; //4
        int truecount = 0;

        for (int i = 0; i < List1.Count; i++)
        {
            for (int j = 0; j < List2.Count; j++)
            {
                if (List1[i].Equals(List2[j]))
                {
                    truecount++;
                    break;
                }
            }
        }
        result = truecount == list_1;
        return result;
    }
}
