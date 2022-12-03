using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloth : MonoBehaviour
{
    private int clothID;
    private string clothName;
    private int price;
    private ClothType type;

    public int ID { get => clothID; }
    public string Name { get => clothName; }
    public int Price { get => price; }
    public ClothType Type { get => type; }

    public Cloth(int id)
    {
        switch (id)
        {
            case 0:
                this.clothID = 0;
                this.name = "Black Hat";
                this.price = 100;
                this.type = new ClothType(true);
                break;
            case 1:
                this.clothID = 1;
                this.name = "Straw Hat";
                this.price = 150;
                this.type = new ClothType(true);
                break;
            case 2:
                this.clothID = 2;
                this.name = "Sunglass";
                this.price = 200;
                this.type = new ClothType();
                break;
            case 3:
                this.clothID = 3;
                this.name = "Chain Necklace";
                this.price = 60;
                this.type = new ClothType();
                break;
            case 4:
                this.clothID = 4;
                this.name = "White T-Shirt";
                this.price = 100;
                this.type = new ClothType(default,true);
                break;
            case 5:
                this.clothID = 5;
                this.name = "Purple T-Shirt";
                this.price = 120;
                this.type = new ClothType(default, true);
                break;
            case 6:
                this.clothID = 6;
                this.name = "Sweatshirt";
                this.price = 250;
                this.type = new ClothType(default, true);
                break;
            case 7:
                this.clothID = 7;
                this.name = "Jeans";
                this.price = 150;
                this.type = new ClothType(default,default,true);
                break;
            case 8:
                this.clothID = 8;
                this.name = "Black Jeans";
                this.price = 200;
                this.type = new ClothType(default, default, true);
                break;
            case 9:
                this.clothID = 9;
                this.name = "Cargo Pants";
                this.price = 250;
                this.type = new ClothType(default, default, true);
                break;
            case 10:
                this.clothID = 10;
                this.name = "Sneakers";
                this.price = 200;
                this.type = new ClothType(default, default, default,true);
                break;
            case 11:
                this.clothID = 11;
                this.name = "Boots";
                this.price = 400;
                this.type = new ClothType(default, default, default,true);
                break;
            case 12:
                this.clothID = 12;
                this.name = "Shoes";
                this.price = 300;
                this.type = new ClothType(default, default, default,true);
                break;
            case 13:
                this.clothID = 13;
                this.name = "Dress";
                this.price = 400;
                this.type = new ClothType(default, true, true, default);
                break;
        }
    }
}
