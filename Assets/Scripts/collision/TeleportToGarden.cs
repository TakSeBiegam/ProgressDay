using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TeleportToGarden : MonoBehaviour
{
    public string levelName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
            SceneManager.LoadScene(levelName);
    }
}
