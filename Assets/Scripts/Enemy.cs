using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{

    bool isAttracting;
    Vector3 targetPos;
    public bool isDie;
    

    private void Start()
    {
        isDie = false;
    }
    private void Update()
    {
        if(isAttracting)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * 10);
        }
        
    }

    public void StartAttracting(Transform transform)
    {
        isAttracting = true;
        targetPos = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            isDie = true;
        }
        
    }


    private void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject);
    }



}
