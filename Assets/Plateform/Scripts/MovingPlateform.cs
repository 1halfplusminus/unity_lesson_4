using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlateform : MonoBehaviour
{
    public Vector3 rotate = Vector3.zero;

    public float speed = 1.0f;

    private Quaternion startingRotation;


    private bool backward;

    private Vector3 randomRotation;
    // Start is called before the first frame update
    void Start()
    {
        startingRotation = transform.rotation;
        backward = false;
        randomRotation = GenerateRandomRotation();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(randomRotation), speed * Time.deltaTime);
        if (transform.localRotation.eulerAngles == randomRotation)
        {
            backward = true;
            randomRotation = GenerateRandomRotation();
        }
        /*  if (!backward)
         {
             transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(randomRotation), step);
             Debug.Log(transform.localRotation.eulerAngles);
             if (transform.localRotation.eulerAngles == randomRotation)
             {
                 backward = true;
                 randomRotation = new Vector3(Random.Range(0, rotate.x), rotate.y, Random.Range(0, rotate.z));
             }
         }
         if (backward)
         {
             transform.rotation = Quaternion.RotateTowards(transform.rotation, startingRotation, step);
             if (transform.rotation == startingRotation)
             {
                 backward = false;
                 randomRotation = new Vector3(Random.Range(0, rotate.x), rotate.y, Random.Range(0, rotate.z));
             }
         } */

    }

    Vector3 GenerateRandomRotation()
    {
        return new Vector3(Random.Range(0, rotate.x), Random.Range(0, rotate.y), Random.Range(0, rotate.z));
    }
}
