using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ResultItemManager : MonoBehaviour
{
    public static ResultItemManager resultItemManager;

    public List<UI_DropSlot> alldrops;
    public List<string> allID = new List<string>();


    private void Awake()
    {
        resultItemManager = this;
    }

    public  void Bake()
    {
        GameData.Craftresult result = new GameData.Craftresult();
        GameData.ResultItemData craft =GameData.instance.resultItemDatas.Find(x => x.carrierItemsData.MatchingTwoList(allID));
        if (craft == null)
        {
            result.craftResultType = GameData.CraftResultType.Fail;
            Debug.Log("OLMADIII");
        } 
        else
        {
            result.craftitem = craft.resultID;
      GameData.CarrierItemData findeddata= GameData.instance.allcarrieritems.Find(x => x.name == craft.resultID);
            ResultItem.instance.CreateResultItem(findeddata.icon);
            result.craftResultType = GameData.CraftResultType.Succes;
        }
        
     
    }
}
