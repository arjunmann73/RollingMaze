using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cans : MonoBehaviour
{


    private void OnTriggerEnter(Collider other){
        //print("HERE");
        if (other.CompareTag("Player")){
            print("YOU LOSE!");

            other.transform.position = new Vector3(-7.6f, 0.81f, -16.5f);
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
