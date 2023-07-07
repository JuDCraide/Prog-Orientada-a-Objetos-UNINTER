using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desenvolvedora {
    public string Nome { get; set; }
    public string Pais { get; set; }

    public Desenvolvedora(string Nome, string Pais) {
        this.Nome = Nome;
        this.Pais = Pais;
    }

    public override string ToString() {
        return "Desenvolvedora: " + Nome + ", País de origem: " + Pais;
    }
}

public class Jogo {
    public string Titulo { get; set; }
    public Desenvolvedora Desenvolvedora { get; set; }
    public int Ano { get; set; }

    public Jogo(string Titulo, Desenvolvedora Desenvolvedora, int Ano) {
        this.Titulo = Titulo;
        this.Desenvolvedora = Desenvolvedora;
        this.Ano = Ano;
    }

    public override string ToString() {
        return "Título: " + Titulo + ", " + Desenvolvedora + ", Ano: " + Ano;
    }
}

public enum Midia {
    CD, DVD, Cartucho, Disquete,
}

public class JogoFisico : Jogo {
    public Midia Midia { get; set; }

    public JogoFisico(string Titulo, Desenvolvedora Desenvolvedora, int Ano, Midia Midia)
        : base(Titulo, Desenvolvedora, Ano) {
        this.Midia = Midia;
    }

    public override string ToString() {
        return base.ToString() + ", Midia Física: " + Midia;
    }
}

public class JogoDigital : Jogo {
    public float TamanhoArquivoGB { get; set; }

    public JogoDigital(string Titulo, Desenvolvedora Desenvolvedora, int Ano, float TamanhoArquivoGB)
        : base(Titulo, Desenvolvedora, Ano) {
        this.TamanhoArquivoGB = TamanhoArquivoGB;
    }

    public override string ToString() {
        return base.ToString() + ", Tamanh arquivo: " + TamanhoArquivoGB;
    }
}

public class GerenteJogo : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        Desenvolvedora d1 = new Desenvolvedora("Nintendo", "Japão");
        Debug.Log(d1);
        
        Jogo j1 = new Jogo("Zelda TOTK", d1, 2023);
        Debug.Log(j1);
        
        JogoFisico jf1 = new JogoFisico("Zelda TOTK", d1, 2023, Midia.Cartucho);
        Debug.Log(jf1);

        JogoDigital jd1 = new JogoDigital("Zelda TOTK", d1, 2023, 18.2f);
        Debug.Log(jd1);
    }

    // Update is called once per frame
    void Update() {

    }
}
