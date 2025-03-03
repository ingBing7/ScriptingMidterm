using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletForce = 10000;
    public Transform bulletSpawnPosition;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)) 
            //change keycode back to LMB when other code is fixed 

        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPosition.position, bulletSpawnPosition.rotation);

            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletForce);

            Destroy(bullet, 3f);
            //makes the bullet stick around for 3 seconds
        }
    }
}
