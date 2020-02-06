using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public Transform focalPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var inputV = Input.GetAxis("Vertical");
        var rigid = GetComponent<Rigidbody>();
        rigid.AddForce(focalPoint.forward * inputV * speed);
    }
}
