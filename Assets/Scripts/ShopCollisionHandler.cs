using System.Threading.Tasks;
using UnityEngine;

public class ShopCollisionHandler : MonoBehaviour
{
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ShopMenus.I.shopBackground.SetActive(true);
        string objName = gameObject.name.ToLower();
        Debug.Log(objName);
        if (objName.Contains("accessory"))
        {
            ShopMenus.I.accessoriesMenu.SetActive(true);
        }
        else if (objName.Contains("top"))
        {
            ShopMenus.I.topsMenu.SetActive(true);
        }
        else if (objName.Contains("bottom"))
        {
            ShopMenus.I.legsMenu.SetActive(true);
        }
        else if (objName.Contains("head"))
        {
            ShopMenus.I.hatsMenu.SetActive(true);
        }
        else if (objName.Contains("foot"))
        {
            ShopMenus.I.bootsMenu.SetActive(true);
        }
    }
    
    private async void OnCollisionExit2D(Collision2D collision)
    {
        await Task.Delay(500);
        ShopMenus.I.hatsMenu.SetActive(false);
        ShopMenus.I.accessoriesMenu.SetActive(false);
        ShopMenus.I.topsMenu.SetActive(false);
        ShopMenus.I.legsMenu.SetActive(false);
        ShopMenus.I.bootsMenu.SetActive(false);
        ShopMenus.I.shopBackground.SetActive(false);
    }
}
