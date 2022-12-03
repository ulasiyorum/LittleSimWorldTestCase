using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashierCollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject cashierOptions;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        cashierOptions.SetActive(true);
    }
}
