﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class VRLookWalk: MonoBehaviour
{
    public float speed = 3.0F;

    private CharacterController characterController;
    private Transform cameraTransform;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        Vector3 forward = cameraTransform.TransformDirection(Vector3.forward);
        characterController.SimpleMove(forward * speed);
    }
}