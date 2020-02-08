using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlayer : MonoBehaviour
{
    public GameObject player;

    public void Target(GameObject instance)
    {
        Debug.Log("Asign target ");
        AIEnemy aIEnemy;
        if (instance.TryGetComponent<AIEnemy>(out aIEnemy))
        {
            aIEnemy.target = player;
        }
    }
}
