using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [Header("System")]
    [SerializeField] private Rigidbody player;

    [Header("Gameplay Variables")]
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}
