using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHit : MonoBehaviour
{

    private int counter = 0;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
        if (!collision.transform.CompareTag("Club"))
        {
            return;
        }

        Debug.Log("Moving ball");
        ++counter;
        var direction = (transform.position - collision.transform.position).normalized;

        if (collision.transform.TryGetComponent<Rigidbody>(out var clubRb))
        {
            float dynamicForce = clubRb.velocity.magnitude * 1.33f;
            transform.GetComponent<Rigidbody>().AddForce(direction * dynamicForce, ForceMode.Impulse);
        }
    }

    private void Update()
    {
        
    }
}
