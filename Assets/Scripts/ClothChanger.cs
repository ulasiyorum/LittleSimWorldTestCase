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

    private void Start()
    {
        Wear(GameHandler.Instance.player.Inventory[0]);
    }

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
        this.ArmL.sprite = toApply.ArmL.sprite;
        this.ArmR.sprite = toApply.ArmR.sprite;
        this.Body.sprite = toApply.Body.sprite;
        this.Head.sprite = toApply.Head.sprite;
        this.LegL.sprite = toApply.LegL.sprite;
        this.LegR.sprite = toApply.LegR.sprite;
        this.FootL.sprite = toApply.FootL.sprite;
        this.FootR.sprite = toApply.FootR.sprite;

    }
    
}
