using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect6 : MonoBehaviour
{
    Transform path;
    

    private void Start()
    {
        path = GameObject.FindWithTag("Path").GetComponent<Transform>();
        StartCoroutine(DestroyEffect());
    }

    private void Update()
    {
        transform.position = path.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("brun");
            Destroy(collision.gameObject);
        }
           
    }

    IEnumerator DestroyEffect()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
