using System.Collections;
using UnityEngine;

public class ProtectionRing : MonoBehaviour
{
    public GameObject prefab;
    public float duration = 60.0f;
    public float force = 10.0f;

    void Start()
    {

        StartCoroutine(WaitDurationAndEnd());
    }
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("On Trigger enter " + collider.gameObject.name);
        Rigidbody rigidbody;
        AIEnemy aIEnemy;
        if (
            collider.gameObject.TryGetComponent<Rigidbody>(out rigidbody)
            && collider.gameObject.TryGetComponent<AIEnemy>(out aIEnemy)
        )
        {
            Vector3 awayFromPlayer = collider.gameObject.transform.position - transform.position;
            rigidbody.AddForce(awayFromPlayer * force, ForceMode.Impulse);
        }
    }


    IEnumerator WaitDurationAndEnd()
    {
        yield return new WaitForSeconds(duration);
        Destroy(gameObject);
    }

}
