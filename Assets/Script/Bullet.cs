using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    Transform enemy;
    Rigidbody rb;
    [SerializeField] float speed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        enemy = EnemyPooler.instance.enemy[0].transform;
    }
    private void Start()
    {
        rb.velocity = enemy.transform.position*speed*Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
    }
}
