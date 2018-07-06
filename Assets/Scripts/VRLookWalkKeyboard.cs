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
        cameraTransform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        Vector3 forward = cameraTransform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        characterController.SimpleMove(forward * curSpeed);
    }
}