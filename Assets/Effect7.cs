using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect7 : MonoBehaviour
{
    Transform player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        StartCoroutine(DestroyEffect());
    }
    private void Update()
    {
        transform.position = player.position;
        transform.rotation = player.rotation;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
    IEnumerator DestroyEffect()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
