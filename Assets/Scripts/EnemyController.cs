﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public Transform target;

    // Use this for initialization
    void Start()
    {
        //StartCoroutine(WaitTime(2));
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(target.position);
        //transform.Rotate(new Vector3(0, -90, 0), Space.Self);

        if (Vector3.Distance(transform.position, target.position) > 1f)
        {
            Vector3 pcDirection = (target.position - transform.position).normalized;
            transform.Translate(pcDirection * speed * Time.deltaTime);
            transform.SetZ(-.1f);
        }

        if (Vector3.Distance(transform.position, target.position) == 0f)
        {
            speed -= 2f;
            StartCoroutine(WaitTime(1));
            speed += 2f;
        }
    }

    IEnumerator WaitTime(int timer)
    {
        yield return new WaitForSeconds(timer);
    }
}