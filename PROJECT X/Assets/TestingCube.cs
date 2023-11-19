using projectX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingCube : MonoBehaviour
{

    public float movementSpeed;

    void Update()
    {
        if(VirtualInputManager.Instance.MoveRight &&
            VirtualInputManager.Instance.MoveLeft)
        {
            return;
        }


        if (VirtualInputManager.Instance.MoveRight)
        {
            this.gameObject.transform.Translate(
                Vector3.right * movementSpeed * Time.deltaTime);
            
        }

        if (VirtualInputManager.Instance.MoveLeft)
        {
            this.gameObject.transform.Translate(
                -Vector3.right * movementSpeed * Time.deltaTime);
        }
    }
}
