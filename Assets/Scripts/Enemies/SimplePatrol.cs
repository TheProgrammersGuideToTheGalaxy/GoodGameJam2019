using UnityEngine;

public class SimplePatrol : MonoBehaviour
{
    [SerializeField] private float maxSecondsPatrol = 3f;
    [SerializeField] private float speed = 2f;
    [SerializeField] private float currentSecondsPatrol;
    [SerializeField] private bool positiveSpeedIsFlipped = true;

    [SerializeField] private SpriteRenderer ownSpriteRenderer; 
    private bool isOwnSpriteRendererNotNull;

    private void Start()
    {
        isOwnSpriteRendererNotNull = ownSpriteRenderer != null;
        if (speed > 0 && isOwnSpriteRendererNotNull)
        {
            ownSpriteRenderer.flipX = positiveSpeedIsFlipped;
        }
    }

    private void Update()
    {
        float dt = Time.deltaTime;
        currentSecondsPatrol += dt;
        
        if (currentSecondsPatrol > maxSecondsPatrol)
        {
            currentSecondsPatrol = 0;
            speed *= -1;
            if (isOwnSpriteRendererNotNull)
            {
                ownSpriteRenderer.flipX = !ownSpriteRenderer.flipX;
            }
        }
        
        transform.position += new Vector3(speed * dt, 0f, 0f);
    }
}