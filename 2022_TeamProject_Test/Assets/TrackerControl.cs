using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerControl : MonoBehaviour
{
    Rigidbody2D rb;
    Transform target;

    [Header("Chase Speed")]
    [SerializeField] [Range(1f, 4f)] float moveSpeed = 3f;

    [Header("Nearing Distance")]
    [SerializeField] [Range(0f, 3f)] float contactDistance = 2f;

    bool follow = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        FollowTarget();
    }

    void FollowTarget()
    {
        if ((Vector2.Distance(transform.position, target.position) > contactDistance) && follow)
            transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        else
            rb.velocity = Vector2.zero;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        follow = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        follow = false;
    }

}
