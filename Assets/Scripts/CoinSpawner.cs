using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnInterval = 1.5f;

    void Start()
    {
        if (coinPrefab == null)
        {
            Debug.LogError("Coin Prefab is NOT assigned!");
            return;
        }

        InvokeRepeating(nameof(SpawnCoin), 1f, spawnInterval);
    }

    void SpawnCoin()
    {
        if (coinPrefab == null)
        {
            Debug.LogError("Coin Prefab is missing!");
            return;
        }

        float randomX = Random.Range(-8f, 8f);

        Vector3 position = new Vector3(randomX, 5f, 0f);

        Instantiate(coinPrefab, position, Quaternion.identity);
    }
}
