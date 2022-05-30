using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoosController : MonoBehaviour
{
    public List<Shoes> shoesList;
    public Shoes.ShoesEnum shoesEnum;

    private void OnTriggerEnter(Collider other)
    {
        var shoes = other.gameObject.GetComponent<Shoes>();
        if (shoes == null) return;
        SetShoos(shoes.shoesEnum);
        shoes.CollisionPlayer();
    }

    public void SetShoos(Shoes.ShoesEnum shoes)
    {
        foreach (var localShoes in shoesList)
        {
            if (localShoes.shoesEnum == shoes)
            {
                localShoes.gameObject.SetActive(true);
                shoesEnum = shoes;
            }
            else
            {
                localShoes.gameObject.SetActive(false);
            }
        }
    }
}