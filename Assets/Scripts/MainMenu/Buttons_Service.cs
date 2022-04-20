using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Buttons_Service : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("Dom");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ShowCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
