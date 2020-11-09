using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        //print("HERE");
        if (other.CompareTag("Player")){
            print("YOU LOSE!");

            other.transform.position = new Vector3(-3f, 3.2f, 3.35f);
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
