using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class CashierCollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject cashierOptions;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        cashierOptions.SetActive(true);
    }
    private async void OnCollisionExit2D(Collision2D collision)
    {
        await Task.Delay(500);
        cashierOptions.SetActive(false);
    }
}
