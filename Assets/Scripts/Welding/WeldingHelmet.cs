using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeldingHelmet : MonoBehaviour
{
    public void HelmetPicked()
    {
        //Helmet Picked
        transform.gameObject.SetActive(false);
    }
}
