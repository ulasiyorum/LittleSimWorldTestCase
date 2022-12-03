using UnityEngine;



[CreateAssetMenu(fileName ="SceneInfo", menuName ="SceneInfo")]
public class SceneInfo : ScriptableObject {

    public Vector2 lastPosition;
    public int direction;
    public bool outside;
    private void OnEnable()
    {
        direction = 1;
        lastPosition = GameHandler.Instance.player.transform.position;
        outside = true;
    }

}
