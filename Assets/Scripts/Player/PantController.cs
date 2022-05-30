using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantController : MonoBehaviour
{
    public List<Pants> pantsList;
    public DressController dressController;
    public Pants.PantsEnum pantsEnum;

    private void OnTriggerEnter(Collider other)
    {
        var pant = other.gameObject.GetComponent<Pants>();
        if (pant == null) return;
        pant.CollisionPlayer();
        SetPant(pant.pantsEnum);
    }

    public void SetPant(Pants.PantsEnum pant)
    {
        foreach (var localPants in pantsList)
        {
            if (localPants.pantsEnum == pant)
            {
                localPants.gameObject.SetActive(true);
                pantsEnum = pant;
                dressController.ClearAllDress();
            }
            else
            {
                localPants.gameObject.SetActive(false);
            }
        }
    }

    public void ClearPant()
    {
        pantsEnum = Pants.PantsEnum.None;
        foreach (var pant in pantsList)
        {
            pant.gameObject.SetActive(false);
        }
    }
}