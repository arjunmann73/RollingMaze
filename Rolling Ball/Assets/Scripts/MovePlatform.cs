using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
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
        //print(transform.position.x);
        //print(Sign);
        transform.position += Sign * Time.deltaTime * 2 * transform.right;
        if (transform.position.x > end){
             Sign = -1f;
        } 
        else if (transform.position.x < start){
             Sign = 1f;
        }   
    }
}
