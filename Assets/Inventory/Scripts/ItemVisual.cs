using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ItemVisual : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Item itemAsset;
    private ItemVisual SelectedItem;
    private Image image;
    private Item inventoryItem;
    private Transform oldParent;
    public Vector2 startPosition;

    private void Start()
    {
        image = GetComponent<Image>();
    }
    public void Init(Item item)
    {
        itemAsset = item;
        GetComponent<Image>().sprite = item.Sprite;

    }
    #region IBeginDragHandler implementation
    public void OnBeginDrag(PointerEventData eventData)
    {
        image.raycastTarget = false;
        SelectedItem = transform.parent.GetComponent<ItemVisual>();
        inventoryItem = SelectedItem.itemAsset;
        oldParent = transform.parent;
        startPosition = transform.position;
        transform.SetParent(GameObject.FindWithTag("Canvas").transform);
        GetComponent<CanvasGroup>().blocksRaycasts = false;

    }
    #endregion

    #region IDragHandler implementation

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
    #endregion

    #region IEndDragHandler implementation

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.parent = GameObject.FindWithTag("Canvas").transform;
        image.raycastTarget = true;
       
        if (transform.parent != GameObject.FindWithTag("Inventory").transform)
        //{
        //    //transform.position = startPosition;
        //    transform.SetParent(GameObject.FindWithTag("Inventory").transform);
        //} 

        {
            if (eventData.pointerCurrentRaycast.gameObject.transform == GameObject.FindWithTag("WorkSpace").transform)
            {
                transform.SetParent(GameObject.FindWithTag("WorkSpace").transform);
            }
            else
            {
                transform.SetParent(GameObject.FindWithTag("Inventory").transform);
            }
        }      
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        #endregion

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
