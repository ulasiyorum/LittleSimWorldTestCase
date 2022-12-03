using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        if (GameHandler.Instance.sceneInfo.outside)
            transform.position = new Vector2(GameHandler.Instance.sceneInfo.lastPosition.x - 1,GameHandler.Instance.sceneInfo.lastPosition.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
