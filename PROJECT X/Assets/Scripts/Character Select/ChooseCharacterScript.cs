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
            case 2:
                LoadBlue();
                _currentCharacterSelectedOrder = (CharacterSelectedOrder)(++_characterSelectOrderValue);
                break;
            case 3:
                LoadSkull();
                _currentCharacterSelectedOrder = (CharacterSelectedOrder)(++_characterSelectOrderValue);
                break;
            case 4:
                LoadOgre();
                _currentCharacterSelectedOrder = (CharacterSelectedOrder)(++_characterSelectOrderValue);
                break;
            case 5:
                LoadGladiator();
                _currentCharacterSelectedOrder = (CharacterSelectedOrder)(++_characterSelectOrderValue);
                break;
            case 6:
                LoadJesus();
                _currentCharacterSelectedOrder = (CharacterSelectedOrder)(++_characterSelectOrderValue);
                break;
            case 7:
                LoadDevil();
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

            case "BlueSelectButton":
                _characterSelected = 2;
                break;
            case "SkullSelectButton":
                _characterSelected = 3;
                break;
            case "OgreSelectButton":
                _characterSelected = 4;
                break;
            case "GladiatorSelectButton":
                _characterSelected = 5;
                break;
            case "JesusSelectButton":
                _characterSelected = 6;
                break;
            case "DevilSelectButton":
                _characterSelected = 7;
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

    private void LoadBlue()
    {
        Debug.Log("LoadBlue()");
        Destroy(_characterDemo);

        _characterDemo =
            Instantiate(Resources.Load("Fighter"))
            as GameObject;

        switch (_characterSelectOrderValue)
        {
            case 0:
                playerOneCharacterType = PlayableCharacterType.Blue;
                break;
            case 1:
                playerTwoCharacterType = PlayableCharacterType.Blue;
                break;
            default:
                break;
        }


    }

    private void LoadOgre()
    {
        Debug.Log("LoadOgre()");
        Destroy(_characterDemo);

        _characterDemo =
            Instantiate(Resources.Load("Fighter"))
            as GameObject;

        switch (_characterSelectOrderValue)
        {
            case 0:
                playerOneCharacterType = PlayableCharacterType.Ogre;
                break;
            case 1:
                playerTwoCharacterType = PlayableCharacterType.Ogre;
                break;
            default:
                break;
        }


    }

    private void LoadGladiator()
    {
        Debug.Log("LoadGladiator()");
        Destroy(_characterDemo);

        _characterDemo =
            Instantiate(Resources.Load("Fighter"))
            as GameObject;

        switch (_characterSelectOrderValue)
        {
            case 0:
                playerOneCharacterType = PlayableCharacterType.Gladiator;
                break;
            case 1:
                playerTwoCharacterType = PlayableCharacterType.Gladiator;
                break;
            default:
                break;
        }


    }

    private void LoadSkull()
    {
        Debug.Log("LoadSkull()");
        Destroy(_characterDemo);

        _characterDemo =
            Instantiate(Resources.Load("Fighter"))
            as GameObject;

        switch (_characterSelectOrderValue)
        {
            case 0:
                playerOneCharacterType = PlayableCharacterType.Skull;
                break;
            case 1:
                playerTwoCharacterType = PlayableCharacterType.Skull;
                break;
            default:
                break;
        }


    }

    private void LoadJesus()
    {
        Debug.Log("LoadJesus()");
        Destroy(_characterDemo);

        _characterDemo =
            Instantiate(Resources.Load("Fighter"))
            as GameObject;

        switch (_characterSelectOrderValue)
        {
            case 0:
                playerOneCharacterType = PlayableCharacterType.Jesus;
                break;
            case 1:
                playerTwoCharacterType = PlayableCharacterType.Jesus;
                break;
            default:
                break;
        }


    }

    private void LoadDevil()
    {
        Debug.Log("LoadDevil()");
        Destroy(_characterDemo);

        _characterDemo =
            Instantiate(Resources.Load("Fighter"))
            as GameObject;

        switch (_characterSelectOrderValue)
        {
            case 0:
                playerOneCharacterType = PlayableCharacterType.Devil;
                break;
            case 1:
                playerTwoCharacterType = PlayableCharacterType.Devil;
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
