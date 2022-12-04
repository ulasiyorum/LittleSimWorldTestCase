using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloth
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
            case 1:
                this.clothID = 1;
                this.clothName = "Black Hat";
                this.price = 100;
                this.type = new ClothType(true);
                break;
            case 2:
                this.clothID = 2;
                this.clothName = "Straw Hat";
                this.price = 150;
                this.type = new ClothType(true);
                break;
            case 3:
                this.clothID = 3;
                this.clothName = "Sunglasses";
                this.price = 200;
                this.type = new ClothType();
                break;
            case 4:
                this.clothID = 4;
                this.clothName = "Chain Necklace";
                this.price = 60;
                this.type = new ClothType();
                break;
            case 5:
                this.clothID = 5;
                this.clothName = "White T-Shirt";
                this.price = 100;
                this.type = new ClothType(default,true);
                break;
            case 6:
                this.clothID = 6;
                this.clothName = "Purple T-Shirt";
                this.price = 120;
                this.type = new ClothType(default, true);
                break;
            case 7:
                this.clothID = 7;
                this.clothName = "Sweatshirt";
                this.price = 250;
                this.type = new ClothType(default, true);
                break;
            case 8:
                this.clothID = 8;
                this.clothName = "Jeans";
                this.price = 150;
                this.type = new ClothType(default,default,true);
                break;
            case 9:
                this.clothID = 9;
                this.clothName = "Black Jeans";
                this.price = 200;
                this.type = new ClothType(default, default, true);
                break;
            case 10:
                this.clothID = 10;
                this.clothName = "Cargo Pants";
                this.price = 250;
                this.type = new ClothType(default, default, true);
                break;
            case 11:
                this.clothID = 11;
                this.clothName = "Sneakers";
                this.price = 200;
                this.type = new ClothType(default, default, default,true);
                break;
            case 12:
                this.clothID = 12;
                this.clothName = "Boots";
                this.price = 400;
                this.type = new ClothType(default, default, default,true);
                break;
            case 13:
                this.clothID = 13;
                this.clothName = "Shoes";
                this.price = 300;
                this.type = new ClothType(default, default, default,true);
                break;
            case 14:
                this.clothID = 14;
                this.clothName = "Dress";
                this.price = 400;
                this.type = new ClothType(default, true, true, default);
                break;
            case 15:
                this.clothID = 15;
                this.clothName = "Tiarra";
                this.price = 250;
                this.type = new ClothType(true);
                break;
            default:
                this.clothID = 0;
                this.clothName = "Default";
                this.price = 0;
                this.type = new ClothType(default,true,true,true);
                break;
        }
    }
}
