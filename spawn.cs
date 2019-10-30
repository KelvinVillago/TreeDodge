using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    int randEnemy;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(WaitSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("r"))
            spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }
    IEnumerator WaitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        while (!stop)
        {
            randEnemy = Random.Range(0, enemies.Length);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1f, Random.Range(-spawnValues.z, spawnValues.z));
            Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(spawnWait);

        }

    }
}
