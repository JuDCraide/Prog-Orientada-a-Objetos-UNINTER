using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Item {
    public string name;
    public int weight;
    public float value;

    public Item(string name, int weight, float value) {
        this.name = name;
        this.weight = weight;
        this.value = value;
    }
}

[System.Serializable]

public class Character {
    public List<Item> backpack;
    public float money;
    public float weighLimit;
    public float currentWeigh;

    public Character(float money, float weighLimit) {
        this.backpack = new List<Item>();
        this.money = money;
        this.weighLimit = weighLimit;
        this.currentWeigh = 0;
    }

    public void BuyItem(Item item) {
        if (this.currentWeigh + item.weight > this.weighLimit) {
            Debug.Log(item.name + " muito pesado");
        }
        else if (this.money < item.value) {
            Debug.Log(item.name + " muito caro");
        }
        else {
            this.currentWeigh += item.weight;
            this.backpack.Add(item);
            this.money -= item.value;
            Debug.Log("Buy " + item.name);
        }
    }

    public void SellItem(string name) {
        Item itemToSell = backpack.SingleOrDefault(x => x.name == name);

        if (itemToSell != null) {
            this.currentWeigh -= itemToSell.weight;
            this.backpack.Remove(itemToSell);
            this.money += itemToSell.value;
            Debug.Log("Sell " + itemToSell.name);
        }
        else {
            Debug.Log(name + " not found!");
        }
    }
}

public class Items : MonoBehaviour {
    public Character p1 = new Character(500, 50);

    // Start is called before the first frame update
    void Start() {
        p1.BuyItem(new Item("Espada", 5, 10));
        p1.BuyItem(new Item("Escudo", 5, 10));
        p1.BuyItem(new Item("Espada Cara", 5, 1000));
        p1.BuyItem(new Item("Escudo Pesadão", 500, 10));
        p1.SellItem("Espada");
        p1.SellItem("Graveto");
    }

    // Update is called once per frame
    void Update() {

    }
}
