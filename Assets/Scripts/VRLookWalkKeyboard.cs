using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class VRLookWalkKeyboard: MonoBehaviour
{
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;

    private CharacterController characterController;
    private Transform cameraTransform;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        // read inputs
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");
        // Move Left/Right
        characterController.transform.Rotate(0, x, 0);

        // Move forward/backward
        float curSpeed = speed * z;
        Vector3 forward = cameraTransform.TransformDirection(Vector3.forward);
        characterController.SimpleMove(forward * curSpeed);
       
    }
}