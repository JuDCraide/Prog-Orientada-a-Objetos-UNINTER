using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnDisable() {
        Debug.Log("SUMINDO!!!");
    }

    private void OnEnable() {
        Debug.Log("APARECENDO!!!");
    }
}
