using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultItem : MonoBehaviour
   
{
    public static ResultItem instance;
    public string ID;
    public Image �con;

    private void Awake()
    {
        instance = this;
    }

    public void CreateResultItem(Sprite _icon)
    {
        �con.sprite = _icon;
    }
}
