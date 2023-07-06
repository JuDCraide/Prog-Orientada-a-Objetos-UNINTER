using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stage {
    public string name;
    public int dificulty;
    public Points points;

    public Stage() {
        dificulty = 0;
        points = new Points(0, 0, 0);
    }
}

[System.Serializable]
public class Points {
    public int points1;
    public int points2;
    public int points3;

    public Points() { }

    public Points(int points1, int points2, int points3) {
        this.points1 = points1;
        this.points2 = points2;
        this.points3 = points3;
    }

    public int Avarage() {
        return (points1 + points2 + points3) / 3;
    }

    public int WeightedAverage() {
        int weigh1 = 2;
        int weigh2 = 3;
        int weigh3 = 5;
        return (points1 * weigh1 + points2 * weigh2 + points3 * weigh3) / (weigh1 + weigh2 + weigh3);
    }

    public char ConvertPoints(int points) {
        if (points >= 95) {
            return 'S';
        }
        else if (points >= 80) {
            return 'A';
        }
        else if (points >= 60) {
            return 'B';
        }
        else if (points >= 40) {
            return 'C';
        }
        else {
            return 'X';
        }
    }
}

public class Rank : MonoBehaviour {
    public Points points;

    // Start is called before the first frame update
    void Start() {
        points = new Points(0, 0, 0);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.A)) {
            int result = points.Avarage();
            Debug.Log("Nota: " + result + " Rank: " + points.ConvertPoints(result));
        }
        else if (Input.GetKeyDown(KeyCode.W)) {
            int result = points.WeightedAverage();
            Debug.Log("Nota: " + result + " Rank: " + points.ConvertPoints(result));
        }
    }
}

