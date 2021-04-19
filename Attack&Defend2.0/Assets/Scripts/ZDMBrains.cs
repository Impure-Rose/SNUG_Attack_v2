using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ZDMBrains : MonoBehaviour
{
    [SerializeField] Transform arms;
    [SerializeField] Transform necks;
    [SerializeField] Transform player;
    [SerializeField] int maxDamage;
    [SerializeField]  int damage;
    private NavMeshAgent agent;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // if (GameObject.FindGameObjectWithTag("arms").Length <= 3)
       // {
       //     player = GameObject.FindGameObjectWithTag("Player").transform;
       // } 
    }
}
