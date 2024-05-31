using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPooler : MonoBehaviour
{

    [SerializeField] public List<GameObject> enemy=new List<GameObject>();
    public static EnemyPooler instance;
    public Transform target;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        for (int i = 0; i < enemy.Count; i++)
        {
            Instantiate(enemy[i], this.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
    }
}
