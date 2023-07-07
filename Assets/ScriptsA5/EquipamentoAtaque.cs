using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Novo Equipamento Ataque", menuName = "Equipamento Ataque")]
public class EquipamentoAtaque : EquipamentoA5Scriptable {
    public int ataque;

    public override string Descricao() {
        return "Ataque: " + ataque;
    }
}
