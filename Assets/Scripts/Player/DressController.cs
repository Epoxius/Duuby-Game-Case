using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DressController : MonoBehaviour
{
    public TopController topController;
    public PantController pantController;
    public List<Dress> dresses;
    public Dress.DressEnum dressEnum;
    private void OnTriggerEnter(Collider other)
    {
        var dress = other.gameObject.GetComponent<Dress>();
        if (dress==null) return;
        dress.CollisionPlayer();
        SetDress(dress.dressEnum);  
      
    }
     public void SetDress(Dress.DressEnum dress)
    {
        foreach (var localDress in dresses)
        {
            if (localDress.dressEnum == dress)
            {
                localDress.gameObject.SetActive(true);
                dressEnum = dress;
                topController.ClearTops();
                pantController.ClearPant();
            }
            else
            {
                localDress.gameObject.SetActive(false);
            }
        }
    }
    

    public void ClearAllDress()
    {
        dressEnum = Dress.DressEnum.none;
        foreach (var dress in dresses)
        {
            dress.gameObject.SetActive(false);
        }
    }
    
}
