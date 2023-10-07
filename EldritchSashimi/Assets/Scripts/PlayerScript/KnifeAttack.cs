using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeAttack : MonoBehaviour
{
    [SerializeField] private float knifeDamage;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            if (other.gameObject.TryGetComponent(out IDamageable DamagePlayer))
            Debug.Log("Enemy in range");
        }
    }
}
