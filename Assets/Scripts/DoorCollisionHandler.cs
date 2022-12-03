using UnityEngine;


public class DoorCollisionHandler : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(GameHandler.Instance.sceneInfo.outside)
            GameHandler.Instance.sceneInfo.lastPosition = collision.transform.position;
        GameHandler.Instance.sceneInfo.outside = !GameHandler.Instance.sceneInfo.outside;
        SceneChanger.Change();
    }
}
