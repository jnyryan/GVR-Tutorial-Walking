using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class VRAutoWalkLookDown : MonoBehaviour {

    public Transform cameraTransform;
    public float toggleAngle = 10.0F;
    public float speed = 3.0F;
    public bool moveForward;

    private CharacterController characterController;


	// Use this for initialization
	void Start () {
        characterController = GetComponent<CharacterController>();
        cameraTransform = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {

        if (cameraTransform.eulerAngles.x >= toggleAngle
          && cameraTransform.eulerAngles.x <= 90.0f)
            moveForward = true;
        else
            moveForward = false;
        
        if(moveForward){
            Vector3 forward = cameraTransform.TransformDirection(Vector3.forward);
            characterController.SimpleMove(forward * speed * toggleAngle / 5);
        }
	}
}
