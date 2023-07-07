using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo {
    public virtual void Atacar() {
        Debug.Log("Inimigo Ataca!");
    }
}

public class InimigoFraco : Inimigo {
    public override void Atacar() {
        Debug.Log("Inimigo Fraco Ataca!");
    }
}

public class InimigoForte : Inimigo {
    public override void Atacar() {
        Debug.Log("Inimigo Forte Ataca!");
    }

    public void Atacar(int Forca) {
        Debug.Log("Inimigo Forte Ataca com Força " + Forca);
    }
}


public class GerenteInimigos : MonoBehaviour {
    void Start() {
        // Polimorfismo Universal Subtipage
        Inimigo i1 = new Inimigo();
        i1.Atacar();
        i1 = new InimigoFraco();
        i1.Atacar();
        i1 = new InimigoForte();
        i1.Atacar();

        // Polimorfismo Universal Paramético -> Generics
        List<Inimigo> lista = new List<Inimigo>();
        lista.Add(new Inimigo());
        lista.Add(new InimigoFraco());
        lista.Add(new InimigoForte());
        foreach (Inimigo i in lista) {
            i.Atacar();
        }

        // Polimorfismo Ad-hoc Overloading/Sobrecarga
        InimigoForte i2 = new InimigoForte();
        i2.Atacar();
        i2.Atacar(100);

        // Polimorfismo Ad-hoc Coerção
        i2.Atacar((int) 105.6f);
    }

    // Update is called once per frame
    void Update() {

    }
}
