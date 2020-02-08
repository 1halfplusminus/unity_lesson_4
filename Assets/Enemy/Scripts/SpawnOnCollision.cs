using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class SpawnOnCollision : MonoBehaviour
{
    public SpawnableInstance instance;
    public List<GameObject> ignores = new List<GameObject>();
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("SpawnOnCollision: " + ignores.Count);
        if (!ignores.Contains(other.gameObject))
        {
            StartCoroutine(instance.Spawn(other.gameObject));
        }
    }

    public void AddIgnore(GameObject obj)
    {
        ignores.Add(obj);
    }
}
