using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public Item[] initialItems;
    public InventoryPanel inventoryVisual;
    private List<Item> inventoryItems = new List<Item>();

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
        for (int i = 1; i < inventoryVisual.transform.childCount; i++)
        {
            Destroy(inventoryVisual.GetComponentInChildren<Image>());
        }
        foreach (Item item in initialItems)
        {

            if (item.ItemType == Item.TypeofItem.List_1) {
                AddItem(item);
            }
        }
    }

        public void MoveItem()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

        }
    }

}
