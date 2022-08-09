using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricianGloves : MonoBehaviour
{
    [SerializeField] string GloveTag;
    [SerializeField] Material GlovesMaterial;
    [SerializeField] int stepNumber;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag==GloveTag)
        {
            GameManager.instance.CheckSteps(stepNumber);
            transform.GetComponent<SkinnedMeshRenderer>().material = GlovesMaterial;
            Destroy(transform.GetComponent<BoxCollider>());
            other.gameObject.SetActive(false);
            this.enabled = false;
        }
    }
}
