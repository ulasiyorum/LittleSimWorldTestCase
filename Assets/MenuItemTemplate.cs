using UnityEngine.UI;
using UnityEngine;
public class MenuItemTemplate : MonoBehaviour
{
    public int id;

    public void RemoveOrTryCloth()
    {
        if (GetComponentInChildren<Button>().GetComponentInChildren<Text>().text.ToLower() == "equip")
        {
            Wardrobe wardrobe = FindObjectOfType<Wardrobe>();
            wardrobe.TryClothesOn(id);
        }
        else
        {
            GameHandler.Instance.GetComponent<ShopCartAndCheckout>().RemoveFromCart(id);
        }
    }
}
