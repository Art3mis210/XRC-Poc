using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVPlug : MonoBehaviour
{
    [SerializeField] Animator TVWireAnimator;
    [SerializeField] GameObject NewPlugTrigger;
    [SerializeField] GameObject NewPlug;
    [SerializeField] GameObject UnPlugInteractable;
    [SerializeField] GameObject BrokenPlug;
    public void PullOutBrokenPlug()
    {
        TVWireAnimator.SetBool("PlugOutWire", true);
        UnPlugInteractable.SetActive(false);
        NewPlugTrigger.SetActive(true);
    }

    public void NewPlugAdded()
    {

        NewPlug.SetActive(true);
        BrokenPlug.SetActive(false);
    }    

    public void NewPlugPluggedIN()
    {
        TVWireAnimator.SetBool("PlugOutWire", false);
    }
}
