using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject player;
    public GameObject highScoreText;
    public GameObject audioPlayer;
    public GameObject pipeSpawner;
    public GameObject backgroundMusic;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        if (playerScore % 5 == 0)
        {
            pipeSpawner.GetComponent<SpawnController>().increaseDifficulty();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene("GameLoaded");
    }

    public void gameOver()
    {
        player.GetComponent<CharacterController>().birdIsAlive = false;

        backgroundMusic.GetComponent<BackgroundMusicScript>().StopMusic();
        audioPlayer.GetComponent<AudioScript>().Scratch();

        gameOverScreen.SetActive(true);

        int currHighScore = PlayerPrefs.GetInt("HighScore", 0);
        if (playerScore > currHighScore)
        {
            PlayerPrefs.SetInt("HighScore", playerScore);
        }
        highScoreText.GetComponent<Text>().text = math.max(playerScore, currHighScore).ToString();
    }

    public void startGame()
    {
        var op = SceneManager.LoadSceneAsync("GameLoaded");
        op.allowSceneActivation = false;
        op.allowSceneActivation = true;

    }

    public void ding()
    {
        audioPlayer.GetComponent<AudioScript>().Ding();
    }
}
