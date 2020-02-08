using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemy : MonoBehaviour
{
    public GameObject target;
    public float speed = 3.0f;
    private Rigidbody enemyRb;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            Vector3 lookDirection = (target.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection * speed);
        }

    }
}
