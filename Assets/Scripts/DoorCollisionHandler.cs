using System.Threading.Tasks;
using UnityEngine;


public class DoorCollisionHandler : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private async void OnCollisionEnter2D(Collision2D collision)
    {
        if (GameHandler.Instance.sceneInfo.outside)
            GameHandler.Instance.sceneInfo.lastPosition = collision.transform.position;


        anim.Play("DoorOpening");
        await Task.Delay((int)anim.GetCurrentAnimatorStateInfo(0).length * 480);
        GameHandler.Instance.sceneInfo.outside = !GameHandler.Instance.sceneInfo.outside;
        SceneChanger.Change();
    }
}
