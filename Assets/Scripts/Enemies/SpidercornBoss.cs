using UnityEngine;

public class SpidercornBoss : MonoBehaviour
{
    [SerializeField] private int maxHitPoints = 4;
    [SerializeField] private int currentHitPoints;

    [SerializeField] private Wiggle wiggle;
    [SerializeField] private GameObject[] makeObjectAppearWhenDead;

    private void Start()
    {
        currentHitPoints = maxHitPoints;
    }

    public void TakeDamage()
    {
        currentHitPoints--;
        if (currentHitPoints == 0)
        {
            foreach (var objectToAppear in makeObjectAppearWhenDead)
            {
                objectToAppear.SetActive(true);
            }
            
            Destroy(gameObject);
            return;
        }

        var transform1 = transform;
        var localScale = transform1.localScale;
        transform1.localScale = new Vector3(localScale.x * 0.75f, localScale.y * 0.75f, 1f);

        wiggle.MaxSecondsWiggle = wiggle.MaxSecondsWiggle * 0.5f;
    }
}