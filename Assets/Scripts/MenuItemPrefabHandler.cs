using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MenuItemPrefabHandler : MonoBehaviour
{
    [SerializeField] GridLayoutGroup wardrobeContent;
    [SerializeField] GridLayoutGroup cartContent;
    [SerializeField] GridLayoutGroup refundContent;
    private int count;
    private Vector2 wardrobeScale;
    private Vector2 cartScale;
    private Vector2 refundScale;

    private void Start()
    {
        if(wardrobeContent != null)
            wardrobeScale = wardrobeContent.GetComponent<RectTransform>().sizeDelta;
        
        if(cartContent != null)
            cartScale = cartContent.GetComponent<RectTransform>().sizeDelta;

        if (refundContent != null)
            refundScale = refundContent.GetComponent<RectTransform>().sizeDelta;
    }
    public void GetWardrobe()
    {
        float x = wardrobeScale.x;
        float y = wardrobeScale.y;

        for (int i = 0; i<wardrobeContent.transform.childCount; i++)
        {
            Destroy(wardrobeContent.transform.GetChild(i).gameObject);
        }

        foreach (Cloth cl in GameHandler.Instance.player.Inventory)
        {
            GameAssets.Instance.menuItemPrefabs[cl.ID].GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = "EQUIP";
            GameObject go = Instantiate(GameAssets.Instance.menuItemPrefabs[cl.ID]);
            go.transform.parent = wardrobeContent.transform;
            count++;
        }

        
        wardrobeContent.GetComponent<RectTransform>().sizeDelta = new Vector2(x + (x/6 * count), y);
    }

    public void GetCart()
    {
        float x = cartScale.x;
        float y = cartScale.y;

        for (int i = 0; i < cartContent.transform.childCount; i++)
        {
            Destroy(cartContent.transform.GetChild(i).gameObject);
        }

        List<Cloth> cart = GetComponent<ShopCartAndCheckout>().Cart;
        count = 0;

        foreach (Cloth cl in cart)
        {
            GameAssets.Instance.menuItemPrefabs[cl.ID].GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = "REMOVE";
            GameObject go = Instantiate(GameAssets.Instance.menuItemPrefabs[cl.ID]);
            go.transform.parent = cartContent.transform;
            count++;
        }
        cartContent.GetComponent<RectTransform>().sizeDelta = new Vector2(x, y + (y / 8 * count));
    }

    public void GetRefunds()
    {
        float x = refundScale.x;
        float y = refundScale.y;

        for (int i = 0; i < refundContent.transform.childCount; i++)
        {
            Destroy(refundContent.transform.GetChild(i).gameObject);
        }

        foreach (Cloth cl in GameHandler.Instance.player.Inventory)
        {
            GameAssets.Instance.menuItemPrefabs[cl.ID].GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = "REFUND";
            GameObject go = Instantiate(GameAssets.Instance.menuItemPrefabs[cl.ID]);
            go.transform.parent = refundContent.transform;
            count++;
        }


        refundContent.GetComponent<RectTransform>().sizeDelta = new Vector2(x + (x / 6 * count), y);
    }
}
