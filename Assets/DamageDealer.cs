using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public float damageAmount = 10;

    private void OnCollisionEnter(Collision collision)
    {
        /*if(collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth health = collision.gameObject.GetComponent<PlayerHealth>();
            health.DecreaseHealth(damageAmount);
        }*/

        if (collision.gameObject.TryGetComponent(out PlayerHealth health)) 
        {
            health.DecreaseHealth(damageAmount);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out PlayerHealth health))
        {
            health.DecreaseHealth(damageAmount);
        }
    }
}
