using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBall : MonoBehaviour
{
    public Rigidbody obj;
    public float hor;
    public float ver;
    private float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        obj = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(hor, 0.0f, ver);

        obj.AddForce(direction * speed);
    }
}
