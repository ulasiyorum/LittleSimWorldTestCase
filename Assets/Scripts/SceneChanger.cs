using System.Collections;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private static Animator animator;
    private static MonoBehaviour instance;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        instance = this;
        
    }
    public static void Change()
    {
        animator.Play("FadeIn");
        GameHandler.Instance.sceneInfo.direction = CharacterMovement.direction;
        GameHandler.Instance.sceneInfo.inventory = GameHandler.Instance.player.Inventory;
        GameHandler.Instance.sceneInfo.balance = GameHandler.Instance.player.Balance;
        GameHandler.Instance.sceneInfo.wearingIndex = GameHandler.Instance.player.wearingIndex;


        instance.StartCoroutine(ChangeAfter());
    }

    private static IEnumerator ChangeAfter()
    {
        yield return new WaitForSecondsRealtime((animator.GetCurrentAnimatorStateInfo(0).length - 0.5f));
        if (Application.loadedLevel == 0)
        {
            Application.LoadLevel(1);
        }
        else
        {
            Application.LoadLevel(0);
        }

    }
}
