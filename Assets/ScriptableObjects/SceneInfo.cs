using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName ="SceneInfo", menuName ="SceneInfo")]
public class SceneInfo : ScriptableObject {

    public Vector2 lastPosition;
    public int direction;
    public bool outside;
    public List<Cloth> inventory;
    public int balance;
    public int[] wearingIndex;
    private void OnEnable()
    {
        wearingIndex = new int[5];
        balance = 5000;
        direction = 1;
        lastPosition = GameHandler.Instance.player.transform.position;
        outside = true;
    }
}
