using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCheckpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        //print("HERE");
        if (other.CompareTag("Player")){
            print("YOU LOSE!");

            other.transform.position = new Vector3(9.25f, 2f, 3.66f);
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
