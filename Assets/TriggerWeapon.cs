using UnityEngine;

public class TriggerWeapon : MonoBehaviour
{
    public bool ReadyToPickUp;
    public Transform Holder;
    private shoot shoot;
    public GameObject Gun;
   
    // Start is called before the first frame update
    void Start()
    {
        Gun.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ReadyToPickUp) {
            if (Input.GetKeyDown(KeyCode.E)) {
                transform.SetParent(Holder);
                transform.localPosition = Vector3.zero;
                transform.localEulerAngles = Vector3.zero;
                GetComponent<SphereCollider>().enabled = false;
                GetComponent<BoxCollider>().enabled = false;
                GetComponent<Rigidbody>().isKinematic = true;
                gameObject.layer = LayerMask.NameToLayer("Player");
                shoot = Holder.GetComponentInParent<shoot>();
                ReadyToPickUp = false;
                if(shoot != null)
                {
                    shoot.enabled = true;

                }
                
                Gun.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            ReadyToPickUp = true;
         
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ReadyToPickUp = false;
        }
     
    }
}
