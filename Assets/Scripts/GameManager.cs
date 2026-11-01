using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public int lives = 3;

    public TMP_Text scoreText;
    public TMP_Text livesText;

    public GameObject gameOverPanel;

    private bool gameOver = false;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Time.timeScale = 1f;

        UpdateScoreText();
        UpdateLivesText();

        gameOverPanel.SetActive(false);
    }

    public void AddScore(int amount)
    {
        if (gameOver) return;

        score += amount;
        UpdateScoreText();
    }

    public void LoseLife()
    {
        if (gameOver) return;

        lives--;

        UpdateLivesText();

        if (lives <= 0)
        {
            GameOver();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    void UpdateLivesText()
    {
        livesText.text = "Lives: " + lives;
    }

    void GameOver()
    {
        gameOver = true;

        gameOverPanel.SetActive(true);

        Time.timeScale = 0f;

        Debug.Log("GAME OVER!");
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }
}
