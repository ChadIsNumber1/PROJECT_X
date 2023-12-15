using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class CharacterSelect : ChooseCharacterManager
{

    public float _chooseCharacterInputTimer;
    public float _chooseCharacterInputDelay = 1f;


    private GameObject _characterDemo;      //GaneObject that displays the character in the character select

    public int _characterSelected;

    private enum CharacterSelectedOrder
    {
        NONE = 0,
        Player1 = 1,
        Player2 = 2
    }

    private int _characterSelectOrderValue; 
    private CharacterSelectedOrder _currentCharacterSelectedOrder;

    private enum CharacterSelectModels
    {
        NONE = 0,
        Fighter = 1
    }


    // Start is called before the first frame update
    void Start()
    {
        _characterSelectOrderValue = 0;
        CharacterSelectManager();  //Call CharacterSelectManager on startup
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CharacterSelectManager()
    {
        switch (_characterSelected)
        {
            default:
                break;
            case 1:
                LoadFighter();        
                _currentCharacterSelectedOrder = (CharacterSelectedOrder)(++_characterSelectOrderValue);
                break;
        }        


    }

    public void ChangeCharacterButton(Button buttonClicked)
    {
        switch(buttonClicked.name)
        {
            case "FighterSelectButton":
                _characterSelected = 1;
                break;

            default:
                break;
        }
        CharacterSelectManager();
    }

    private void LoadFighter()
    {
        Debug.Log("LoadFighter()");
        Destroy(_characterDemo);

        _characterDemo = 
            Instantiate(Resources.Load("Fighter"))
            as GameObject;

        switch (_characterSelectOrderValue)
        {
            case 0:
                playerOneCharacterType = PlayableCharacterType.Fighter;
                break;
            case 1: 
                 playerTwoCharacterType = PlayableCharacterType.Fighter;
                break;
            default:
                break; 
        }


    }


    public void StartMatch()
    {
        Debug.Log("Start()");

        if (playerOneCharacterType != PlayableCharacterType.NONE && playerTwoCharacterType != PlayableCharacterType.NONE)
        {
            SceneManager.LoadScene("FightingScene");
        }
    }




    void OnGUI()
    {
       
    }
}
