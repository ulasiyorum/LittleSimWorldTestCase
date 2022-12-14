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
    [SerializeField] GameObject refundMenu;
    [SerializeField] Text total;

    private List<Cloth> refundCart;

    private void Start()
    {
        cartCount.text = "0";
        cart = new List<Cloth>();
        refundCart = new List<Cloth>();
    }
    public void AddToCart(int id)
    {
        foreach(Cloth cl in GameHandler.Instance.player.Inventory)
        {
            if(cl.ID == id)
            {
                StartPopUpMessage.Message("YOU ALREADY HAVE THIS " + new Cloth(id).Type,Color.yellow);
                return;
            }
        }
        foreach(Cloth cl in cart)
        {
            if (cl.ID == id)
            {
                StartPopUpMessage.Message("YOU ALREADY HAVE THIS " + new Cloth(id).Type, Color.yellow);
                return;
            }
        }
        Cloth toAdd = new Cloth(id);
        cart.Add(toAdd);
        total.text = "Total: " + GetTotalPrice();
        StartPopUpMessage.Message("ADDED " + toAdd.Name +" TO CART", Color.green);
        cartCount.text = "" + cart.Count;
    }

    public void EmptyCart()
    {
        cart.Clear();
        GetComponent<MenuItemPrefabHandler>().GetCart();
        total.text = "Total: " + GetTotalPrice();
        cartCount.text = "" + cart.Count;
    }

    private int GetTotalPrice()
    {
        if (cart.Count <= 0)
            return 0;

        int tot = 0;
        foreach(Cloth cl in cart)
        {
            tot += cl.Price;
        }
        return tot;
    }

    public void Checkout()
    {
        if(cart.Count <= 0)
        {
            StartPopUpMessage.Message("NO ITEM FOUND ON CART", Color.red);
            return;
        }

        int cost = 0;

        foreach(Cloth cl in cart)
        {
            cost += cl.Price;
        }

        if (cost >= GameHandler.Instance.player.Balance)
        {
            StartPopUpMessage.Message("NOT ENOUGH BALANCE", Color.red);
            EmptyCart();
            return;
        }

        StartPopUpMessage.Message("BOUGHT SUCCESSFULLY", Color.green);
        GameHandler.Instance.player.BuyItems(cart,cost);
        GetComponent<UIHandler>().UpdateBalance();
        cart.Clear();
        total.text = "Total: " + GetTotalPrice();
        cartCount.text = "" + cart.Count;
        GetComponent<MenuItemPrefabHandler>().GetCart();
    }

    public void OpenCartMenu()
    {
        if(cart.Count == 0)
        {
            StartPopUpMessage.Message("THERE'S NOTHING IN THE CART", Color.yellow);

            return;
        }

        cartMenu.SetActive(true);
    }

    public void RemoveFromCart(int id)
    {
        foreach(Cloth item in Cart)
        {
            if(item.ID == id)
            {
                Cart.Remove(item);
                break;
            }
        }
        total.text = "Total: " + GetTotalPrice();
        GetComponent<MenuItemPrefabHandler>().GetCart();
        cartCount.text = "" + cart.Count;
    }

    public void Refund(int id)
    {
        if(id == 0)
        {
            StartPopUpMessage.Message("NO SUCH ITEM IS REFUNDABLE", Color.red);

            return;
        }

        foreach(Cloth item in GameHandler.Instance.player.Inventory)
        {
            if(item.ID == id && !CartContains(id))
            {
                refundCart.Add(item);
                StartPopUpMessage.Message("CLICK APPLY TO COMPLETE REFUND", Color.green);
            } 
        }
    }
    private bool CartContains(int id)
    {
        foreach(Cloth cl in refundCart)
        {
            if(cl.ID == id)
            { 
                return true;
            }
        }

        return false;
    }
    public void ApplyRefund()
    {
        foreach(Cloth item in refundCart)
        {
            foreach(int wearingID in GameHandler.Instance.player.wearingIndex)
            {
                if(wearingID == item.ID)
                {
                    Wardrobe wd = FindObjectOfType<Wardrobe>(true);
                    wd.gameObject.SetActive(true);
                    wd.TryClothesOn(0);
                    wd.Apply();
                    wd.gameObject.SetActive(false);
                }
            }
            
            GameHandler.Instance.player.RemoveWithID(item.ID);
            GameHandler.Instance.player.Balance += item.Price;
            GetComponent<UIHandler>().UpdateBalance();
            StartPopUpMessage.Message("SUCCESSFULLY REFUNDED", Color.green);
            GetComponent<MenuItemPrefabHandler>().GetRefunds();
            refundMenu.SetActive(false);
        }
        if(refundCart.Count <= 0)
            StartPopUpMessage.Message("NON SELECTED TO REFUND", Color.red);

        refundCart.Clear();
    }

    public void CancelRefund()
    {
        refundCart.Clear();
        refundMenu.SetActive(false);
    }
}
