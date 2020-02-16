using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class enemymissile : MonoBehaviour
{
     private Transform target;
    public float fireRate = 3f;
    float LastFire = 0.0f;

    public GameObject missile;
    public Transform ray,LauncherAnchor;
    public static bool isPlayerAlive = true;

    void update()

    {
        //  if(Time.time>fireRate+LastFire)
        attack();

    }

    void attack()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider.gameObject.tag == "Player")
            {
                Instantiate(missile, LauncherAnchor.position, LauncherAnchor.rotation);
                LastFire = Time.deltaTime;
            }



        }
    }
}







