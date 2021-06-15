using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Datas : Singleton<UI_Datas>
{
    public List<UI_CraftItemDatas> allcrafts;
    public List<ResultCraftItem> allresults;
    public ChoosingItem choosingitems;

    [System.Serializable]
   public class UI_CraftItemDatas
    {
        public string ID;
        public Sprite ýmage;
    }
    [System.Serializable]
    public class ResultCraftItem
    {
        public Sprite resultýmage;
        public List<string> necessaryitemID;
      
    }
    [System.Serializable]
    public class ChoosingItem
    {
        public List<UI_ChoosingItem> choosingItems;
       
    }
}
