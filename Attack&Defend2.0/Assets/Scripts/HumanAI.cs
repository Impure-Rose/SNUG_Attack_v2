using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanAI : MonoBehaviour
{
    [SerializeField] LayerMask lay0;
    [SerializeField] LayerMask lay1;
    bool isHitting = false;

    // Start is called before the first frame update
    void Start()
    {
        isHitting = Physics.SphereCast(transform.position, 10f, transform.forward, out RaycastHit hitInfo, 20f, lay0 + lay1, QueryTriggerInteraction.UseGlobal);
    }

    // Update is called once per frame
    void Update()
    {
        //I don't partuclarly like the idea of this living here but fine.. 
        isHitting = Physics.SphereCast(transform.position, 10f, transform.forward, out RaycastHit hitInfo, 20f, lay0 + lay1, QueryTriggerInteraction.UseGlobal);
        Debug.Log(isHitting);
        if (isHitting == true)
        {
            Debug.Log("Detecting Enemies!");

        }
    }
}
