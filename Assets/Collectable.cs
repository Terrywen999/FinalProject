using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Feedbacks;

[System.Serializable]
public class ItemCollection
{
    public GameObject item;
    public int id;
}

public class Collectable : MonoBehaviour
{
    public ItemCollection[] allItems;
    public Transform player;
    [SerializeField] private MMFeedbacks MMFeedbacks;
    [SerializeField] private MMF_Player mmFeedbacks_TimeScale;
    [SerializeField] private MMF_Player mmFeedbacks_Effect7;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        MMFeedbacks = GameObject.Find("Shake").GetComponent<MMF_Player>();
        mmFeedbacks_TimeScale = GameObject.Find("MMF_FeedBack_FreezeTime").GetComponent<MMF_Player>();


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (ItemCollection i in allItems)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                if (i.id == 1)
                {
                    Instantiate(i.item, player.position, Quaternion.identity);
                    MMFeedbacks.PlayFeedbacks();
                    mmFeedbacks_TimeScale.PlayFeedbacks();
                    Destroy(gameObject);
                    
                }
                if (i.id == 2)
                {
                    Instantiate(i.item, player.position, Quaternion.identity);
                    Destroy(gameObject);
                }
                if (i.id == 3)
                {
                    Instantiate(i.item, player.position, Quaternion.identity);
                    Destroy(gameObject);
                }
                if(i.id == 4)
                {
                    Instantiate(i.item, player.position, Quaternion.identity);
                    Destroy(gameObject);
                }
                if (i.id == 5)
                {
                    Instantiate(i.item, player.position, Quaternion.identity);
                    Destroy(gameObject);
                }
                if (i.id == 6)
                {
                    Instantiate(i.item, player.position, Quaternion.identity);
                    Destroy(gameObject);
                }
                if (i.id == 7)
                {
                    Instantiate(i.item, player.position, player.rotation);
                    Destroy(gameObject);
                }
            }
        }

    }
}
