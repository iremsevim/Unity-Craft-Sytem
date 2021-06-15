using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameData : MonoBehaviour
{
    public static GameData instance;
    public List<CarrierItemData> allcarrieritems;
    public AllCarrierDatas allCarrierDatas;
    public List<ResultItemData> resultItemDatas;

    public Craftresult result;


    public void Awake()
    {
        instance = this;
    }

    [System.Serializable]
    public struct AllCarrierDatas
    {
        public GameObject carrieritemPrefab;
        public Transform carrierPoint;
    }

    [System.Serializable]
    public struct CarrierItemData
    {
       
        public string name;
        public Sprite icon;

    }
    [System.Serializable]
    public class ResultItemData
    {
        public string resultID;
        public List<string> carrierItemsData;
       
    }
    [System.Serializable]

    public class Craftresult
    {
        public CraftResultType craftResultType;
        public string craftitem;
    }
    public enum CraftResultType
    {
        Succes = 0,
        Fail = 1
    }

}
