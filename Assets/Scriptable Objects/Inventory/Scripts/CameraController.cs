using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
  [SerializeField] private float _mouseMovement = 200;

  private Transform parent;
  private Camera _fpsCamera;
  float cameraClamp = 0f;

  private void Start()
  {
    _fpsCamera = Camera.main;
    parent = transform.parent;
    Cursor.lockState = CursorLockMode.Locked;
  }

  private void Update()
  {
    float horizontalRotation = Input.GetAxis("Mouse X") * _mouseMovement * Time.deltaTime;
    float verticalRotation = Input.GetAxis("Mouse Y") * _mouseMovement * Time.deltaTime;

    parent.Rotate(0, horizontalRotation, 0);
    _fpsCamera.transform.Rotate(-verticalRotation, 0, 0);

  }
}