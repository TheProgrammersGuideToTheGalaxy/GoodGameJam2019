using UnityEngine;

public class Wiggle : MonoBehaviour
{
    [SerializeField] private float maxSecondsWiggle = 0.1f;
    [SerializeField] private float secondsWiggle = 0.1f;
    [SerializeField] private float wiggleSpeed = 80f;

    private void Update()
    {
        var dt = Time.deltaTime;
        secondsWiggle += dt;

        if (secondsWiggle > maxSecondsWiggle)
        {
            secondsWiggle = 0f;
            transform.rotation = Quaternion.Euler(0f, 0f, maxSecondsWiggle * wiggleSpeed);
            wiggleSpeed *= -1;
            
        }
            
        transform.Rotate(0f, 0f, wiggleSpeed * dt);
    }
}