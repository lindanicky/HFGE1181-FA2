using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int value = 10;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<ScoreManager>().AddScore(value);

            Destroy(gameObject);
        }
    }
    
    
}
