using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("PresentScore")]
    public int PreScore = 0;
    [Header("HighestScore")]
    public int HighScore;
    private void Update()
    {
        GameScore();
        if (PreScore >= HighScore)
        {
            HighestScore();
        }
    }
    //修飾詞權限
    //public可使其他腳本使用
    //private則否
    public void GameScore()
    {
        PreScore = Time.deltaTime;
    }
    private void HighestScore()
    {
            HighScore = PreScore;
    }
    private void SpawnPipe()
    {

    }
    public void GameOver()
    {

    }
}
