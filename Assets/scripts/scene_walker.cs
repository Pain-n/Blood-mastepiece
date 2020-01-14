using UnityEngine;

public class scene_walker : MonoBehaviour
{
    public GameObject LeftScene, CenterScene, TopScene, BottomScene, RightScene;
    private Camera cam;
    public float damping = 1.5f;
    public float timer;
    private new Animator animation;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
                Vector3 target;
                target = new Vector3(LeftScene.transform.position.x, LeftScene.transform.position.y, -1);
                Vector3 currentPosition = Vector3.Lerp(transform.position, target, damping * Time.deltaTime);
                transform.position = currentPosition;
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 target;
            target = new Vector3(RightScene.transform.position.x, RightScene.transform.position.y, -1);
            Vector3 currentPosition = Vector3.Lerp(transform.position, target, damping * Time.deltaTime);
            transform.position = currentPosition;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 target;
            target = new Vector3(BottomScene.transform.position.x, BottomScene.transform.position.y, -1);
            Vector3 currentPosition = Vector3.Lerp(transform.position, target, damping * Time.deltaTime);
            transform.position = currentPosition;   
        }
       if (Input.GetKey(KeyCode.W))
        {
            Vector3 target;
            target = new Vector3(TopScene.transform.position.x, TopScene.transform.position.y, -1);
            Vector3 currentPosition = Vector3.Lerp(transform.position, target, damping * Time.deltaTime);
            transform.position = currentPosition;           
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Vector3 target;
            target = new Vector3(CenterScene.transform.position.x, CenterScene.transform.position.y, -1);
            Vector3 currentPosition = Vector3.Lerp(transform.position, target, damping * Time.deltaTime);
            transform.position = currentPosition;
        }
    }
    public void GoToScene(GameObject q)
    {
        Vector3 target;
        target = new Vector3(q.transform.position.x, q.transform.position.y, -1);
        Vector3 currentPosition = Vector3.Lerp(transform.position, target, damping * Time.deltaTime);
        transform.position = currentPosition;
    }
}
