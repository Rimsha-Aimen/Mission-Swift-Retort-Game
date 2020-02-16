using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playrscript : MonoBehaviour
{
 

     public Slider healthbar;
     float health = 100;
     // Start is called before the first frame update
     void Start()
     {

     }

     // Update is called once per frame
     void Update()
     {
         healthbar.value = health;
         if(health <= 0)
         {
             health = 0;
             Destroy(gameObject);
         }
     }

     private void OnCollisionEnter(Collision co)
     {
         if(co.gameObject.tag=="Missile")
         {
             health -= 3;
         }
     }
 }
    

