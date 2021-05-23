using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


//This is esstnetialy the AI manager 

public class Horde : MonoBehaviour
{
    [Header("Set Up")]
    [SerializeField] int Round;
    [SerializeField] int HordeSize;
    [Header("Zombies")]
    GameObject ZombieInstance;
    GameObject JugInstance;
    GameObject PychoInstance;
    GameObject GhoulInstance;
    GameObject MeatShieldInstance;
    [SerializeField] GameObject Enemies;
    [SerializeField] GameObject Jug;
    [SerializeField] GameObject Pycho;
    [SerializeField] GameObject Ghoul;
    [SerializeField] GameObject MeatShield;

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

        SpawnClass(3, Jug, JugInstance);
        SpawnClass(4, Jug, JugInstance);
        SpawnClass(5, Ghoul, GhoulInstance);
        SpawnClass(6, Ghoul, GhoulInstance);
        SpawnClass(8, MeatShield, MeatShieldInstance);
        SpawnClass(9, MeatShield, MeatShieldInstance);
        SpawnClass(10, Pycho, PychoInstance);
        SpawnClass(11, Pycho, PychoInstance);

    }

    void SpawnClass(int minimumRound, GameObject zombieClass, GameObject classInstance)
    {
        if (Round > minimumRound)
        {
            classInstance = Instantiate(zombieClass, transform) as GameObject;
            classInstance.transform.Translate(10, 0, 0);
        }
    }
}