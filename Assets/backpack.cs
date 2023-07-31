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
    public GameObject wata;
    public bool wata2;
    // Start is called before the first frame update
    void Start()
    {
        inventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (wata2 == true)
        {
            wata.SetActive(true);
        }
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

        if (other.CompareTag("well"))
        {
            wata2 = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("enemy"))
        {
            pickup = false;
            toopickup = null;
        }
        if (other.CompareTag("well"))
        {
            wata2 = false;
        }


    }
}
