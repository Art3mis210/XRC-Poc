using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutJoinWires : MonoBehaviour
{
    [SerializeField] Animator topWires;
    [SerializeField] Animator bottomWires;

    [SerializeField] GameObject PlaceHolderMCB;
    [SerializeField] int stepNumber,stepNumber2,stepNumber3;
    public Outline line1,line2;
    bool MCBCanBePlaced;
    bool MCBPlaced;

    public void CutJoin()
    {
        if(!MCBPlaced)
        {
            topWires.SetBool("Cut", true);
            bottomWires.SetBool("Cut", true);
            MCBCanBePlaced = true;
            GameManager.instance.CheckSteps(stepNumber);
            line1.OutlineColor = Color.red;
        }
        else
        {
            topWires.SetBool("Cut", false);
            bottomWires.SetBool("Cut", false);
            MCBCanBePlaced = false;
            GameManager.instance.CheckSteps(stepNumber3);
            line1.OutlineColor = Color.red;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="MCB")
        {
            if(MCBCanBePlaced)
            {
                other.transform.parent.gameObject.SetActive(false);
                PlaceHolderMCB.SetActive(true);
                MCBPlaced = true;
                GameManager.instance.CheckSteps(stepNumber2);
                line2.OutlineColor = Color.red;
            }
        }
    }

}
