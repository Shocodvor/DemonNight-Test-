
using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

namespace TestTusk
{


    public class Spawner : MonoBehaviour
    {

        private EnemySpawn _enemySpawn;
        [SerializeField] float spawntime;




        void Start()
        {
           
            StartCoroutine(SpawnEnemy());

            StartCoroutine(spawntimeDicrese());

            spawntime = 2f;
        }

        IEnumerator SpawnEnemy()

        {

            yield return new WaitForSeconds(spawntime);

            EnemySpawn enemySpawn = new EnemySpawn();

            _enemySpawn = enemySpawn;

            Spawn(_enemySpawn._emptyPrefab);

            StartCoroutine(SpawnEnemy());

        }

        IEnumerator spawntimeDicrese()

        {
            yield return new WaitForSeconds(10f);

            if (spawntime > 0.5f)
            {
                spawntime -= 0.1f;
                StartCoroutine(spawntimeDicrese());

            }
        }


        public void Spawn(GameObject _prefab) {

            Instantiate(_prefab, new Vector2(Random.Range(0, 50), Random.Range(0, 100)), Quaternion.identity);
        }


    }

}
