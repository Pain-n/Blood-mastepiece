using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InGameItemDragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler

{
    private Vector2 startPosition;

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = transform.position;
        GetComponent<Image>().raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject.transform != GameObject.FindWithTag("WorkSpace").transform)
        {
            transform.position = startPosition;
            GetComponent<Image>().raycastTarget = true;
        }
        else {

            GetComponent<Image>().raycastTarget = true;
        }
    }
}
