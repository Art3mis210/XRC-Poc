using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrowaveWire : MonoBehaviour
{
    public bool PluggedIn=true;
    [SerializeField] float CoolDownTime=3;
    float InteractionTime = 0;
    Animator WireAnimator;
    public int stepNumber,stepNumber2;
    public Outline line;

    [SerializeField] ElectricianFuse Fuse;
    private void Start()
    {
        WireAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (InteractionTime > 0)
            InteractionTime -= Time.deltaTime;
    }

    public void PlugWire()
    {
        if(InteractionTime<=0)
        {
            PluggedIn = !PluggedIn;
            if (!PluggedIn)
            {
                GameManager.instance.CheckSteps(stepNumber);
                line.OutlineColor = Color.red;
            }
            WireAnimator.SetBool("PluggedIn", PluggedIn);
            InteractionTime = CoolDownTime;
            if(Fuse.NewFuseAdded)
            {
                Fuse.TurnOnMicrowave(PluggedIn);
                GameManager.instance.CheckSteps(stepNumber2);
            }
            else
            {
                this.enabled = false;
            }
        }
    }


}
