using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
       
       if (other.CompareTag("Sphere")){
           print("Dont know where this is used.");
       }
   }

}
