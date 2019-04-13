using UnityEngine;

namespace Enemies
{
    public class BombonSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject[] spawnRandomThing;
        [SerializeField] private float spawnEverySeconds = 1;
        [SerializeField] private float spawnChance = 0.7f;

        [SerializeField] private float timeToSpawn;

        private void Start()
        {
            timeToSpawn = spawnEverySeconds;
        }

        private void Update()
        {
            var dt = Time.deltaTime;
            timeToSpawn -= dt;

            if (timeToSpawn < 0f)
            {
                timeToSpawn = spawnEverySeconds;
                if (Random.value < spawnChance)
                {
                    var randomRange = Random.Range(0, spawnRandomThing.Length);
                    var instantiate = Instantiate(spawnRandomThing[randomRange]);
                    instantiate.transform.position = transform.position;
                }
            }
        }
    }
}