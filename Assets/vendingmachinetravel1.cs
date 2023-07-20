using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vendingmachinetravel1 : MonoBehaviour
{
    bool interact;
    public Transform teleportlocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(interact)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                GameObject.FindGameObjectWithTag("Player").transform.position = teleportlocation.position;
            }
        }  
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact = true;
        }  
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact = false;
        }
    }
}
