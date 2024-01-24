using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock_Chase : MonoBehaviour
{
    public GameObject player;
    public float speed;

    private Vector2 direction;
    private float distance;

    void Start()
    {
        
    }

    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
