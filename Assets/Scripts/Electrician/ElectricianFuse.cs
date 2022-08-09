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


    public void RemoveFuse()
    {
        if(!FuseRemoved)
        {
            FuseRemoved = true;
            BrokenFuseAnimator.SetBool("Remove", true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(FuseRemoved)
        {
            if(other.gameObject.tag=="Fuse")
            {
                other.gameObject.SetActive(false);
                Fuse.SetActive(true);
                Fuse.GetComponent<Animator>().SetBool("Insert", true);
                NewFuseAdded = true;
            }
        }
    }

    public void TurnOnMicrowave(bool Status)
    {
        MicrowaveLight.SetActive(Status);
    }
}
