using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleTiro : MonoBehaviour {

    public GameObject projetil;
    public float intervalo = 0.5f;
    public bool podeAtira = true;

    // Start is called before the first frame update
    void Start() {
        //Time.timeScale = 0.05f;
    }

    IEnumerator EsperarIntervalo() {
        yield return new WaitForSeconds(intervalo);
        podeAtira = true;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButton(0) && podeAtira) {
            GameObject bala = Instantiate(projetil);
            bala.GetComponent<Rigidbody>().AddForce(Vector3.forward * 5000);
            podeAtira = false;
            StartCoroutine(EsperarIntervalo());
        }
    }
}