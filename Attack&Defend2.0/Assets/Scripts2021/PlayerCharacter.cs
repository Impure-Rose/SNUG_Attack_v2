using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [Header("System")]
    [SerializeField] private Rigidbody player;
    [SerializeField] private GameObject playerCamera;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private Transform playerTransform;

    [Header("Gameplay Variables")]
    [SerializeField] private float speed;
    [Range(0,1)]
    [SerializeField] private float mouseSensitivity;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            player.MovePosition(transform.position+transform.right*(speed*Input.GetAxisRaw("Horizontal")));
        }
        if (Input.GetButton("Vertical"))
        {
            player.MovePosition(transform.position + transform.forward * (speed * Input.GetAxisRaw("Vertical")));

        }

        if(Input.GetAxis("Mouse X")!=0)
        {
            float horizontalRotation = Input.GetAxis("Mouse X") * mouseSensitivity;
            float verticalRotation = Input.GetAxis("Mouse Y") * mouseSensitivity *-1;

            if (Input.GetAxis("Mouse X") != 0){
                playerTransform.Rotate(0f, horizontalRotation, 0f, Space.Self);

            }

            if(Input.GetAxis("Mouse Y")!=0)
            {
                cameraTransform.Rotate( verticalRotation, 0f, 0f, Space.Self);
            }
        }
    }
}
