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
    public bool hasDrank = false;
    public Transform teleporting;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(dump && hasDrank)
            {
                player.GetComponent<CharacterController>().enabled = false;
                player.transform.position = teleporting.position;
                bucket.SetActive(false);
                bucketimage.sprite = null;
                player.GetComponent<CharacterController>().enabled = true;

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
