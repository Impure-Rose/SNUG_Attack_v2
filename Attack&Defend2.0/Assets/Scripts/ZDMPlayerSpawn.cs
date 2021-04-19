using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZDMPlayerSpawn : MonoBehaviour
{
    public static int teamSize=0;
    [SerializeField] public static int maxTeamSize=10;
    GameObject teamInst;
    [SerializeField] GameObject team;
   [SerializeField] private ZDMZombieSpawn scriptReference;

    // Start is called before the first frame update
    void Start()
    {
       

        while (teamSize != maxTeamSize)
        {
            teamInst = Instantiate(team, transform) as GameObject;
            teamInst.GetComponent<Brains>().zombieRefernce = scriptReference;
            teamInst.transform.Translate(0, 0, teamSize * 2);
            teamSize++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
