using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeldingHelmet : MonoBehaviour
{
    [SerializeField] Transform PlayerCamera;
    public void HelmetPicked()
    {
        if(Vector3.Distance(transform.position,PlayerCamera.position)<0.5f)
            transform.gameObject.SetActive(false);
    }
}
