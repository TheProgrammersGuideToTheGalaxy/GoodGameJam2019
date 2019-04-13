using Gamekit2D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvicibilityBlinker : MonoBehaviour
{
    [SerializeField] private int blinkFrequency;

    private bool isBlinking = false;
    private float blinkingTime;
    private float blinkAmount;
    private float halfBlinkDuration;
    private int lastBlink;

    // Update is called once per frame
    void Update()
    {
        if(isBlinking && blinkAmount < blinkingTime)
        {
            blinkAmount += Time.deltaTime;
            SpriteRenderer renderer = GetComponent<SpriteRenderer>();
            if (blinkAmount >= blinkingTime)
            {
                renderer.color = Color.white;
            } else
            {
                int currentBlink = Mathf.FloorToInt(blinkAmount / halfBlinkDuration);
                if(currentBlink != lastBlink)
                {
                    if(renderer.color == Color.white)
                    {
                        renderer.color = new Color(1f,1f,1f,0.5f);
                    }
                    else
                    {
                        renderer.color = Color.white;
                    }
                    lastBlink = currentBlink;
                }
            }
        }
    }

    public void StartBlinking(Damageable damage)
    {
        isBlinking = true;
        blinkingTime = damage.invulnerabilityDuration;
        blinkAmount = 0;
        lastBlink = -1;
        halfBlinkDuration = (float)1 / (blinkFrequency * 2);
        Debug.Log(halfBlinkDuration);
    }
}
