using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnCollisionEvent : UnityEvent<GameObject> { }
public class SimpleCollision : MonoBehaviour
{
    public OnCollisionEvent callback;
    public List<GameObject> ignores = new List<GameObject>();
    private void OnCollisionEnter(Collision other)
    {
        if (!ignores.Contains(other.gameObject))
        {
            callback.Invoke(other.gameObject);
        }
    }
}
