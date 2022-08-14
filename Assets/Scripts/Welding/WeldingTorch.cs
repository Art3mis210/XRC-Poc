using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction.HandPosing;
    
public class WeldingTorch : MonoBehaviour
{
    bool Picked;
    bool ObjectInFront;

    public bool WeldingMode;
    public int stepNumber;
    public Outline line;
    bool firstTimePicked;

    [SerializeField] ParticleSystem Flame;
    [SerializeField] ParticleSystem Spark;

    public static WeldingTorch weldingTorch
    {
        get;
        set;
    }
    private void Awake()
    {
        weldingTorch = this;
    }
    void Start()
    {
        Picked = false;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Picked)
        {
            
            if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger) || OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            {
                WeldingMode = true;
                if(ObjectInFront)
                {
                    if (Flame.isPlaying)
                        Flame.Stop();
                    if (!Spark.isPlaying)
                        Spark.Play();
                }
                else
                {
                    if (!Flame.isPlaying)
                        Flame.Play();
                    if (Spark.isPlaying)
                        Spark.Stop();
                }
            }
            else
            {
                WeldingMode = false;
                Flame.Stop();
                Spark.Stop();
            }
        }
        else
        {
            WeldingMode = false;
            Flame.Stop();
            Spark.Stop();
        }
    }
    public void PickTorch(bool Status)
    {
        Debug.Log("Torch Picked" + Status);
        Picked = Status;
      
        if (Status)
        {
            if(!firstTimePicked)
            {
                firstTimePicked = true;
                GameManager.instance.CheckSteps(stepNumber);
                line.enabled = false;
            }

        }
    }

    public void ObjectInTrigger(bool Status)
    {
        ObjectInFront = Status;
    }
}
