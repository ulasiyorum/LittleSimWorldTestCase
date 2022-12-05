using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopCartAndCheckout : MonoBehaviour
{
    private List<Cloth> cart;
    public List<Cloth> Cart { get => cart; }

    [SerializeField] Text cartCount;
    [SerializeField] GameObject cartMenu;
    private void Start()
    {
        cartCount.text = "0";
        cart = new List<Cloth>();
    }
    public void AddToCart(int id)
    {
        foreach(Cloth cl in GameHandler.Instance.player.Inventory)
        {
            if(cl.ID == id)
            {
                StartPopUpMessage.Message("YOU ALREADY HAVE THIS " + new Cloth(id).Type,Color.yellow);
            }
        }
        cart.Add(new Cloth(id));
        cartCount.text = "" + cart.Count;
    }

    public void EmptyCart()
    {
        cart.Clear();
    }


    public void Checkout()
    {
        int cost = 0;

        foreach(Cloth cl in cart)
        {
            cost += cl.Price;
        }

        if (cost >= GameHandler.Instance.player.Balance)
        {
            StartPopUpMessage.Message("NOT ENOUGH BALANCE", Color.red);
            return;
        }

        GameHandler.Instance.player.BuyItems(cart,cost);
    }

    public void OpenCartMenu()
    {
        if(cart.Count > 0)
        {
            StartPopUpMessage.Message("THERE'S NOTHING IN THE CART", Color.yellow);

            return;
        }

        // Open Menu
    }

    public void RemoveFromCart(int id)
    {
        foreach(Cloth item in Cart)
        {
            if(item.ID == id)
            {
                Cart.Remove(item);
            }
        }
    }
}
