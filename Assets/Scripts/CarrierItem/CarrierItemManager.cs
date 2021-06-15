using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrierItemManager : MonoBehaviour
{
    public void Start()
    {
        ShowCarrierItem();
    }
    public void ShowCarrierItem()
    {
        foreach (Transform item in GameData.instance.allCarrierDatas.carrierPoint)
        {
            Destroy(item.gameObject);
        }

        foreach (var item in GameData.instance.allcarrieritems)
        {
            GameObject createdcarrieritem = Instantiate(GameData.instance.allCarrierDatas.carrieritemPrefab, GameData.instance.allCarrierDatas.carrierPoint.position, Quaternion.identity, GameData.instance.allCarrierDatas.carrierPoint);
            createdcarrieritem.GetComponent<CarrierItem>().LoadItemData(item.name, item.icon,item.name);
        }
    }


}
