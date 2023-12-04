using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartaTocada : MonoBehaviour
{
    public PJ pj; // Creates a public reference to a PJ object.

    void OnMouseDown()
    {
        if (pj != null)
        {
            Debug.Log(pj.id);
        }
    }
}