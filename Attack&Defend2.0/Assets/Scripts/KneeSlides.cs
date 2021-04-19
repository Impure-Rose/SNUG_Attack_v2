using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KneeSlides : MonoBehaviour
{
    RequireComponent Player;
    [SerializeField] GameObject Legs;



    // Start is called before the first frame update
    void Start()
    {
        Legs.transform.Translate(0, 5, 0);

    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
       if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            Legs.transform.Translate(0, -5, 0);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position = new Vector3(pos.x, 2.02f, pos.z);
         
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            transform.position = new Vector3(pos.x, 2.88f, pos.z);

            Legs.transform.Translate(0, 5, 0);

        }
    }
}