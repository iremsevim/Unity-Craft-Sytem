using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_DropSlot : MonoBehaviour
{
    public string ID;

    public void Awake()
    {
        ResultItemManager.resultItemManager?.alldrops.Add(this);
    }
    public void OnDestroy()
    {
        ResultItemManager.resultItemManager?.alldrops.Remove(this);
    }

    public bool HasFull
    {
         get
        {
            return !string.IsNullOrEmpty(ID);
        }
    }
}
