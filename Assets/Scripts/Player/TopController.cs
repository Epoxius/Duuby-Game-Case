using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopController : MonoBehaviour
{
    public List<Top> topList;
    public DressController dressController;
    public Top.TopDress topDress;

    private void OnTriggerEnter(Collider other)
    {
        var top = other.gameObject.GetComponent<Top>();
        if (top == null) return;
        SetTop(top.topDress);
        top.CollisionPlayer();
    }

    public void SetTop(Top.TopDress top)
    {
        foreach (var localTops in topList)
        {
            if (localTops.topDress == top)
            {
                localTops.gameObject.SetActive(true);
                dressController.ClearAllDress();
                topDress = top;
            }
            else
            {
                localTops.gameObject.SetActive(false);
            }
        }
    }

    public void ClearTops()
    {
        topDress = Top.TopDress.None;
        foreach (var localTops in topList)
        {
            localTops.gameObject.SetActive(false);
        }
    }
}