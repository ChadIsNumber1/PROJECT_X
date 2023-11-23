using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace projectX
{

    public class VirtualInputManager : Singleton<VirtualInputManager>
    {
        [SerializeField] private bool MoveRight;
        [SerializeField] private bool MoveLeft;
        [SerializeField] private bool LightAttk;
        [SerializeField] private bool HeavyAttk;

        //Getters
        public bool GetMoveRight()
        {
            return MoveRight;
        }
        public bool GetMoveLeft() 
        {  
            return MoveLeft; 
        }
        public bool GetLightNeutral()
        {
            return LightAttk && !MoveRight;
        }

        public bool GetLightRight()
        {
            return LightAttk && MoveRight;
        }


        // Setters
        public void SetMoveRight(bool newState)
        {
            MoveRight = newState;
        }

        public void SetMoveLeft(bool newState)
        {
            MoveLeft = newState;
        }

        public void SetLightAttk(bool newState)
        {
            LightAttk = newState;
        }
        public void SetHeavyAttk(bool newState)
        {
            HeavyAttk = newState;
        }
    }


}
