using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TipoArma {
    Forca, Agilidade, Inteligencia
}

[System.Serializable]
public class Lutador {
    [field:SerializeField]
    public int Forca { get; private set; }
    [field: SerializeField]
    public int Agilidade { get; private set; }
    [field: SerializeField]
    public int Inteligencia { get; private set; }
    public int Vida { get; private set; }

    public Lutador(int Forca, int Agilidade, int Inteligencia, int Vida) {
        this.Forca = Forca;
        this.Agilidade = Agilidade;
        this.Inteligencia = Inteligencia;
        this.Vida = Vida;
    }
}

public class Arma {
    public float DanoMinimo { get; private set; }
    public float DanoMaximo { get; private set; }
    public float AtaquePorSegundo { get; private set; }
    public TipoArma Tipo { get; private set; }

    public Arma(float DanoMinimo, float DanoMaximo, float AtaquePorSegundo, TipoArma Tipo) {
        this.AtaquePorSegundo = AtaquePorSegundo;
        this.DanoMinimo = DanoMinimo;
        this.DanoMaximo = DanoMaximo;
        this.Tipo = Tipo;
    }

    public float Ataque(Lutador portador) {
        float danoSorteado = Random.Range(DanoMinimo, DanoMaximo);

        return aplicarMultiplicadores(danoSorteado, portador);
    }

    private float aplicarMultiplicadores(float dano, Lutador portador) {
        int atributo = 0;

        if (Tipo == TipoArma.Forca) {
            atributo = portador.Forca;
        }
        else if (Tipo == TipoArma.Agilidade) {
            atributo = portador.Agilidade;
        }
        else if (Tipo == TipoArma.Inteligencia) {
            atributo = portador.Inteligencia;
        }

        dano += dano * atributo * 0.01f;
        return dano;
    }

    public float DPS(Lutador portador) {
        float dano = (DanoMaximo + DanoMinimo) / 2;

        dano = aplicarMultiplicadores(dano, portador);
        dano *= AtaquePorSegundo;

        return dano;
    }
}

public class GerenteLuta : MonoBehaviour {
    [field: SerializeField]
    public Lutador Lutador { get; private set; }
    public Arma Arma { get; private set; }

    void Attack() {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("EnemyA3");

        foreach (GameObject enemy in enemies) {
            int dano = (int)Arma.Ataque(Lutador);
            enemy.GetComponent<EnemyA3>().TakeDamage(dano);

            Debug.Log("Dano no inimigo: " + dano);
        }
    }

    void Start() {
        Lutador = new Lutador(70, 50, 30, 100);
        Arma = new Arma(50, 75, 1.1f, TipoArma.Forca);
        Debug.Log("DPS: " + Arma.DPS(Lutador));
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.A)) {
            Attack();
        }
    }
}
