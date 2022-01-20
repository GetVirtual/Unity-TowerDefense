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
    private void OnMouseEnter()
    {
        TargetPosition = gameObject.transform.position + (gameObject.transform.forward * RunDistance);
    }

    private void Update()
    {
       var delta = TargetPosition - gameObject.transform.position;  
       if(delta.magnitude > 0.1)
        characterController.Move(gameObject.transform.forward * RunSpeed * Time.deltaTime);
    }
}
