using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneName;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player")){
            LoadScene();
        }
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
