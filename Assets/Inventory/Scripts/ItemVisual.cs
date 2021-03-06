﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ItemVisual : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Item itemAsset;
    private ItemVisual SelectedItem;
    private Image image;
    private Item inventoryItem;
    private Transform oldParent;
    private Vector2 startPosition;

    private void Start()
    {
        image = GetComponent<Image>();
    }
    public void Init(Item item)
    {
        itemAsset = item;
        GetComponent<Image>().sprite = item.Sprite;
        GetComponentInChildren<Text>().text = item.counter.ToString();

    }
    #region IBeginDragHandler implementation
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (itemAsset.counter > 0)
        {
            SelectedItem = Instantiate(GetComponent<ItemVisual>(), transform);
            SelectedItem.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(50, 50);
            SelectedItem.transform.parent = GameObject.FindWithTag("Canvas").transform;
            itemAsset.counter -= 1;
            GetComponentInChildren<Text>().text = itemAsset.counter.ToString();
            SelectedItem.GetComponentInChildren<Text>().text = null;
            SelectedItem.GetComponent<Image>().raycastTarget = false;
        }   
    }
    #endregion

    #region IDragHandler implementation

    public void OnDrag(PointerEventData eventData)
    {
        SelectedItem.transform.position = Input.mousePosition;
    }
    #endregion

    #region IEndDragHandler implementation

    public void OnEndDrag(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject.transform == GameObject.FindWithTag("WorkSpace").transform)
        {
            SelectedItem.transform.SetParent(GameObject.FindWithTag("WorkSpace").transform);
            Destroy(GameObject.FindWithTag("WorkSpace").GetComponentInChildren<ItemVisual>().gameObject);
            GameObject GameItem = Instantiate(GetComponent<ItemVisual>().itemAsset.GameItem, transform);
            GameItem.transform.position = SelectedItem.transform.position;
            GameItem.transform.SetParent(GameObject.FindWithTag("WorkSpace").transform);
            
        }
        else
        {
            itemAsset.counter += 1;
            GetComponent<ItemVisual>().GetComponentInChildren<Text>().text = itemAsset.counter.ToString();
            Destroy(SelectedItem.gameObject);
        }
    }
    #endregion

    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponentInParent<InventoryPanel>().ShowInfo(itemAsset);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponentInParent<InventoryPanel>().HideInfo();
    }
}