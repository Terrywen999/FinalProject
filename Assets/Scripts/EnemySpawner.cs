using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject enemy1;
    [SerializeField]
    private float enemy1Interval =0.1f;
    [SerializeField]
    private GameObject enemyWave;
    [SerializeField]
    private float Wave1Interva = 5f;
    [SerializeField]
    private GameObject enemyWave2;
    [SerializeField]
    private GameObject enemyWave3;
    [SerializeField]
    private GameObject enemyWave4;
    [SerializeField]
    private GameObject enemyWave5;
    [SerializeField]
    private GameObject enemyWave6;
    [SerializeField]
    private GameObject enemyWave7;
    float time;
    TimeCount timeCount;
    void Start()
    {
        StartCoroutine(spawnEnemy(enemy1Interval, enemy1));
        StartCoroutine(spawnEnemyWave(Random.Range(7f,10f), enemyWave));
        StartCoroutine(spawnEnemyWave(Random.Range(7f, 10f), enemyWave2));
        StartCoroutine(spawnEnemyWave(Random.Range(7f, 10f), enemyWave3));
        StartCoroutine(spawnEnemyWave(Random.Range(7f, 10f), enemyWave4));
        StartCoroutine(spawnEnemyWave(Random.Range(7f, 10f), enemyWave5));
        StartCoroutine(spawnEnemyWave(Random.Range(7f, 10f), enemyWave6));
        StartCoroutine(spawnEnemyWave(Random.Range(7f, 10f), enemyWave7));
    }
    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5),
            Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(DestroyEnemy(enemy));
        StartCoroutine(spawnEnemy(enemy1Interval, enemy1));
    }

    private IEnumerator spawnEnemyWave(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5),
            Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(DestroyEnemy(enemy));
        StartCoroutine(spawnEnemyWave(Random.Range(7f, 10f), enemy));
    }

    IEnumerator DestroyEnemy(GameObject enemy)
    {
        yield return new WaitForSeconds(3f);
        Destroy(enemy);
    }
}
