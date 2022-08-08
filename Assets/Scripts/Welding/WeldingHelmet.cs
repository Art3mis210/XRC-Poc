using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction.HandPosing;

public class WeldingHelmet : MonoBehaviour
{
    [SerializeField] Transform PlayerCamera;
    bool HelmetPicked;
    HandGrabInteractable handGrab;
    private void Start()
    {
        handGrab = GetComponent<HandGrabInteractable>();
    }

    public void HelmetPick(bool Status)
    {
        if(!Status)
        {
            if(handGrab.InteractorsCount == 0)
                HelmetPicked = Status;
        }
        else
            HelmetPicked = Status;

    }
    private void Update()
    {
        if(HelmetPicked)
        {
       
            Debug.Log(Vector3.Distance(transform.position, PlayerCamera.position));
            if (Vector3.Distance(transform.position, PlayerCamera.position) < 0.2f)
                transform.gameObject.SetActive(false);
        }
    }
}
