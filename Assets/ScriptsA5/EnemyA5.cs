using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum TypeDamage {
    Normal, Fire, Water, Earth
}

public class EnemyA5 : MonoBehaviour {
    public int initialHealth = 100;
    int health;
    private new Renderer renderer;
    public int damage = 10;
    public GameObject target;


    public virtual void AttackAnotherEnemy() {
        target.GetComponent<EnemyA5>().TakeDamage(damage);
    }

    public virtual void TakeDamage(int damage, TypeDamage type = TypeDamage.Normal) {
        health -= damage;

        if (health > 50 * initialHealth / 100) {
            renderer.material.color = Color.green;
        }
        else if (health > 30 * initialHealth / 100) {
            renderer.material.color = Color.yellow;
        }
        else {
            renderer.material.color = Color.red;
        }
        if (health <= 0) {
            Die();
        }
    }

    public void Die() {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start() {
        renderer = GetComponent<Renderer>();
        health = initialHealth;
        TakeDamage(0);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            Debug.Log("KeyCode.Q");
            AttackAnotherEnemy();
        }
    }
}
