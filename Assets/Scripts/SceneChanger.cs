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
