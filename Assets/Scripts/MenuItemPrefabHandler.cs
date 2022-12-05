using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MenuItemPrefabHandler : MonoBehaviour
{
    [SerializeField] GridLayoutGroup wardrobeContent;
    [SerializeField] GridLayoutGroup cartContent;
    public void GetWardrobe()
    {
        for(int i = 0; i<wardrobeContent.transform.childCount; i++)
        {
            Destroy(wardrobeContent.transform.GetChild(i).gameObject);
        }
        
        foreach(Cloth cl in GameHandler.Instance.player.Inventory)
        {
            GameAssets.Instance.menuItemPrefabs[cl.ID].GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = "EQUIP";
            GameObject go = Instantiate(GameAssets.Instance.menuItemPrefabs[cl.ID]);
            go.transform.parent = wardrobeContent.transform;
        }
    }

    public void GetCart()
    {
        for (int i = 0; i < cartContent.transform.childCount; i++)
        {
            Destroy(cartContent.transform.GetChild(i).gameObject);
        }

        List<Cloth> cart = GetComponent<ShopCartAndCheckout>().Cart;

        foreach (Cloth cl in cart)
        {
            GameAssets.Instance.menuItemPrefabs[cl.ID].GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = "REMOVE";
            GameObject go = Instantiate(GameAssets.Instance.menuItemPrefabs[cl.ID]);
            go.transform.parent = cartContent.transform;
        }
    }
}
