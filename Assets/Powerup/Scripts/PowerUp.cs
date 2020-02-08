using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUpAction
{
    public PowerUp source;
    public Powerable target;

    public PowerUpEvent action;

    public PowerUpAction(PowerUp source, Powerable target, PowerUpEvent action)
    {
        this.source = source;
        this.target = target;
        this.action = action;
    }
}
[System.Serializable]
public class PowerUpEvent : UnityEvent<PowerUpAction> { }
public class PowerUp : MonoBehaviour
{
    public string id;
    public PowerUpEvent onPowerUp;
    public PowerUpEvent onEndPowerUp;
    void OnCollisionEnter(Collision collision)
    {
        Powerable powerable;
        if (collision.gameObject.TryGetComponent<Powerable>(out powerable))
        {
            powerable.PowerUp(new PowerUpAction(this, powerable, onPowerUp));
        }
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
