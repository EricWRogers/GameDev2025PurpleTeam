using UnityEngine;

public class KillBox : MonoBehaviour
{
    public GameObject deathUI;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player"){
        deathUI.SetActive(true);
        Time.timeScale = 0f;

        }
    }
}
