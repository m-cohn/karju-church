using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    private Vector3 movement;
    private Vector2 mouse;
    private float horizontalRot = 0;

    [SerializeField] private CharacterController obj;
    [SerializeField] private Transform player;
    [SerializeField] private Transform camera;
    [SerializeField] private float sensitivity;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        mouse = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        Move();
        Rotate();
    }

    private void Move()
    {
        Vector3 moveVector = transform.TransformDirection(movement);

        obj.Move(moveVector * speed * Time.deltaTime);
    }

    private void Rotate()
    {
        horizontalRot -= mouse.y * sensitivity;
        horizontalRot = Mathf.Clamp(horizontalRot, -90f, 90f);

        transform.Rotate(0f, mouse.x * sensitivity, 0f);
        camera.transform.localRotation = Quaternion.Euler(horizontalRot, 0f, 0f);
    }
}
