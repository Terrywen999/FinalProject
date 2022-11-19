using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Feedbacks;

public class Effect1 : MonoBehaviour
{
    //[SerializeField] private MMF_Player mmFeedbacks;
    //[SerializeField] private MMF_Player mmFeedbacks_TimeScale;
    private void Start()
    {
        //mmFeedbacks = GameObject.Find("Shake").GetComponent<MMF_Player>();
        //mmFeedbacks_TimeScale = GameObject.Find("MMF_FeedBack_FreezeTime").GetComponent<MMF_Player>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Debug.Log("KillPlayer");
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(DestroyEffect());       
        }
    }

    IEnumerator DestroyEffect()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
