using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class backpack : MonoBehaviour
{
    List<GameObject> Backpack = new List<GameObject>();
    bool pickup;
    GameObject toopickup;
    public GameObject inventory;
    public Image coinimage;
    // Start is called before the first frame update
    void Start()
    {
        inventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            inventory.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            inventory.SetActive(false);
        }
        if (pickup)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Backpack.Add(toopickup);
                toopickup.SetActive(false);
                if (toopickup.name == "coin")
                {
                    coinimage.enabled = true;
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("enemy"))
        {
            pickup = true;
            toopickup = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("enemy"))
        {
            pickup = false;
            toopickup = null;
        } 
           
    }
}
