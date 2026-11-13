using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    private Vector3 movement;
    private Vector2 mouse;
    private float horizontalRot = 0;
    private float invert = -1;
    private GlobalVariables global = new GlobalVariables();

    [SerializeField] private CharacterController obj;
    [SerializeField] private Transform player;
    [SerializeField] private Transform camera;
    [SerializeField] private float sensitivity;
    [SerializeField] private float speed;
    [SerializeField] private EnableUI canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas.Show(0);
        CursorSettings.Looking();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (canvas.objectVisibility(0))
            {
                canvas.Hide(global.settingsIndex);
            }

            else 
            { 
                canvas.Show(global.settingsIndex);
            }
        }

        else if (!canvas.objectVisibility(0) && !canvas.objectVisibility(1))
        {
            movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            mouse = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

            Move();
            Rotate();
        }
    }

    private void Move()
    {
        Vector3 moveVector = transform.TransformDirection(movement);

        obj.Move(moveVector * speed * Time.deltaTime);
    }

    private void Rotate()
    {
        horizontalRot += mouse.y * sensitivity * invert;
        horizontalRot = Mathf.Clamp(horizontalRot, -90f, 90f);

        transform.Rotate(0f, mouse.x * sensitivity, 0f);
        camera.transform.localRotation = Quaternion.Euler(horizontalRot, 0f, 0f);
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public void SetSensitivity(float newSens)
    {
        sensitivity = newSens;
    }

    public void SetInvert(bool isEnabled)
    {
        if (isEnabled)
        {
            invert = -1;
        }

        else
        {
            invert = 1;
        }
    }
}
