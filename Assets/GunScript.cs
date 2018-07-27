using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{

    public GameObject Bullet;
    public bool isFiring;
    public bool canShoot;
    public float timeBetweenShots = 1;
    private float timeUntilNextShot;



    // Use this for initialization

    void Start()
    {
        isFiring = false;
    }

    // Update is called once per frame
    void Update()
    {


        if (Time.time > timeUntilNextShot)
        {
            Debug.Log("can shoot");
            canShoot = true;
        }
        if (isFiring && canShoot)
        {
            canShoot = false;
            timeUntilNextShot = Time.time + timeBetweenShots;
            Instantiate(Bullet, this.transform.position, this.transform.rotation); // i took out instantiate Bulletcontroller so that we dont have to change speed to make it easier
        }
        if (isFiring)
        {
            Debug.Log("inst");
            Instantiate(Bullet, this.transform.position, this.transform.rotation);
        }


    }
    


}
        