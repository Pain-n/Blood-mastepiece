﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ItemVisual : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    private Item itemAsset;
    private ItemVisual SelectedItem;
    public void Init(Item item)
    {
        itemAsset = item;
        GetComponent<Image>().sprite = item.Sprite;

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GetComponentInParent<InventoryPanel>().Drag_drop(itemAsset);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponentInParent<InventoryPanel>().ShowInfo(itemAsset);
    }

    public void OnPointerExit (PointerEventData eventData)
    {
        GetComponentInParent<InventoryPanel>().HideInfo();
    }
}
