using System.Collections;
using System.Collections.Generic;
using TestTusk;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class GrenadeTrigger : MonoBehaviour
{
    EnemyHealth _damage;
    float _damg = 20f;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))



            col.TryGetComponent(out EnemyHealth _damage);

        _damage.ApllyDamage(_damg);




    }



}
