using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkWithCashier : MonoBehaviour
{
    [SerializeField] GameObject talkingBox;


    public void Talking(int option)
    {
        talkingBox.SetActive(true);
        if(option == 1)
        {
            talkingBox.GetComponentInChildren<Text>().text = "You can go ahead and pick clothes from those hangers if you like any";
        }
        else if(option == 2)
        {
            talkingBox.GetComponentInChildren<Text>().text = "Yes of course.";
        }
        else
        {
            talkingBox.GetComponentInChildren<Text>().text = "Not at the moment"; // to be implemented
        }
    }
}
