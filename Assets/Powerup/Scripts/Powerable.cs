using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerable : MonoBehaviour
{
    private List<string> powerUps = new List<string>();
    public void PowerUp(PowerUpAction action)
    {
        Invoke(action);
    }
    void Invoke(PowerUpAction action)
    {
        action.action.Invoke(action);
        powerUps.Add(action.source.id);
    }
    public bool Has(PowerUpAction action)
    {
        return powerUps.Contains(action.source.id);
    }
    public bool Remove(PowerUpAction action)
    {
        return powerUps.Remove(action.source.id);
    }
}
