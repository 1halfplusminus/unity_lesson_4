using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlateform : MonoBehaviour
{
    public Vector3 rotate = Vector3.zero;

    public float speed = 1.0f;

    private Quaternion startingRotation;

    private Vector3 randomRotation;
    // Start is called before the first frame update
    void Start()
    {
        startingRotation = transform.rotation;
        randomRotation = GenerateRandomRotation();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(randomRotation), speed * Time.deltaTime);
        if (transform.localRotation.eulerAngles == randomRotation)
        {
            randomRotation = GenerateRandomRotation();
        }

    }

    Vector3 GenerateRandomRotation()
    {
        return new Vector3(Random.Range(0, rotate.x), Random.Range(0, rotate.y), Random.Range(0, rotate.z));
    }
}
