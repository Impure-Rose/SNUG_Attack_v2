using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class DMEnemyTeam : MonoBehaviour
{
    [SerializeField] GameObject[] playerTeam;
    [SerializeField] int maxDamage;
    int damage;

    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent <NavMeshAgent>();
        playerTeam = GameObject.FindGameObjectsWithTag("Arms");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
