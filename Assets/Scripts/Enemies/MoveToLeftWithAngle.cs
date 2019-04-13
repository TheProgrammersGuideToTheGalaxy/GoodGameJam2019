using UnityEngine;

namespace Enemies
{
    public class MoveToLeftWithAngle : MonoBehaviour
    {
        [SerializeField] private Vector2 randomSpeedX = new Vector2(-7, -1);
        [SerializeField] private Vector2 randomSpeedY = new Vector2(-1f, 1f);
        [SerializeField] private float timeToDecay = 10f;

        private float speedX;
        private float speedY;

        private void Start()
        {
            speedX = Random.Range(randomSpeedX.x, randomSpeedX.y);
            speedY = Random.Range(randomSpeedY.x, randomSpeedY.y);
        }

        private void Update()
        {
            var dt = Time.deltaTime;
            
            transform.position += new Vector3(speedX * dt, speedY * dt, 0f);

            timeToDecay -= dt;
            if (timeToDecay < 0f)
            {
                Destroy(gameObject);
            }
        }
    }
}