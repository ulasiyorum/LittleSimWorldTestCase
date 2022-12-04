using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartPopUpMessage : MonoBehaviour
{
    public static void Message(string text,Color color)
    {
        GameObject popUp = GameAssets.Instance.popUpPrefab;
        popUp.GetComponent<Text>().color = color;
        popUp.GetComponent<Text>().text = text;
        popUp = Instantiate(popUp, GameHandler.Instance.canvas.transform, false);

        Destroy(popUp, 5);
    }
    
}
