using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ClotheBase : MonoBehaviour
{
    private Collider coll;

    private void Awake()
    {
        if (coll != null) return;
        coll = GetComponent<Collider>();
    }

    public void CollisionPlayer()
    {
        Vector3 saveScale = transform.localScale;
        coll.enabled = false;
        transform.DOScale(Vector3.zero, 0.3f).SetEase(Ease.Linear).OnComplete(() =>
        {
            transform.DOScale(saveScale, 0.3f).SetDelay(3f).SetEase(Ease.Linear).OnComplete(() =>
            {
                coll.enabled = true;
            });
        });
    }
   
    
}
