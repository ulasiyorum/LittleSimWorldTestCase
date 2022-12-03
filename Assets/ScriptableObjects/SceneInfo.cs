using UnityEngine;



[CreateAssetMenu(fileName ="SceneInfo", menuName ="SceneInfo")]
public class SceneInfo : ScriptableObject {

    public Vector2 lastPosition;
    public bool outside;
    private void OnEnable()
    {
        lastPosition = GameHandler.Instance.player.transform.position;
        outside = true;
    }

}
