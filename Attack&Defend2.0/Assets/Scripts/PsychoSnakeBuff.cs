using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PsychoSnakeBuff : MonoBehaviour
{
    [SerializeField] int healthBuff;
    [SerializeField] float speedBuff;
    [SerializeField] GameObject zombies;

    // Start is called before the first frame update
    void Start()
    {
        zombies = GameObject.FindGameObjectWithTag("Horde");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
