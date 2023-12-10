using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class spawner : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform[] spawners;
    public GameObject player;
    public float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();   
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 30f)
        {
            Instantiate(enemy, spawners[Random.Range(0, spawners.Length)].position, Quaternion.identity);
            timer = 0f;
        }
        enemy.transform.position = player.transform.position;
    }
}
