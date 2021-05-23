using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Specials_AnimChecking : MonoBehaviour
{
    [SerializeField] Animator classAnimator;
    RequireComponent Animator;
    RequireComponent Collider;
   // bool isPlayerNear=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            classAnimator.SetBool("IsPlayerNear", true);
        }
        else
        {
            classAnimator.SetBool("IsPlayerNear", false);
        }
    }
}
