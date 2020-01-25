using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InventoryController : MonoBehaviour
{
    public Item[] initialItems;
    public InventoryPanel inventoryVisual;
    private List<Item> inventoryItems = new List<Item>();
    Sprite dragSprite;
    bool isDraggable;
    Item selectItem;
    public GameObject inventory;

    private void Start()
    {
        foreach (Item item in initialItems)
        {
            AddItem(item);
        }
    }

    private void AddItem(Item item)
    {
        inventoryItems.Add(item);
        inventoryVisual.AddItem(item);
    }

    public void ChangeItemsList1()
    {
        for (int i = 0; i < inventory.transform.childCount; i++)
        {
            Destroy(inventory.transform.GetChild(i).gameObject);
        }

        foreach (Item item in initialItems)
        {

            if (item.ItemType == Item.TypeofItem.List_1) {
                AddItem(item);
            }
        }
    }

    public void ChangeItemsList2()
    {
        for (int i = 0; i < inventory.transform.childCount; i++)
        {
            Destroy(inventory.transform.GetChild(i).gameObject);
        }

        foreach (Item item in initialItems)
        {

            if (item.ItemType == Item.TypeofItem.list_2)
            {
                AddItem(item);
            }
        }
    }

    public void ChangeItemsList3()
    {
        for (int i = 0; i < inventory.transform.childCount; i++)
        {
            Destroy(inventory.transform.GetChild(i).gameObject);
        }

        foreach (Item item in initialItems)
        {

            if (item.ItemType == Item.TypeofItem.list_3)
            {
                AddItem(item);
            }
        }
    }

    public void ChangeItemsList4()
    {
        for (int i = 0; i < inventory.transform.childCount; i++)
        {
            Destroy(inventory.transform.GetChild(i).gameObject);
        }

        foreach (Item item in initialItems)
        {

            if (item.ItemType == Item.TypeofItem.list_4)
            {
                AddItem(item);
            }
        }
    }

    }


