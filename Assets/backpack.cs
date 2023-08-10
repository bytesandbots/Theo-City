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
    public Image bucketimage;
    public Sprite watabucketfull;
    public Sprite watabucketempty;
    public Animator anim;
    public bool hasWater;
    public GameObject bucket;

    // Start is called before the first frame update
    void Start()
    {
        inventory.SetActive(false);
    }
    IEnumerator DrinkWater() {

        yield return new WaitForSeconds(6);
        wata.SetActive(false);
        bucketimage.sprite = watabucketempty;
    }
    // Update is called once per frame
    void Update()
    {
        if (hasWater) {
            
            if (Input.GetKeyUp(KeyCode.R))
            {
                bucket.transform.localPosition = new Vector3(-0.117f, 0.278f, - 0.016f);
                bucket.transform.localEulerAngles = new Vector3(-206.779f, 181.361f, 92.403f);
                hasWater = false;
                anim.SetTrigger("drink");

                StartCoroutine(DrinkWater());
            }
        }
        if (wata2 == true)
        {
            wata.SetActive(true);
            hasWater = true; 
            bucketimage.sprite = watabucketfull;
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
