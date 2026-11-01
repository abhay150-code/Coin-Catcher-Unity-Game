using UnityEngine;

public class Coin : MonoBehaviour
{
    private bool collected = false;

    void Update()
    {
        if (!collected && transform.position.y < -4.5f)
        {
            collected = true;

            Debug.Log("Coin Missed!");

            if (GameManager.instance != null)
            {
                GameManager.instance.LoseLife();
            }

            Destroy(gameObject);
        }
    }

    public bool TryCollect()
    {
        if (collected)
            return false;

        collected = true;
        return true;
    }
}
