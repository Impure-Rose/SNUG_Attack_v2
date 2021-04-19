using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//Zombie AI, swarms the player

public class Brains : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] int dmg;
    [SerializeField] int death = 1;
    private NavMeshAgent agent;
    public ZDMZombieSpawn zombieRefernce; 
  

    // Start is called before the first frame update
    void Start()
    {
        //Finds the player 
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Follow the player 
        agent.destination = player.position;
        transform.LookAt(player);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //How to tell if hit
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ammo"))
        {
            dmg++;
            Debug.Log("Hit");
        }
        //De-spawn enemies upon death
        if (dmg == death)
        {
            Debug.Log("I am dying now!");
            zombieRefernce.maxHordeSize++;
            
            Destroy(gameObject);

        }
    }
}
