using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface IAtacar {
    void Atacar();
}

public class EquipamentoA5 {
    public string nome;
    public int peso;
    public int valor;
    public Sprite arte;
}

public class Espada : EquipamentoA5, IAtacar {
    public void Atacar() {
        Debug.Log("Ataque com Espada");
    }
}

public class Arco : EquipamentoA5, IAtacar {
    public void Atacar() {
        Debug.Log("Ataque com Arco");
    }
}

public class Habilidade { }

public class Magia : Habilidade, IAtacar {
    public void Atacar() {
        Debug.Log("Ataque com Magia");
    }
}

public class InterfaceAtacar : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        List<IAtacar> list = new List<IAtacar>();
        list.Add(new Espada());
        list.Add(new Magia());
        list.Add(new Arco());

        foreach (IAtacar i in list) {
            i.Atacar();
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
