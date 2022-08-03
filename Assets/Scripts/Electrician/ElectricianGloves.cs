using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricianGloves : MonoBehaviour
{
    [SerializeField] Material GlovesMaterial;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Gloves")
        {
            transform.GetComponent<SkinnedMeshRenderer>().material = GlovesMaterial;
            Destroy(transform.GetComponent<BoxCollider>());
            this.enabled = false;
        }
    }
}
