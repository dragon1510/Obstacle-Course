using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
   private void OnCollisionEnter(Collision other) 
   {
        Debug.Log(other.gameObject);
        // the two lines below are same and are for the gameobject on which the script is attached.
        // gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        if(other.gameObject.tag =="Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            gameObject.tag = "Hit";

        }
       


        // this line is for the object which is coliding with the walls.
        // other.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
   }
}
