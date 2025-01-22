using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Random = System.Random;

public class Gas : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.down * Time.deltaTime * 2f;
        
        if (transform.position.y < -5.25f)
        {
            UniTask.Delay(1000);
            gameObject.transform.position = new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), 5.3f);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        UniTask.Delay(1000);
        gameObject.transform.position = new Vector2(UnityEngine.Random.Range(-2.5f, 2.5f), 5.3f);
    }
}
