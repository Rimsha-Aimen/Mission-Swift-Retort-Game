using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionscript : MonoBehaviour
{
    public GameObject dead_panel;
    void start()
    {
        dead_panel.gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enviroment")
        {
            Destroy(gameObject);
            dead_panel.gameObject.SetActive(true);

        }
    }
    
    }