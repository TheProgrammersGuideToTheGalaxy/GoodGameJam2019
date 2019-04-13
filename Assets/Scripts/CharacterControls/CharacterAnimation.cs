using System;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    [SerializeField]
    private float horizontalSpeed;
    
    [SerializeField]
    private float verticalSpeed;
    
    [SerializeField]
    private Animator currentAnimator;

    private static readonly int HorizontalSpeedParam = Animator.StringToHash("HorizontalSpeed");
    private static readonly int VerticalSpeedParam = Animator.StringToHash("VerticalSpeed");
    private static readonly int GroundedParam = Animator.StringToHash("Grounded");
    private static readonly int IsDoubleJumpingParam = Animator.StringToHash("isDoubleJumping");

    public float HorizontalSpeed
    {
        get { return horizontalSpeed; }
        set
        {
            if (Math.Abs(horizontalSpeed - value) > float.Epsilon)
            {
                horizontalSpeed = value;
                if (currentAnimator != null)
                {
                    currentAnimator.SetFloat(HorizontalSpeedParam, Math.Abs(horizontalSpeed));
                }
            }
            
        }
    }
    
    public float VerticalSpeed
    {
        get { return verticalSpeed; }
        set
        {
            if (Math.Abs(verticalSpeed - value) > float.Epsilon)
            {
                verticalSpeed = value;
                if (currentAnimator != null)
                {
                    currentAnimator.SetFloat(VerticalSpeedParam, Math.Abs(verticalSpeed));
                }
            }
            
        }
    }

    public bool Grounded
    {
        set
        {
            if (currentAnimator != null)
            {
                currentAnimator.SetBool(GroundedParam, value);
            }
        }
    }

    public bool IsDoubleJumping
    {
        set
        {
            if (currentAnimator != null)
            {
                currentAnimator.SetBool(IsDoubleJumpingParam, value);
            }
        }
    }
}
