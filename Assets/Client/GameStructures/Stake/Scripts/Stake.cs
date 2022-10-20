using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stake : MonoBehaviour
{
    [SerializeField]
    private int _damage = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var hitColider = collision.GetComponent<ITakeDamage>();

        if (hitColider != null)
        {
            hitColider.TakeDamage(_damage);
        }

    }
}
