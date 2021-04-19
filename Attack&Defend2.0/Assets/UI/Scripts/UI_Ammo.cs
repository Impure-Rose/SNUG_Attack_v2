using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Ammo : MonoBehaviour
{
    Text text;
    public int darts;
    void Awake()
    {
        text = GetComponent<Text>();
      //  darts = Shoot.Ammo;
      //Eventually this will get the value of Ammo remaining, but until then YEET.
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
