using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEarth : EnemyA5 {
    public override void AttackAnotherEnemy() {
        target.GetComponent<EnemyA5>().TakeDamage(damage, TypeDamage.Earth);
    }

    public override void TakeDamage(int damage, TypeDamage type = TypeDamage.Normal) {
        if (type == TypeDamage.Earth) {
            damage = (int)(damage * 0.7f);
        }
        else if (type == TypeDamage.Normal) {
            damage = (int)(damage * 1.5f);
        }

        base.TakeDamage(damage, type);
    }

}
