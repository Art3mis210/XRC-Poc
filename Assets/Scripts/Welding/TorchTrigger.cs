using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchTrigger : MonoBehaviour
{
    [SerializeField] WeldingTorch torch;
    private void OnTriggerEnter(Collider other)
    {
        torch.ObjectInTrigger(true);
    }
    private void OnTriggerExit(Collider other)
    {
        torch.ObjectInTrigger(false);
    }
}
