using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField] Text balance;
    void Start()
    {
        UpdateBalance();
    }

    public void UpdateBalance()
    {
        balance.text = "" + GameHandler.Instance.player.Balance;
    }
}
