using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HairController : MonoBehaviour
{
    public List<Hair> hairList;
    public Hair.HairEnum activeHair;
    private void OnTriggerEnter(Collider other)
    {
        var hair = other.gameObject.GetComponent<Hair>();
        if (hair==null) return;
        hair.CollisionPlayer();
        SetHair(hair.hairEnum);
    }

 
    public void SetHair(Hair.HairEnum hair)
    {
        foreach (var localHair in hairList)
        {
            if (localHair.hairEnum == hair)
            {
                activeHair = hair;
                localHair.gameObject.SetActive(true);
            }
            else
            {
                localHair.gameObject.SetActive(false);
            }
        }
    }
    
}
