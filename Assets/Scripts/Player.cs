using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private List<Cloth> inventory;
    public List<Cloth> Inventory { get => inventory; }

    public int[] wearingIndex; // 0=>Head 1=>Top 2=>Bottom 3=>Feet 4=>Accessory

    public int Balance { get; set; }



    void Awake()
    {
        if (GameHandler.Instance.sceneInfo.outside)
            transform.position = new Vector2(GameHandler.Instance.sceneInfo.lastPosition.x - 1,GameHandler.Instance.sceneInfo.lastPosition.y-1);

        inventory = new List<Cloth>
        {
            new Cloth(0)
        };

        wearingIndex = new int[5];
        Balance = 5000;
    }

    public void BuyItems(List<Cloth> cart,int cost)
    {
        foreach (Cloth cl in cart)
            inventory.Add(cl);

        Balance -= cost;
    }

    public void ApplyIndex(List<Cloth> cloths)
    {
        foreach (Cloth cl in cloths) 
        {
            ClothType type = cl.Type;
            if (type.isHead)
            {
                wearingIndex[0] = cl.ID;
            }
            if(type.isBody)
            {
                wearingIndex[1] = cl.ID;
            }
            if (type.isLegs)
            {
                wearingIndex[2] = cl.ID;
            }
            if(type.isFeet)
            {
                wearingIndex[3] = cl.ID;
            }
            if (type.isNone)
            {
                wearingIndex[4] = cl.ID;
            }
        }
    }
}
