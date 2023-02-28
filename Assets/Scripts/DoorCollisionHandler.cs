using System.Collections;
using System.Threading.Tasks;
using UnityEngine;


public class DoorCollisionHandler : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GameHandler.Instance.sceneInfo.outside)
            GameHandler.Instance.sceneInfo.lastPosition = collision.transform.position;


        anim.Play("DoorOpening");
        StartCoroutine(ChangeAfter());
    }

    private IEnumerator ChangeAfter()
    {
        yield return new WaitForSeconds((int)anim.GetCurrentAnimatorStateInfo(0).length);
        GameHandler.Instance.sceneInfo.outside = !GameHandler.Instance.sceneInfo.outside;
        SceneChanger.Change();
    }
}
