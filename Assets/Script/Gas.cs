using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : MonoBehaviour
{
    void Update()
    {
        if (gameObject == null)
        {
            gameObject.SetActive(true);
        }
        transform.position += Vector3.down * Time.deltaTime * 2f;
        if (transform.position.y < -5.25f)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        gameObject.SetActive(false);
    }
}
