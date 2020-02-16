using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
     public GameObject missile;
       public Transform Launcherleft,LauncherRight,MissilesParentInHeirarchy;

    void Start()
    {
        
    }

  
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
	{
	  LaunchMissile();
	}
    }
   void LaunchMissile()
{

	  Instantiate(missile,Launcherleft.position,Launcherleft.rotation);

	  Instantiate(missile,LauncherRight.position,LauncherRight.rotation);
//play soound here
//also chech if it hits enemy or nt.
	 // missile.transform.parent=MissilesParentInHeirarchy.transform;
	//missile.transform.SetParent(MissilesParentInHeirarchy);
	//Destroy(missile,3f);    //destroy missile after 3 seconds
}
}
