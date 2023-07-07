using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Inimigo2 {
    public abstract void Atacar();
}

public class InimigoFraco2 : Inimigo2 {
    public override void Atacar() {
        Debug.Log("Inimigo Fraco Ataca!");
    }
}

public class InimigoForte2 : Inimigo2 {
    public override void Atacar() {
        Debug.Log("Inimigo Forte Ataca!");
    }
}

public class GerenteInimigos2 : MonoBehaviour {
    void Start() {
        Inimigo2 i1;
        //Erro Inimigo classe abstrata
        //i1 = new Inimigo2();
        i1 = new InimigoFraco2();
        i1.Atacar();
        i1 = new InimigoForte2();
        i1.Atacar();

        List<Inimigo2> lista = new List<Inimigo2>();
        lista.Add(new InimigoFraco2());
        lista.Add(new InimigoForte2());
        foreach (Inimigo2 i in lista) {
            i.Atacar();
        }
    }

    void Update() {

    }
}
