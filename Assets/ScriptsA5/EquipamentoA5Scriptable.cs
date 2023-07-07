using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Raridade {
    normal, incomum, raro
}

public class EquipamentoA5Scriptable : ScriptableObject {
    public string nome;
    public int peso;
    public int valor;
    public Sprite arte;
    public Raridade raridade;


    public virtual string Descricao() {
        return "";
    }
}
