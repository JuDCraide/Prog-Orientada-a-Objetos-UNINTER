using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Novo Equipamento Defesa", menuName = "Equipamento Defesa")]
public class EquipamentoDefesa : EquipamentoA5Scriptable {
    public int defesa;

    public override string Descricao() {
        return "Defesa: " + defesa;
    }
}
