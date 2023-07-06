using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GerenteLeitura : MonoBehaviour {

    public int resposta;

    // Start is called before the first frame update
    void Start() {
        resposta = Random.Range(0, 1000);
    }

    // Update is called once per frame
    void Update() {

    }

    public void LerPalpite(string entrada) {
        int palpite;
        int.TryParse(entrada, out palpite);
        //Debug.Log("Entrada: " + entrada + " - Palpite: " + palpite);

        string textoSaida;

        if (palpite > resposta) {
            textoSaida = "Um pouco menor...";
        }
        else if (palpite < resposta) {
            textoSaida = "Um pouco maior...";
        }
        else {
            textoSaida = "Acertou! Parabéns!!!";
        }
        //Debug.Log(textoSaida);

        GameObject campoSaida = GameObject.Find("Saida");

        campoSaida.GetComponent<UnityEngine.UI.Text>().text = textoSaida;

    }
}
