using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class SpawnProtectionRing : MonoBehaviour
{
    public SpawnableInstance instance;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<PlayerController>() && !other.gameObject.GetComponentInChildren<ProtectionRing>())
        {
            instance.StartCoroutine(instance.Spawn(other.gameObject));
            Destroy(gameObject);
        }
    }
}
