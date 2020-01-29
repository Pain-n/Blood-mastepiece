using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ItemVisual : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Item itemAsset;
    private ItemVisual SelectedItem;
    private Transform canvas;
    private Image image;
    private Item inventoryItem;
    private Transform oldParent;
    public GameObject WorkSpace;

    private void Start()
    {
        canvas = GameObject.FindWithTag("Canvas").transform;
        image = GetComponent<Image>();
    }
    public void Init(Item item)
    {
        itemAsset = item;
        GetComponent<Image>().sprite = item.Sprite;
        canvas = GameObject.FindWithTag("Canvas").transform;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        image.raycastTarget = false;
        SelectedItem = transform.parent.GetComponent<ItemVisual>();
        inventoryItem = SelectedItem.itemAsset;
        oldParent = transform.parent;
        transform.SetParent(canvas);

    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.localPosition = Input.mousePosition - new Vector3(Screen.width / 2, Screen.height / 2, 0);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        image.raycastTarget = true;

        if (eventData.pointerCurrentRaycast.gameObject != null)
        {
            if (eventData.pointerCurrentRaycast.gameObject.transform == oldParent) {
                transform.SetParent(oldParent);
            }
            else if (eventData.pointerCurrentRaycast.gameObject.transform.GetComponent<ItemVisual>() )
            {
                transform.SetParent(oldParent);
            }
            else
            {
                if(eventData.pointerCurrentRaycast.gameObject.transform == WorkSpace.transform)
                {
                    transform.SetParent(WorkSpace.transform);
                }
                else
                {
                    transform.SetParent(oldParent);
                }
            }
        }
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
