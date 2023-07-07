using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExibirEquipamentoA5 : MonoBehaviour {

    public EquipamentoA5Scriptable Equipamento;
    public Text Nome;
    public Text Peso;
    public Text Valor;
    public Image Arte;
    public Text Descricao;

    // Start is called before the first frame update
    void Start() {
        Nome.text = Equipamento.nome;
        Peso.text = "Peso: " + Equipamento.peso;
        Valor.text = "Valor: " + Equipamento.valor;
        Arte.sprite = Equipamento.arte;
        Descricao.text = Equipamento.Descricao();

        if(Equipamento.raridade == Raridade.incomum) {
            Nome.color = Color.blue;
            //Arte.color = Color.blue;
        }
        else if (Equipamento.raridade == Raridade.raro) {
            Nome.color = Color.red;
            //Arte.color = Color.red;
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
