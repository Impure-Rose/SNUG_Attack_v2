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
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject resumeButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (health<=0 )
        {
            youDied.text = "You have joined the horde!";
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.Confined;
            resumeButton.SetActive(false);
        }

        
       if (infected == true)
       {
                hit();
       }
    }

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemies")) ;
         {

            hit();
            Debug.Log(collision.gameObject.name);
         }

        }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Infection") { 
        infected = true;
         }
       
    }


    void hit()
    {
        health--;
        Debug.Log("Player has been hit");
    }

}
