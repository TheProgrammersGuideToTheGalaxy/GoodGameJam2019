using UnityEngine;

namespace Enemies
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] private float rotateByDegrees = 90f;

        private void Update()
        {
            var dt = Time.deltaTime;
            transform.Rotate(0, 0, rotateByDegrees * dt);
        }
    }
}