using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private static Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        
    }
    public async static void Change()
    {
        animator.Play("FadeIn");
        GameHandler.Instance.sceneInfo.direction = CharacterMovement.direction;
        GameHandler.Instance.sceneInfo.inventory = GameHandler.Instance.player.Inventory;
        GameHandler.Instance.sceneInfo.balance = GameHandler.Instance.player.Balance;
        GameHandler.Instance.sceneInfo.wearingIndex = GameHandler.Instance.player.wearingIndex;
        await Task.Delay((int)animator.GetCurrentAnimatorStateInfo(0).length * 400);
        if (SceneManager.GetActiveScene().name.ToLower() == "outside")
        {
            SceneManager.LoadScene("Inside");
        }
        else
        {
            SceneManager.LoadScene("Outside");
        }
        
    }
}
