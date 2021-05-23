using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterSwapping : MonoBehaviour
{
    [SerializeField] Renderer artemisRend;
    [SerializeField] Renderer centurionRend;
    [SerializeField] Renderer megaRend;
    [SerializeField] Renderer rivalRend;

    [SerializeField] private GameObject Artemis;
    [SerializeField] private GameObject Centurion;

    // Start is called before the first frame update
    void Start()
    {

      //  artemisRend = GetComponent<Renderer>();
       // centurionRend = GetComponent<Renderer>();
        artemisRend.enabled = true;
        centurionRend.enabled = false;
        rivalRend.enabled = true;
        megaRend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
            {
            artemisRend.enabled = true;
            centurionRend.enabled = false;
            rivalRend.enabled = true;
            megaRend.enabled = false;
            Debug.Log("Artemis Active!");
            Artemis.SetActive(true);
            Centurion.SetActive(false);

        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            artemisRend.enabled = false;
            centurionRend.enabled = true;
            rivalRend.enabled = false;
            megaRend.enabled = true;
            Debug.Log("Centurion Active!");
            Artemis.SetActive(false);
            Centurion.SetActive(true);
        }
    }
}
