using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class CashierCollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject cashierOptions;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        cashierOptions.SetActive(true);
    }
    private async void OnTriggerExit2D(Collider2D collision)
    {
        await Task.Delay(800);
        cashierOptions.SetActive(false);
    }
}
