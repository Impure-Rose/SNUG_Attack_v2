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

    public GameObject pauseMenu;
    public bool paused;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (paused == false)
        {
            PlayerMovement();
            CameraMovement();
        }
        GamePause();

    }
    void PlayerMovement()
    {
        if (Input.GetButton("Horizontal"))
        {
            player.MovePosition(transform.position + transform.right * (speed * Input.GetAxisRaw("Horizontal")));
        }
        if (Input.GetButton("Vertical"))
        {
            player.MovePosition(transform.position + transform.forward * (speed * Input.GetAxisRaw("Vertical")));

        }
    }

    void CameraMovement()
    {
        if (Input.GetAxis("Mouse X") != 0)
        {
            float horizontalRotation = Input.GetAxis("Mouse X") * mouseSensitivity;
            float verticalRotation = Input.GetAxis("Mouse Y") * mouseSensitivity * -1;

            if (Input.GetAxis("Mouse X") != 0)
            {
                playerTransform.Rotate(0f, horizontalRotation, 0f, Space.Self);

            }

            if (Input.GetAxis("Mouse Y") != 0)
            {
                cameraTransform.Rotate(verticalRotation, 0f, 0f, Space.Self);
            }
        }
    }


void GamePause()
{
    if (Input.GetButton("Pause"))
    {
            if (paused==false){
                paused = true;
                pauseMenu.SetActive(true);
                Cursor.visible = true;
                Time.timeScale = 0;
                Cursor.lockState = CursorLockMode.Confined;
            }
     /*       if (paused == true)
            {
                paused = false;
                pauseMenu.SetActive(false);
                Cursor.visible = false;
                Time.timeScale = 1;
            }*/
    }
}

}
