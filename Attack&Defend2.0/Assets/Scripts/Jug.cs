using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//Zombie AI, swarms the player

public class Jug : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] int dmg;
    [SerializeField] int death = 1;
    private NavMeshAgent Agent;


    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Agent.destination = Player.position;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Sock")
        {
            dmg++;
            Debug.Log("Hit");
        }

        if (dmg == death)
        {
            Destroy(gameObject);

        }
    }
}