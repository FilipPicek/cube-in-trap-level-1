using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait=5f;
    MeshRenderer rrenderer;
    Rigidbody riggidbody;


    // Start is called before the first frame update
    void Start()
    {
        rrenderer=GetComponent<MeshRenderer>();
        riggidbody=GetComponent<Rigidbody>();
        rrenderer.enabled=false;
        riggidbody.useGravity=false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Time.time>timeToWait)
        {
            rrenderer.enabled=true;
            riggidbody.useGravity=true;
        
        }
    }
}
