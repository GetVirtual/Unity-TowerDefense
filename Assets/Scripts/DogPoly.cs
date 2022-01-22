using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogPoly : MonoBehaviour
{
    public float RunSpeed = 5;
    public float RunDistance = 5;
    private CharacterController characterController;    
    private Vector3 TargetPosition;
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        TargetPosition = gameObject.transform.position;
    }
    //private void OnMouseEnter()
    //{
    //    TargetPosition = gameObject.transform.position + (gameObject.transform.forward * RunDistance);
    //    GetComponent<Animator>().Play("WalkForwardBattle");
    //}

    //private void OnGUI()
    //{
    //    if(GUI.Button(new Rect(10,10, 100, 20), "Run"))
    //    {
    //        TargetPosition = gameObject.transform.position + (gameObject.transform.forward * RunDistance);
    //        GetComponent<Animator>().Play("WalkForwardBattle");
    //    }
    //}

    private void Update()
    {      
        var delta = TargetPosition - gameObject.transform.position;
        if (delta.magnitude > 0.1)
        {
            gameObject.transform.position = gameObject.transform.position + (gameObject.transform.forward * RunSpeed * Time.deltaTime);
        }
        else
        {
            GetComponent<Animator>().Play("Idle_Battle");
        }
    }
}
