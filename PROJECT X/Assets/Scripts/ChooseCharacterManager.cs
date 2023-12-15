using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCharacterManager : MonoBehaviour
{

    public enum PlayableCharacterType
    {
        NONE,
        Fighter,
    }


    public PlayableCharacterType playerOneCharacterType;
    public PlayableCharacterType playerTwoCharacterType;



    void Awake () 
    {
        playerOneCharacterType = PlayableCharacterType.NONE;
        playerOneCharacterType = PlayableCharacterType.NONE;
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
