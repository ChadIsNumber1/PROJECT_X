using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class MainMenu : MonoBehaviour
{
    public AudioSource _mainMenuAudio;   //Defines naming convention for the main menu audio component
    public AudioClip _mainMenuMusic;    //Creates slot in inspector to assign main menu music

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

    public void ToCharacterSelect()
    {
        SceneManager.LoadScene("ChooseCharacter");
    }
}
