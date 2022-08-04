using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPuddle : MonoBehaviour
{
    [SerializeField]
    AudioSource audioS;

    [SerializeField]
    AudioClip waterCleanSound;

    [SerializeField]
    int RemainingWater = 3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cleaner")
        {
            audioS.PlayOneShot(waterCleanSound);
            RemainingWater--;
            if (RemainingWater == 0)
            {
                gameObject.SetActive(false);
            }

        }
    }
}
