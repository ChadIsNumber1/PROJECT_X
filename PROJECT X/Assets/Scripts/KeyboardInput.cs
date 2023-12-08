using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace projectX
{
    public class KeyboardInput : MonoBehaviour
    {

        // Update is called once per frame
        void Update()
        {
            PlayerOneInputs();
            PlayerTwoInputs();

        }




        void PlayerOneInputs()
        {
            if (VirtualInputManager.Instance.GetKey("WalkFwdP1"))
            {
                VirtualInputManager.Instance.SetWalkFwdP1(true);
            }
            else
            {
                VirtualInputManager.Instance.SetWalkFwdP1(false);
            }

            if (VirtualInputManager.Instance.GetKey("WalkBackP1"))
            {
                VirtualInputManager.Instance.SetWalkBackP1(true);
            }
            else
            {
                VirtualInputManager.Instance.SetWalkBackP1(false);
            }


            if (VirtualInputManager.Instance.GetKey("LightAttkP1"))
            {
                VirtualInputManager.Instance.SetLightAttkP1(true);
            }
            else
            {
                VirtualInputManager.Instance.SetLightAttkP1(false);
            }


            if (VirtualInputManager.Instance.GetKey("HeavyAttkP1"))
            {
                VirtualInputManager.Instance.SetHeavyAttkP1(true);
            }
            else
            {
                VirtualInputManager.Instance.SetHeavyAttkP1(false);
            }
        }

        void PlayerTwoInputs()
        {
            if (VirtualInputManager.Instance.GetKey("WalkFwdP2"))
            {
                VirtualInputManager.Instance.SetWalkFwdP2(true);
            }
            else
            {
                VirtualInputManager.Instance.SetWalkFwdP2(false);
            }

            if (VirtualInputManager.Instance.GetKey("WalkBackP2"))
            {
                VirtualInputManager.Instance.SetWalkBackP2(true);
            }
            else
            {
                VirtualInputManager.Instance.SetWalkBackP2(false);
            }


            if (VirtualInputManager.Instance.GetKey("LightAttkP2"))
            {
                VirtualInputManager.Instance.SetLightAttkP2(true);
            }
            else
            {
                VirtualInputManager.Instance.SetLightAttkP2(false);
            }


            if (VirtualInputManager.Instance.GetKey("HeavyAttkP2"))
            {
                VirtualInputManager.Instance.SetHeavyAttkP2(true);
            }
            else
            {
                VirtualInputManager.Instance.SetHeavyAttkP2(false);
            }
        }
    }
}
