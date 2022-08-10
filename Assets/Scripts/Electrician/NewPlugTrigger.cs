using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlugTrigger : MonoBehaviour
{
    [SerializeField] TVPlug tvPlug;
    [SerializeField] int stepNumber;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="NewPlug")
        {
            tvPlug.NewPlugAdded();
            other.gameObject.SetActive(false);
            transform.gameObject.SetActive(false);
            GameManager.instance.CheckSteps(stepNumber);
        }
    }
}
