using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_ChoosingItem : MonoBehaviour,IDragHandler,IPointerDownHandler,IPointerUpHandler
{

    public string ID;
    public Image ýmage;
    private RectTransform rect;
    private int index;
    public  Transform CARRÝER;
    
    public void Awake()
    {
        UI_Datas.Instance?.choosingitems.choosingItems.Add(this);
       
    }
    public void Start()
    {
        rect = ýmage.GetComponent<RectTransform>();
        index = transform.GetSiblingIndex();
    }
    public void OnDestroy()
    {
        UI_Datas.Instance?.choosingitems.choosingItems.Remove(this);
    }

    public void OnDrag(PointerEventData eventData)
    {
        rect.anchoredPosition += eventData.position/200;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.SetParent(CARRÝER);
        transform.SetAsLastSibling();
       
   
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        List<RaycastResult> list = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, list);
        foreach (var item in list)
        {
            if(item.gameObject.TryGetComponent(out UI_Craftýtem uI_Craftýtem))
            {
                Debug.Log(item.gameObject.name);
            }
        }
    }
}
