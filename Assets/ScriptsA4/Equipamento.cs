using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Novo Equipamento", menuName = "Equipamento")]

public class Equipamento : ScriptableObject {
    public string nome;
    public int peso;
    public int valor;
    public Sprite arte;
    
    //public Equipamento(string nome, int peso, int valor, Sprite arte) {
    //    this.nome = nome;
    //    this.peso = peso;
    //    this.valor = valor;
    //    this.arte = arte;
    //}

}
