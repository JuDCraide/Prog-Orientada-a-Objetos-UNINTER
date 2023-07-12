using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleChamada : MonoBehaviour {

    Material material;

    // Start is called before the first frame update
    void Start() {
        material = GetComponent<Renderer>().material;
    }

    void TracaCorInvoke() {
        material.color = Color.HSVToRGB(Random.Range(0f, 1f), 1f, 1f);
    }

    public void LancarInvoke() {
        InvokeRepeating(nameof(this.TracaCorInvoke), 1, 1);
    }

    IEnumerator TrocaCorCorotine() {
        while(true) {
            material.color = Color.HSVToRGB(Random.Range(0f, 1f), 1f, 1f);
            yield return new WaitForSeconds(2.0f);
        }
    }

    public void LancarCoroutine() {
        StartCoroutine(TrocaCorCorotine());
    }

    // Update is called once per frame
    void Update() {

    }
}
