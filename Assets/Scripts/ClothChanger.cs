using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothChanger : MonoBehaviour
{
    [SerializeField] SpriteRenderer ArmL;
    [SerializeField] SpriteRenderer ArmR;
    [SerializeField] SpriteRenderer LegL;
    [SerializeField] SpriteRenderer LegR;
    [SerializeField] SpriteRenderer Body;
    [SerializeField] SpriteRenderer Head;
    [SerializeField] SpriteRenderer FootR;
    [SerializeField] SpriteRenderer FootL;
    

    public void Wear(Cloth cloth)
    {
        if (cloth.Type.isHead)
            Head.sprite = GameAssets.Instance.Clothes_Head[cloth.ID];

        if(cloth.Type.isBody)
        {
            Body.sprite = GameAssets.Instance.Clothes_Body[cloth.ID];
            ArmR.sprite = GameAssets.Instance.Clothes_ArmR[cloth.ID];
            ArmL.sprite = GameAssets.Instance.Clothes_ArmL[cloth.ID];
        }

        if(cloth.Type.isLegs)
        {
            LegR.sprite = GameAssets.Instance.Clothes_LegR[cloth.ID];
            LegL.sprite = GameAssets.Instance.Clothes_LegL[cloth.ID];
        }

        if (cloth.Type.isFeet)
        {
            FootL.sprite = GameAssets.Instance.Clothes_FootL[cloth.ID];
            FootR.sprite = GameAssets.Instance.Clothes_FootR[cloth.ID];
        }
    }
    
    public void ApplyChanges(ClothChanger toApply)
    {
        this.ArmL = toApply.ArmL;
        this.ArmR = toApply.ArmR;
        this.Body = toApply.Body;
        this.Head = toApply.Head;
        this.LegL = toApply.LegL;
        this.LegR = toApply.LegR;
        this.FootL = toApply.FootL;
        this.FootR = toApply.FootR;
    }

}
