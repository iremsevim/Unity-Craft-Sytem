using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Listener : MonoBehaviour
{
   public void ButtonClick(int ID)
    {
        switch(ID)
        {
            case 0:
                ResultItemManager.resultItemManager.Bake();
                break;
        }
    }
}
