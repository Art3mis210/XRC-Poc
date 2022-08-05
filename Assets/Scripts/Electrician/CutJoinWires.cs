using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutJoinWires : MonoBehaviour
{
    [SerializeField] Animator topWires;
    [SerializeField] Animator bottomWires;

    [SerializeField] GameObject PlaceHolderMCB;
    bool MCBCanBePlaced;
    bool MCBPlaced;

    public void CutJoin()
    {
        if(!MCBPlaced)
        {
            topWires.SetBool("Cut", true);
            bottomWires.SetBool("Cut", true);
            MCBCanBePlaced = true;
        }
        else
        {
            topWires.SetBool("Cut", false);
            bottomWires.SetBool("Cut", false);
            MCBCanBePlaced = false;
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
            }
        }
    }

}
