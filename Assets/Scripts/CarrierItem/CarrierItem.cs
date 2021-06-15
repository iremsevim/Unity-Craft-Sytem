using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CarrierItem : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public Text name;
    public Image icon;
    private RectTransform rect;
    public string ID;
    private Vector3 firstPos;

    public void Awake()
    {
        rect = icon.GetComponent<RectTransform>();
        firstPos = rect.localPosition;
    }


    public void LoadItemData(string _name, Sprite _icon, string _ID)
    {
        name.text = _name;
        icon.sprite = _icon;
        ID = _ID;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rect.anchoredPosition += eventData.delta;
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        List<RaycastResult> resultlist = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, resultlist);
        foreach (var item in resultlist)
        {

            if (item.gameObject.TryGetComponent(out UI_DropSlot droplslot))
            {
                if (!droplslot.HasFull)
                {
                    droplslot.ID = ID;
                    ResultItemManager.resultItemManager.allID.Add(droplslot.ID);
                }

                else
                {
                    rect.localPosition = firstPos;
                }


            }


        }
     
    }
}

