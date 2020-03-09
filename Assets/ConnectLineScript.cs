using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConnectLineScript : MonoBehaviour
{
    private GameObject parentItem;
    public void Start()
    {
        parentItem = transform.parent.gameObject;
        transform.SetParent(GameObject.FindWithTag("Inventory_Manager").transform);
    }
    void FixedUpdate()
    {
        transform.position = Input.mousePosition;
        GetComponent<LineRenderer>().SetPosition(1, Input.mousePosition);
        GetComponent<Image>().raycastTarget = false;

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            for (int i = 0; i < GameObject.FindWithTag("Inventory_Manager").transform.childCount; i++)
            {
                Destroy(GameObject.FindWithTag("Inventory_Manager").transform.GetChild(i).gameObject);
            }
            parentItem.GetComponent<ConnectionScript>().connectorEnabled = true;
            
        }
        
    }
}
