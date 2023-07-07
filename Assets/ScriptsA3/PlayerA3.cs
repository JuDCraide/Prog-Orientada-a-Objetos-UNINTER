using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerA3 : MonoBehaviour {
    public int damage = 10;

    void Attack() {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("EnemyA3");

        foreach (GameObject enemy in enemies) {
            enemy.GetComponent<EnemyA3>().TakeDamage(damage);
        }
    }

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            this.Attack();
        }
    }
}
