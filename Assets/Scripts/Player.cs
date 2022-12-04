using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private List<Cloth> inventory;
    public List<Cloth> Inventory { get => inventory; }

    public int[] wearingIndex; // 0=>Head 1=>Top 2=>Bottom 3=>Feet 4=>Accessory

    public int Balance { get; set; }



    void Start()
    {
        if (GameHandler.Instance.sceneInfo.outside)
            transform.position = new Vector2(GameHandler.Instance.sceneInfo.lastPosition.x - 1,GameHandler.Instance.sceneInfo.lastPosition.y-1);

        inventory = new List<Cloth>
        {
            new Cloth(0)
        };

        wearingIndex = new int[5];
    }

   public void BuyItems(List<Cloth> cart,int cost)
    {
        foreach (Cloth cl in cart)
            inventory.Add(cl);

        Balance -= cost;
    }
}
