using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeAttack : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
       IDamageable damageable = other.GetComponent<IDamageable>();

        if (damageable == null) return;

        damageable.Equals(1);
    }
}
