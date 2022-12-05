using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wardrobe : MonoBehaviour
{
    private ClothChanger changer;
    private ClothChanger temporaryChanger;

    private void Start()
    {
        changer = GameHandler.Instance.GetComponent<ClothChanger>();
        temporaryChanger = changer;
    }

    public void TryClothesOn(int id)
    {
        temporaryChanger = changer;
        changer.Wear(new Cloth(id));
    }

    public void Revert()
    {
        changer = temporaryChanger;
    }

    public void Apply()
    {
        GameHandler.Instance.GetComponent<ClothChanger>().ApplyChanges(changer);
    }
}
