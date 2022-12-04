using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PopUpTextPrefab : MonoBehaviour
{
    private Text text;
    private Vector3 moveUp = new Vector2(0,.0024f);
    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.color = new Color(text.color.r,text.color.g,text.color.b,text.color.a - Time.deltaTime);
        transform.position += moveUp;
    }
}
