using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPanel : MonoBehaviour
{
    public GameObject ItemVisualPrefab;
    public GameObject ItemsHab;

    public GameObject panel;
    public Text itemNameField, itemDescriptionField;
    public Image itemImage;

    public void Start()
    {
        panel.SetActive(false);
    }
    public void AddItem(Item item)
    {
        GameObject newItem = Instantiate(ItemVisualPrefab, ItemsHab.transform) as GameObject;
        newItem.GetComponent<ItemVisual>().Init(item);

    }

    public  void ShowInfo(Item item)
    {
        panel.SetActive(true);
        itemNameField.enabled = true;
        itemDescriptionField.enabled = true;
        itemImage.enabled = true;
        itemNameField.text = item.Name;
        itemDescriptionField.text = item.ItemDescription;
        itemImage.sprite = item.Sprite;
    }

    public void HideInfo()
    {
        panel.SetActive(false); 
        itemNameField.hideFlags = HideFlags.HideInHierarchy;
        itemDescriptionField.hideFlags = HideFlags.HideInHierarchy;
        itemImage.hideFlags = HideFlags.HideInHierarchy;
    }


}
