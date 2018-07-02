using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class SimpleMovement : MonoBehaviour {
    public float PermSpeed = 3.0F;
    public float PermRotateSpeed = 3.0F;
    private float Speed;
    private float RotateSpeed;
    // Use this for initialization
    void Start () {
        Speed = 0F;
        RotateSpeed = 0F;
	}
    private void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        transform.Rotate(0, Input.GetAxis("Horizontal") * RotateSpeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = Speed; //* Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);
    }

    public void MoveForward()
    {
        Speed = PermSpeed;
        RotateSpeed = PermRotateSpeed;
    }

    public void MoveBackward()
    {
        Speed = -PermSpeed;
        RotateSpeed = PermRotateSpeed;
    }

    public void StopMovement()
    {
        Speed = 0.0F;
        RotateSpeed = 0.0F;
    }
}
