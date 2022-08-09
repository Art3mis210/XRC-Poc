using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] int stepNumber;
    [SerializeField] GameObject on;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Lever"))
        {
            GameManager.instance.CheckBool(stepNumber);
            GameManager.instance.CheckSteps(stepNumber);
            Destroy(transform.GetComponent<BoxCollider>());
            gameObject.SetActive(false);
            if(stepNumber == 1)
            on.SetActive(true);
            this.enabled = false;
        }
    }
}
