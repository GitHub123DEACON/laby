
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public float speed = 10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward);
        if (Camera.main.WorldToViewportPoint(this.transform.position).y < 0)
        {
            Destroy(this.gameObject);
        }
    }
}