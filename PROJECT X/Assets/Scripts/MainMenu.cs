using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //When you click Versus, the scene changes to the PlayGame scene
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //quits game
    public void QuitGame ()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }


}
