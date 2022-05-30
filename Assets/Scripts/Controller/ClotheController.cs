using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClotheController : MonoBehaviour
{
    public StatueController statueController;

    private void OnTriggerEnter(Collider other)
    {
        var pantController = other.GetComponent<PantController>();
        if (pantController)
        {
            statueController.SetPant(pantController.pantsEnum);
        }
        var dressController = other.GetComponent<DressController>();
        if (dressController)
        {
            statueController.SetDress(dressController.dressEnum);
        }

        var topController = other.GetComponent<TopController>();
        if (topController)
        {
            statueController.SetTop(topController.topDress);
        }

        var shoosController = other.GetComponent<ShoosController>();
        if (shoosController)
        {
            statueController.SetShoos(shoosController.shoesEnum);
        }

        var hairController = other.GetComponent<HairController>();
        if (hairController)
        {
            statueController.SetHair(hairController.activeHair);
        }

    }
}
