using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerDeath : MonoBehaviour
{
    [SerializeField] int health = 2;
    [SerializeField] bool infected = false; 
    [Header("UI")]
    [SerializeField] private TextMeshProUGUI youDied;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (health<=0 )
        {
            youDied.text = "You have joined the horde! (Press ESC to Exit)";
            Time.timeScale = 0f;
        }

        
       if (infected == true)
       {
                hit();
       }
    }

    private void OnCollisionEnter(Collision collision)
    {


        //Realizing that killing the player is too much of a hassle but if I need to reenable it I will 
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemies")) ;
         {

            hit();
         }

        }

    private void OnTriggerEnter(Collider other)
    {
        infected = true;
       
    }


    void hit()
    {
        health--;
        Debug.Log("Player has been hit");
    }

}
