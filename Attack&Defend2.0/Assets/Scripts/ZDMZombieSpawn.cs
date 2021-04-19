using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ZDMZombieSpawn : MonoBehaviour
{
    int hordeSize;
    public int maxHordeSize;
    [SerializeField] GameObject zombies;
    GameObject zombieInst;
    private float newTimer;
    [SerializeField] private float maxTimer = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        new WaitForSeconds(2f);
        while(hordeSize!=maxHordeSize)
        {
            ZombieSpawn();
            hordeSize++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        newTimer += Time.deltaTime;

        //maxHordeSize = (ZDMPlayerSpawn.maxTeamSize - ZDMPlayerSpawn.teamSize) + 5;
        Debug.Log("MaxHordeSize= " + maxHordeSize);
        //while (GameObject.FindGameObjectsWithTag("Horde").Length < maxHordeSize && newTimer >= maxTimer)
        //{
        //    //new WaitForSeconds(20.5f);
        //    ZombieSpawn();
        //    newTimer = 0.0f;

        //}
        if(transform.childCount < maxHordeSize)
        {
            ZombieSpawn();
        }
    }

  void ZombieSpawn()
    {
        zombieInst = Instantiate(zombies, transform) as GameObject;
        zombieInst.transform.Translate(hordeSize * 2, 0, 0);
    }
  
}
