using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public SpawnableInstance instance;
    PowerUpAction action;

    public void SpawnOn(PowerUpAction action)
    {
        if (!action.target.Has(action))
        {
            this.action = action;
            /*     var instance = Instantiate(prefab, action.target.transform.position, prefab.transform.rotation, target.transform); */
            instance.StartCoroutine(instance.Spawn(action.target.gameObject));
            Destroy(action.source.gameObject);
        }

    }

    public void Destroy()
    {
        action.target.Remove(action);
        Debug.Log("Spwan Destroy");
        this.action = null;
    }
}
