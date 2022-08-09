using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] int stepNumber;
    [SerializeField] GameObject on;
    public Outline line;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Lever"))
        {
            GameManager.instance.CheckSteps(stepNumber);
            gameObject.SetActive(false);
            on.SetActive(true);
            line.OutlineColor = Color.red;
        }
    }
}
