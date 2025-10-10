using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Text playerScoreText;
    public Text computerScoreText;
    private int _playerscore;
    private int _computerscore;

    public void PlayerScore()
    {
        _playerscore++;
        this.playerScoreText.text = _playerscore.ToString();
        Debug.Log(_playerscore);
        this.ball.ResetPosition();       
    }

    public void ComputerScore()
    {
        _computerscore++;
        this.computerScoreText.text = _computerscore.ToString();
        Debug.Log(_computerscore);
        this.ball.ResetPosition();
    }
    
    
}
