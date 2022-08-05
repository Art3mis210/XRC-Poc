using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrowaveWire : MonoBehaviour
{
    public bool PluggedIn=true;
    [SerializeField] float CoolDownTime=3;
    float InteractionTime = 0;
    Animator WireAnimator;
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
            WireAnimator.SetBool("PluggedIn", PluggedIn);
            InteractionTime = CoolDownTime;
        }
    }


}
