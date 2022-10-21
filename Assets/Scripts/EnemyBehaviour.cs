using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private Rigidbody enemyRb;
    private GameObject player;

    public float speed = 3f;
    public float yBound = -15f;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Chase();
        if (transform.position.y < yBound)
            Destroy(gameObject);
    }

    void Chase()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(speed * lookDirection);   
    }


}
