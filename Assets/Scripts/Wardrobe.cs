using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Wardrobe : MonoBehaviour
{
    private ClothChanger changer;
    private List<Cloth> tryingOn;
    private void Start()
    {
        changer = GetComponent<ClothChanger>();
        tryingOn = new List<Cloth>();
    }

    public void TryClothesOn(int id)
    {
        Cloth toTry = new Cloth(id);
        changer.Wear(toTry);
        tryingOn.Add(toTry);
        foreach (Cloth cl in tryingOn)
        {
            if (cl.Type.Equals(toTry))
            {
                tryingOn.Remove(cl);
                break;
            }
        }
    }

    public void Revert()
    {
        foreach(int id in GameHandler.Instance.player.wearingIndex)
            changer.Wear(new Cloth(id));

        tryingOn.Clear();
        gameObject.SetActive(false);
    }

    public void Apply()
    {
        GameHandler.Instance.GetComponent<ClothChanger>().ApplyChanges(changer);

        GameHandler.Instance.player.ApplyIndex(tryingOn);

        gameObject.SetActive(false);
    }
}
