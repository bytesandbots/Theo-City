using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vendingmachinetravel1 : MonoBehaviour
{
    bool interact;
    public GameObject coinpicture;
    public GameObject bucket;
    public GameObject bucketpicture;
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
             bucket.SetActive(true);
                bucketpicture.SetActive(true);
                coinpicture.SetActive(false);
            }
        }  
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.gameObject.GetComponent<backpack>().gotCoin == true) {
                interact = true;
                other.gameObject.GetComponent<backpack>().gotBucket = true;
            }

            
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
