using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxActions : MonoBehaviour, IDamageable
{

    private string estatActual; 
    private Vector3 posActual; 
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
            transform.localPosition = posActual;

        }
        else
        {
            posActual = transform.localPosition;
            if (costat == "OEST")
            {
                float newPos = transform.localPosition.x - (float)0.5;
                transform.localPosition = new Vector3(newPos, transform.localPosition.y, transform.localPosition.z);
                transform.localScale = new Vector3(2, 1, 1);
            }
            else if (costat == "EST")
            {
                float newPos = transform.localPosition.x + (float)0.5;
               transform.localPosition = new Vector3(newPos, transform.localPosition.y, transform.localPosition.z);
                transform.localScale = new Vector3(2, 1, 1);
            }
            else if (costat == "SUD")
            {
                float newPos = transform.localPosition.z - (float)0.5;
                transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, newPos);
                transform.localScale = new Vector3(1, 1, 2);
            }
            else if (costat == "NORD")
            {
                float newPos = transform.localPosition.z + (float)0.5;
                transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, newPos);
                transform.localScale = new Vector3(1, 1, 2);
            }
            else if (costat == "AMUNT")
            {
                float newPos = transform.localPosition.y - (float)0.5;
                transform.localPosition = new Vector3(transform.localPosition.x, newPos, transform.localPosition.z);
                transform.localScale = new Vector3(1, 2, 1);
            }
            else if (costat == "ABAIX")
            {
                float newPos = transform.localPosition.y + (float)0.5;
                transform.localPosition = new Vector3(transform.localPosition.x, newPos, transform.localPosition.z);
                transform.localScale = new Vector3(1, 2, 1);
            }
            estatActual = "augmentarMida";
            rend.sharedMaterial = material[1];
        }
    }
}
