using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenus : MonoBehaviour
{
    private static ShopMenus instance;
    public static ShopMenus I
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<ShopMenus>();

            return instance;
        }
    }

    public GameObject shopBackground;
    public GameObject hatsMenu;
    public GameObject topsMenu;
    public GameObject legsMenu;
    public GameObject bootsMenu;
    public GameObject accessoriesMenu;
}
