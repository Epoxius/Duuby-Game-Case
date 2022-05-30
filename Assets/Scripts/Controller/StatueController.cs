using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class StatueController : MonoBehaviour
{
    public HairController hairController;
    public PantController pantController;
    public ShoosController shoosController;
    public TopController topController;
    public DressController dressController;

    public Animator modelAnim;

        [Header("Target Clothes")]
    public Hair.HairEnum hairEnum;
    public Shoes.ShoesEnum shoesEnum;
    public Pants.PantsEnum pantsEnum;
    public Top.TopDress topDress;
    public Dress.DressEnum dressEnum;


    private bool isHairComplate;
    public void SetHair(Hair.HairEnum hair)
    {
        if (hair==hairEnum)
        {
            isHairComplate = true;
            hairController.SetHair(hair);
            modelAnim.SetTrigger("Happy");
            //sevinme
          
        }else if (hair !=Hair.HairEnum.None)
        {
            hairController.SetHair(hair);
            isHairComplate = false;
            modelAnim.SetTrigger("Sad");
            //üzülme
        }
        StageControl();
        
    }

    private bool dressControl;
    public void SetDress(Dress.DressEnum dress)
    {
        if (dressEnum==dress)
        {
            dressControl = true;
            dressController.SetDress(dress);
            modelAnim.SetTrigger("Happy");
        }
        else if (dress != Dress.DressEnum.none)
        {
            dressControl = false;
            dressController.SetDress(dress);
            modelAnim.SetTrigger("Sad");
        }
        StageControl();
    }

    private bool isPantComplate;
    public void SetPant(Pants.PantsEnum pants)
    {
        if (pantsEnum==pants)
        {
            isPantComplate = true;
            pantController.SetPant(pants);
            modelAnim.SetTrigger("Happy");
           
        } else if (pants!=Pants.PantsEnum.None)
        {
            isPantComplate = false;
            pantController.SetPant(pants);
            modelAnim.SetTrigger("Sad");
        }
        StageControl();
    }

    private bool isTopComplate;
    public void SetTop(Top.TopDress top)
    {
        if (topDress ==top)
        {
            isTopComplate = true;
            topController.SetTop(top);
            modelAnim.SetTrigger("Happy");
         
        }
        else if (top != Top.TopDress.None)
        {
            isTopComplate = false;
            topController.SetTop(top);
            modelAnim.SetTrigger("Sad");
        }
        StageControl();
    }

    private bool isShoesComplate;
    public void SetShoos(Shoes.ShoesEnum shoes)
    {
        if (shoes==shoesEnum)
        {
            isShoesComplate = true;
            shoosController.SetShoos(shoes);
            modelAnim.SetTrigger("Happy");
        }
        else if (shoes !=Shoes.ShoesEnum.None)
        {
            shoosController.SetShoos(shoes);
            isShoesComplate = false;
            modelAnim.SetTrigger("Sad");
        }
        StageControl();
    }

    // Win Control
    private void StageControl()
    {
        if (isHairComplate&&isShoesComplate&&isPantComplate&&isHairComplate&&dressControl)
        {
            GameManager.Instance.uıController.winPanel.gameObject.SetActive(true);
            GameManager.Instance.uıController.restartBtn.gameObject.SetActive(true);
            GameManager.Instance.uıController.WinPanelControl();
            modelAnim.SetTrigger("Win");
        }
    }
    


}
