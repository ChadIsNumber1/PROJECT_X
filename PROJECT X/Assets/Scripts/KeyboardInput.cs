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
            if (Input.GetKey(KeyCode.D))
            {
                VirtualInputManager.Instance.SetMoveRight(true);
            }
            else
            {
                VirtualInputManager.Instance.SetMoveRight(false);
            }

            if (Input.GetKey(KeyCode.A))
            {
                VirtualInputManager.Instance.SetMoveLeft(true);
            }
            else
            {
                VirtualInputManager.Instance.SetMoveLeft(false);
            }


            if (Input.GetKeyDown(KeyCode.X))
            {
                VirtualInputManager.Instance.SetLightAttk(true);
            }
            else
            {
                VirtualInputManager.Instance.SetLightAttk(false);
            }


        }
    }


}
