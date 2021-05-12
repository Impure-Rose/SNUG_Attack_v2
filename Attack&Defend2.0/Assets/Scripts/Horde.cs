using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


//This is esstnetialy the AI manager 

public class Horde : MonoBehaviour
{
    [SerializeField] int Round;
    [SerializeField] int HordeSize;
    GameObject ZombieInstance;
    GameObject JugInstance;
    [SerializeField] GameObject Enemies;
    [SerializeField] GameObject Jug;
   // [SerializeField] GameObject SpecialZombie;
 //   GameObject FinalBoss;
    int x = 0;
    [SerializeField] private AudioSource Special;


    [Header("UI Setting")]
    [SerializeField]
    private TextMeshProUGUI textGameObject;

    RequireComponent NavMeshAgent;
    RequireComponent Colliider;
    // Start is called before the first frame update
    void Start()
    {
        textGameObject.text = "WAVE: " + Round;
        formhorde();
        x = 0;
    }


    // Update is called once per frame
    void Update()
    {
  
             if (GameObject.FindGameObjectsWithTag("Horde").Length<1)
            {
            new WaitForSeconds(3f);
                Round++;
                textGameObject.text = "WAVE: " + Round;
                formhorde();
 
            }
       
    }
    void formhorde()
    {
        HordeSize = Round *2;  
        while (x != HordeSize)
        {

            ZombieInstance = Instantiate(Enemies, transform) as GameObject;
            ZombieInstance.transform.Translate(0, 0, x * 2);
            x++;
        }
  
        x = 0;
        if (Round > 3)
        {
            JugInstance = Instantiate(Jug, transform) as GameObject;
            JugInstance.transform.Translate(10, 0, 0);
        }

    //    if (Round == 5)
      //  {
        //    Special.Play();
          //  Debug.Log("Audio clip is being played");

       // }
       // if (Round>=5)
       // {
         //   FinalBoss = Instantiate(SpecialZombie, transform) as GameObject;

//        }
    }
}