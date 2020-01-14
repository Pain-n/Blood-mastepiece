using UnityEngine;

public class butScript : MonoBehaviour
{

    public void GoToScene(GameObject camera_move)
    {
        Debug.Log("it works");
        transform.position = new Vector2(camera_move.transform.position.x, camera_move.transform.position.y);



    }


}
