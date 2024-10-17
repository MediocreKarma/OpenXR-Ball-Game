using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball")) 
        {
            FindObjectOfType<ScoreManager>().IncrementScore(); 

            Debug.Log("Score incremented");

            //resetam pozitia mingii:
        }
    }
}
