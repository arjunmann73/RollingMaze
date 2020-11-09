using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatformForward : MonoBehaviour
{
    private float Sign = -1f;
    public float start;
    public float end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //print(transform.position.z);
        //print(Sign);
        transform.position += Sign * Time.deltaTime * 2 * transform.forward;
        if (transform.position.z > end){
             Sign = -1f;
        } 
        else if (transform.position.z < start){
             Sign = 1f;
        }   
    }
}
