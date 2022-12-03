using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private List<Cloth> inventory;
    public List<Cloth> Inventory { get => inventory; }

    private int[] wearingIndex; // 0=>Head 1=>Top 2=>Bottom 3=>Feet 4=>Accessory



    void Start()
    {
        if (GameHandler.Instance.sceneInfo.outside)
            transform.position = new Vector2(GameHandler.Instance.sceneInfo.lastPosition.x - 1,GameHandler.Instance.sceneInfo.lastPosition.y);

        inventory = new List<Cloth>();
        wearingIndex = new int[5];
    }

   
}
