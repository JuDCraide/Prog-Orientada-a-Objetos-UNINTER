using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExibirEquipamento : MonoBehaviour {

    public Equipamento Equipamento;
    public Text Nome;
    public Text Peso;
    public Text Valor;
    public Image Arte;

    // Start is called before the first frame update
    void Start() {
        Nome.text = Equipamento.nome;
        Peso.text = "Peso: " + Equipamento.peso;
        Valor.text = "Valor: " + Equipamento.valor;
        Arte.sprite = Equipamento.arte;

    }

    // Update is called once per frame
    void Update() {

    }
}
