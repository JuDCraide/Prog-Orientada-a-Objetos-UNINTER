using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyFire : EnemyA5 {

    public override void AttackAnotherEnemy() {
        target.GetComponent<EnemyA5>().TakeDamage(damage, TypeDamage.Fire);
    }

    public override void TakeDamage(int damage, TypeDamage type = TypeDamage.Normal) {
        Debug.Log("Fire TakeDamage");
        if (type == TypeDamage.Water) {
            damage = (int)(damage * 1.5f);
        }
        else if (type == TypeDamage.Fire) {
            damage = (int)(damage * 0.7f);
        }

        base.TakeDamage(damage, type);
    }
}
