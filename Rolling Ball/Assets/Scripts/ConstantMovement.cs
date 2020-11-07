using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMovement : MonoBehaviour
{
    private float Sign = -1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Sign * Time.deltaTime * 2 * transform.forward;
        if (transform.position.z > 6f){
             Sign = -1f;
        } 
        else if (transform.position.z < 0f){
             Sign = 1f;
        }   
    }
}
