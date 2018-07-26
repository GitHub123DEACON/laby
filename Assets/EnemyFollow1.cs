using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow1 : MonoBehaviour
{
    public GameObject player;
    float speed = 4;
    float radius = 5;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        if (Vector3.Distance(transform.position, player.transform.position) <= radius)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

}