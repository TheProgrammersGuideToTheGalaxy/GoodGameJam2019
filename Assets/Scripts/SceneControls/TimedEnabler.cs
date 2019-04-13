using UnityEngine;

public class TimedEnabler : MonoBehaviour
{
    [SerializeField] private float enableAfterSeconds = 2f;
    [SerializeField] private GameObject objectToEnable;

    private void Update()
    {
        var dt = Time.deltaTime;
        enableAfterSeconds -= dt;

        if (enableAfterSeconds < 0)
        {
            objectToEnable.SetActive(true);
            Destroy(gameObject);
        }
    }
}