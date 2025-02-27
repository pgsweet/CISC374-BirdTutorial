using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject startScreen;
    public GameObject gameUi;
    public GameObject player;
    public GameObject highScoreText;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByName("GameLoaded").buildIndex);
    }

    public void gameOver()
    {
        player.GetComponent<CharacterController>().birdIsAlive = false;

        gameOverScreen.SetActive(true);

        int currHighScore = PlayerPrefs.GetInt("HighScore", 0);
        if (playerScore > currHighScore)
        {
            PlayerPrefs.SetInt("HighScore", playerScore);
            highScoreText.GetComponent<Text>().text = playerScore.ToString();
        }
    }

    public void startGame()
    {
        Debug.Log(SceneManager.GetSceneByPath("Assets/Scenes/GameLoaded.unity").buildIndex);
        SceneManager.LoadScene(SceneManager.GetSceneByName("GameLoaded").buildIndex);
    }

}
