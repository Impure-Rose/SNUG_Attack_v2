using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RivalDestruction : MonoBehaviour
{
    [SerializeField] private float thrust = 20f;
   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Projectile is being rendered");
        GetComponent<Rigidbody>().AddForce(transform.forward * thrust, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {//distruction script 
        Destroy(gameObject, 1.5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.tag == "Horde")
        {
            //Spawn in sound
            Destroy(gameObject);
            Debug.Log("Round/Dart Has been detroyed");
        }
    }


}
