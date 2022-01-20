using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogPoly : MonoBehaviour
{
    private CharacterController characterController;
    

    private void OnMouseEnter()
    {
        characterController = GetComponent<CharacterController>();
        characterController.Move(new Vector3(-5,0,0));
        

    }

    //private void OnMouseExit()
    //{
    //    characterController = GetComponent<CharacterController>();
    //    characterController.Move(new Vector3(0, 0, 0));
    //}
}
