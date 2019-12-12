using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_changer : MonoBehaviour
{
    public void Load_scene(int q)
    {
        SceneManager.LoadScene(q-1);
    }
}
