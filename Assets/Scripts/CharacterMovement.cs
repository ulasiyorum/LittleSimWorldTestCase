using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovement : MonoBehaviour
{
    public static int direction;
    private Animator anim;
    private void Start()
    {
        direction = GameHandler.Instance.sceneInfo.direction;
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(movX * 4.4f * Time.deltaTime, movY * 4.4f * Time.deltaTime);
        transform.position += move;
        switch (move.x,move.y)
        {
            case ( > 0, > 0): case (> 0, 0): case ( > 0, < 0):
                anim.Play("Character_Move_1");
                direction = 1;
                break;
            case (0,0):
                if (direction == 1)
                    anim.Play("Character_Idle");
                else
                    anim.Play("Character_Idle_Left");
                break;
            case (0, > 0): case (0, < 0):
                if (direction == 1)
                    anim.Play("Character_Move_1");
                else
                    anim.Play("Character_Move_2");
                break;
            case (< 0, < 0): case ( < 0, > 0): case ( < 0, 0):
                direction = -1;
                anim.Play("Character_Move_2");
                break;
            default:
                break;
        }
    }
}
