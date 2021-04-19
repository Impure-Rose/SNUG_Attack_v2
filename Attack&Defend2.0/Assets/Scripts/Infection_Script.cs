using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infection_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
     
      if (collision.gameObject.layer == LayerMask.NameToLayer("Player")) ;
        {
            Debug.Log("Player has been infected");
             if (GameObject.FindGameObjectsWithTag("Horde").Length < 1)
            {
                Debug.Log("The player has joined the horde");
            }
        }
    }

}
