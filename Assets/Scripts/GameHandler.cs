using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    private static GameHandler instance;
    public static GameHandler Instance
    {
        get
        {
            if(instance == null)
                instance = FindObjectOfType<GameHandler>();

            return instance;
        }
    }

    public SceneInfo sceneInfo;
    public Player player;
}
