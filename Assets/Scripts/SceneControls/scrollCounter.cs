using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollCounter : MonoBehaviour
{
    [SerializeField] private GameObject[] scrollsToCollect;
    [SerializeField] private GameObject objectToEnable;

    public void collectScroll(GameObject collectedObject)
    {
        scrollsToCollect = Array.FindAll(scrollsToCollect, (GameObject element) =>
        {
            return element.GetInstanceID() != collectedObject.GetInstanceID();
        });
        if (scrollsToCollect.Length == 0)
        {
            NoScrolls();
        }
    }

    private void NoScrolls()
    {
        objectToEnable.SetActive(true);
    }
}
