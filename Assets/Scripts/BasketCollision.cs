using UnityEngine;

public class BasketCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            Debug.Log("Coin Caught!");

            GameManager.instance.AddScore(1);

            Destroy(other.gameObject);
        }
    }
}
