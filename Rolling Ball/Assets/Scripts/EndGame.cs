using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        //print("HERE");
        if (other.CompareTag("Player")){
            Application.Quit();
        }
    }
}
