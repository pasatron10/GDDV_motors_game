using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxActions : MonoBehaviour, IDamageable
{

    private string estatActual; 
    public Material[] material;
    Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    public void AccioCaixa(int accio, string costat)
    {
        switch (accio)
        {
            case 0:
                augmentarMida(costat);
                break;

        }
    }

    public void augmentarMida(string costat)
    {
        if (estatActual == "augmentarMida")
        {
            transform.localScale = new Vector3(1, 1, 1);
            estatActual = "normal";
            rend.sharedMaterial = material[0];

        }
        else
        {
            if (costat == "OEST" || costat == "EST")
            {
                transform.localScale = new Vector3(2, 1, 1);
            }
            else if (costat == "AMUNT" || costat == "ABAIX")
            {
                transform.localScale = new Vector3(1, 2, 1);
            }
            else if (costat == "SUD" || costat == "NORD")
            {
                transform.localScale = new Vector3(1, 1, 2);
            }
            estatActual = "augmentarMida";
            rend.sharedMaterial = material[1];
        }
    }
}
