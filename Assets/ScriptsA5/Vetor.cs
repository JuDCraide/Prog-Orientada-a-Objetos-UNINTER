using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector2D {
    public float x, y;

    public Vector2D(float x, float y) {
        this.x = x;
        this.y = y;
    }

    public Vector2D Soma(Vector2D outro) {
        return new Vector2D(this.x + outro.x, this.y + outro.y);
    }

    // Sobrecarga Operadores
    public static Vector2D operator +(Vector2D a, Vector2D b) {
        return new Vector2D(a.x + b.x, a.y + b.y);
    }

    public override string ToString() {
        return "Vector2D { x = " + x + ", y = " + y + " }";
    }
}

public class Vetor : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        Vector2D A = new Vector2D(10, 20);
        Vector2D B = new Vector2D(30, 40);
        Debug.Log("A.Soma(B) => " + A.Soma(B));

        Vector2D C = A + B;
        Debug.Log("C = A + B => " + C);
    }

    // Update is called once per frame
    void Update() {

    }
}
