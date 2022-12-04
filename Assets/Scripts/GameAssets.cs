using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets instance;
    public static GameAssets Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<GameAssets>();

            return instance;
        }
    }

    public Sprite[] Clothes_ArmL;
    public Sprite[] Clothes_ArmR;
    public Sprite[] Clothes_LegL;
    public Sprite[] Clothes_LegR;
    public Sprite[] Clothes_Body;
    public Sprite[] Clothes_Head;
    public Sprite[] Clothes_FootR;
    public Sprite[] Clothes_FootL;


    public GameObject popUpPrefab;

}
