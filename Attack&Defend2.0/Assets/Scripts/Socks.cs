using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socks : MonoBehaviour
{
    [SerializeField] private float thrust = 40f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * thrust, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {//distruction script 
        Destroy(gameObject, 1f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Horde")
        {
            //Spawn in sound
            Destroy(gameObject);
        }
    }


}