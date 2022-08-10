using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricianFuse : MonoBehaviour
{
    [SerializeField]Animator BrokenFuseAnimator;
    [SerializeField] GameObject Fuse;
    [SerializeField] GameObject MicrowaveLight;
    [SerializeField] Transform Door;
    [SerializeField] float DoorTargetRotation;
    public bool FuseRemoved;
    public bool NewFuseAdded;
    public MicrowaveWire wire;
    public int stepNumber1,stepNumber2;
    public Outline line,line2;


    public void RemoveFuse()
    {
        if(!FuseRemoved)
        {
            FuseRemoved = true;
            BrokenFuseAnimator.SetBool("Remove", true);
            GameManager.instance.CheckSteps(stepNumber1);
            line.OutlineColor = Color.red;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(FuseRemoved)
        {
            if(other.gameObject.tag=="Fuse")
            {
                GameManager.instance.CheckSteps(stepNumber2);
                other.gameObject.SetActive(false);
                Fuse.SetActive(true);
                Fuse.GetComponent<Animator>().SetBool("Insert", true);
                NewFuseAdded = true;
                wire.enabled = true;
            }
        }
    }

    public void TurnOnMicrowave(bool Status)
    {
        if (Status)
        {
            Invoke("MicrowaveStart", 2f);
        }
        else
        {
            MicrowaveLight.SetActive(false);
        }
    }
    void MicrowaveStart()
    {
        MicrowaveLight.SetActive(true);
    }
}
