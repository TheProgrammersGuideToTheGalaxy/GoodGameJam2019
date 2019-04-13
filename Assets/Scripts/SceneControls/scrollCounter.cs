using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollCounter : MonoBehaviour
{
    [SerializeField] private GameObject[] scrollsToCollect;

    public void collectScroll(GameObject collectedObject)
    {
        scrollsToCollect = Array.FindAll(scrollsToCollect, (GameObject element) => 
        {
            return element.GetInstanceID() != collectedObject.GetInstanceID();
        });
    }
}
