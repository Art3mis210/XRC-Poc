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
    [SerializeField] int stepNumber1, stepNumber2;
    [SerializeField] Outline line;
    bool TaskCompleted;
    public void PullOutBrokenPlug()
    {
        TVWireAnimator.SetBool("PlugOutWire", true);
        UnPlugInteractable.SetActive(false);
        NewPlugTrigger.SetActive(true);
        GameManager.instance.CheckSteps(stepNumber1);
        line.OutlineColor = Color.red;
    }

    public void NewPlugAdded()
    {

        NewPlug.SetActive(true);
        BrokenPlug.SetActive(false);
    }    

    public void NewPlugPluggedIN()
    {
        if(!TaskCompleted)
        {
            TaskCompleted = true;
            TVWireAnimator.SetBool("PlugOutWire", false);
            GameManager.instance.CheckSteps(stepNumber2);
        }
        
    }
}
