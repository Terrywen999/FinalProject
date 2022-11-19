using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FirePath : MonoBehaviour
{
    public Queue<Vector3> positions = new Queue<Vector3>();

    public Queue<Vector2> colliderPos = new Queue<Vector2>();

    int buffer = 10;

    public EdgeCollider2D edge;

    float timeBuffer = 0.1f;
    float currentTime = 0;

    public void AddPosition(Vector3 position)
    {
        positions.Enqueue(position);
        if(currentTime < 0)
        {
            currentTime = timeBuffer;
            colliderPos.Enqueue(position);
        }
        
    }

    private void FixedUpdate()
    {
        currentTime -= Time.deltaTime;

        if(positions.Count > 0)
        {
            transform.position = positions.Dequeue();
        }

        if(colliderPos.Count > buffer)
        {
            colliderPos.Dequeue();
        }
        edge.SetPoints(colliderPos.ToList());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("brun");
            Destroy(collision.gameObject);
        }
    }
}
