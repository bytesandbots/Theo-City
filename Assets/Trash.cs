using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trash : MonoBehaviour

{
    public GameObject player;
    public Image bucketimage; 
    public GameObject bucket;
    public bool dump;
    public float x = 137.7f;
    public float y = -47.745f;
    public float z = 398.42f;
    bool hasDrank = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(dump)
            {
                player.position = new Vector3(x, y, x);
                bucket.SetActive(false);
                bucketimage.sprite = null;
              

            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dump = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dump = false;
        }
    }

}
