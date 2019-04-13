using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Detector : MonoBehaviour
{
    [SerializeField] private CharacterMovement upperClass;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        upperClass.OnCollisionEnter2D(collision);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        OnCollisionExit2D(collision);
    }
}
