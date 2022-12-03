using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovement : MonoBehaviour
{
    private void Update()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");
        transform.position += new Vector3(movX * 4.4f * Time.deltaTime, movY * 4.4f * Time.deltaTime);
    }
}
