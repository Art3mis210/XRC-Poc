using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutJoinWires : MonoBehaviour
{
    [SerializeField] Animator topWires;
    [SerializeField] Animator bottomWires;

    [SerializeField] GameObject PlaceHolderMCB;
    [SerializeField] int stepNumber,stepNumber2,stepNumber3;
    bool MCBCanBePlaced;
    bool MCBPlaced;

    public void CutJoin()
    {
        if(!MCBPlaced)
        {
            topWires.SetBool("Cut", true);
            bottomWires.SetBool("Cut", true);
            MCBCanBePlaced = true;
            GameManager.instance.CheckBool(stepNumber);
            GameManager.instance.CheckSteps(stepNumber);
        }
        else
        {
            topWires.SetBool("Cut", false);
            bottomWires.SetBool("Cut", false);
            MCBCanBePlaced = false;
            GameManager.instance.CheckBool(stepNumber3);
            GameManager.instance.CheckSteps(stepNumber3);
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
                GameManager.instance.CheckBool(stepNumber2);
                GameManager.instance.CheckSteps(stepNumber2);
            }
        }
    }

}
