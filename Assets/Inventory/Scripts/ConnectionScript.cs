using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConnectionScript : MonoBehaviour
{
    public GameObject connector;
    private GameObject trueConnector;
    public bool connectorEnabled = true;
    public void ConnectionCreate()
    {
        if (connectorEnabled == true)
        {
            trueConnector = Instantiate(connector, transform);
            trueConnector.GetComponent<RectTransform>().sizeDelta = new Vector2(50, 50);
            connectorEnabled = false;
        }
    }
}
