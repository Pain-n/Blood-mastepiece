using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_changer : MonoBehaviour
{
    public void Load_scene(int scene_index)
    {
        SceneManager.LoadScene(scene_index);
    }
}
