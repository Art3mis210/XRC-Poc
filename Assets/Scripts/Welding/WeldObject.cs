using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeldObject : MonoBehaviour
{
    [SerializeField] Vector3 StartPos;
    [SerializeField] Vector3 EndPos;
    [SerializeField] float LerpValue = 1;
    [SerializeField] GameObject WeldLine;


    // Update is called once per frame
    void Start()
    {
        StartPos = transform.localPosition;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="WeldingTorch" && WeldingTorch.weldingTorch.WeldingMode)
        {
            LerpValue -= 0.1f*Time.deltaTime;
            if (LerpValue >= 0)
            {
                Lerp();
            }
            else
            {
                if(WeldLine!=null)
                    WeldLine.SetActive(true);
                this.enabled = false;
            }
        }
    }
    void Lerp()
    {
        transform.localPosition = StartPos * LerpValue + EndPos*(1 - LerpValue);
    }

}
