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
    public GameObject scratchSound;
    public GameObject dingSound;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene("GameLoaded");
    }

    public void gameOver()
    {
        player.GetComponent<CharacterController>().birdIsAlive = false;

        GameObject.FindGameObjectWithTag("Music").GetComponent<BackgroundMusicScript>().StopMusic();
        scratchSound.SetActive(true);
        scratchSound.GetComponent<RecordScratchScript>().RecordScratch();

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
        SceneManager.LoadScene("GameLoaded");
    }

    public void ding()
    {
        dingSound.SetActive(true);
        dingSound.GetComponent<DingScript>().Ding();
    }
}
