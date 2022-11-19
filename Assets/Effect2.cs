using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Feedbacks;
public class Effect2 : MonoBehaviour
{
    Transform player;
    public GameObject effectBomb;
    [SerializeField] private MMF_Player mmFeedbacks;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }
    private void Update()
    {
        transform.position = player.position;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Instantiate(effectBomb, transform.position, Quaternion.identity);
            //mmFeedbacks.PlayFeedbacks();
        }
    }


    
}
