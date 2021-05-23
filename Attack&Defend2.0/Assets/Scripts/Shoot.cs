using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


//This sets up how the blatster shoots, and reloads

public class Shoot : MonoBehaviour
{
    [SerializeField] Rigidbody Rivals;
    [SerializeField] Transform Blaster;
    [SerializeField] int maxAmmo = 30;
    public int Ammo;
    bool reload = false;
    Rigidbody RivalInstance;
    int beforedestruct;
    int socks = 5;
    [SerializeField] int maxSocks = 5;
    [SerializeField] Rigidbody thrown;
    [SerializeField] Transform hand;
    Rigidbody sockinstance;
    [SerializeField] private AudioSource popSound;

    [Header("UI")]
    [SerializeField] private TextMeshProUGUI counter;
    [SerializeField] TextMeshProUGUI SockUI;

    // Start is called before the first frame update
    void Start()
    {
        Ammo = maxAmmo;
        counter.text = "Ammo: " + Ammo + "/" + maxAmmo;
        SockUI.text = "Socks: " + socks + "/" +maxSocks;
        popSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame;
    void Update()
    {


        //Throws Socks 
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (socks > 0)
            {
                socks--;
                SockUI.text = "Socks: " + socks + "/" + maxSocks;
                sockinstance = Instantiate(thrown, hand.position, hand.rotation) as Rigidbody;

                Debug.Log("sock has been thrown");
            }


        }
        //Shoots 
        if (Input.GetButtonDown("Fire1"))
        {
            if (Ammo > 0)
            {
                //calculates ammo remaining if there is ammo remaining the blaster can fire. 
                Ammo--;
                counter.text = "Ammo: " + Ammo + "/" + maxAmmo;
                popSound.Play();
                Fire();
                Debug.Log(Ammo);

            }

        }
        //Blaster 1: Artemis 
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            maxAmmo = 30;
            maxSocks = 5;
            Reload();
        }
        //Blaster 2: Centurion 
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            maxAmmo = 6;
            maxSocks = 5;
            Reload();
        }
        //Reload, calls reload function
        if (Input.GetKey(KeyCode.R))
        {
            //Resets ammo count
            reload = true;
            Reload();
        }
    }


    void Fire()
    {

        //Fires blaster
        RivalInstance = Instantiate(Rivals, Blaster.position, Blaster.rotation) as Rigidbody;

    }

    void Reload()
    {
        //resets the ammo counter
        Ammo = maxAmmo;
        reload = false;
        socks = maxSocks;

    }
}



