using UnityEngine;
using System.Collections;

public class walker_for_buttons : MonoBehaviour
{
    public new GameObject camera;
    public void ChangeScene(GameObject q)
    {
        camera.transform.position = new Vector3(q.transform.position.x, q.transform.position.y, -10);
    }
}
