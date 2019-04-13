using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Detector : MonoBehaviour
{
    [SerializeField] private CharacterMovement UpperClass;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!UpperClass)
        {
            return;
        }

        UpperClass.OnCollisionEnter2D(collision);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (!UpperClass)
        {
            return;
        }

        UpperClass.OnCollisionExit2D(collision);
    }
}
