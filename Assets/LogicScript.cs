using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text textScore;
    public GameObject GameOverScreen;

    [ContextMenu("Increase Score")] 
    public void addScore(int scoreToadd)
    {
        playerScore += scoreToadd;
        textScore.text = playerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
