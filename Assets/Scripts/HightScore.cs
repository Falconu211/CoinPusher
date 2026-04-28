using TMPro;
using UnityEngine;

public class HightScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI firstScoreText;
    [SerializeField] TextMeshProUGUI secondScoreText;
    [SerializeField] TextMeshProUGUI thirdScoreText;

    public static int firstScore;
    public static int secondScore;
    public static int thirdScore;

    private void Start()
    {
        CountScore(CoinCount.coins);
    }

    public void CountScore(int score)
    {
        string first = "First:";
        string second = "Second:";
        string third = "Third:";
        firstScoreText.text = first + firstScore;
        secondScoreText.text = second + secondScore;
        thirdScoreText.text = third + thirdScore;

        if (score >= firstScore)
        {
            thirdScore = secondScore;
            secondScore = firstScore;
            firstScore = score;
            
            firstScoreText.text = first + score;
            secondScoreText.text = second + secondScore;
            thirdScoreText.text = third + thirdScore;
        }
        else if (score >= secondScore)
        {
            thirdScore = secondScore;
            secondScore = score;
            secondScoreText.text = second + score;
            thirdScoreText.text = third + thirdScore;
        }
        else if(score >= thirdScore)
        {
            thirdScore = score;
            thirdScoreText.text = third + score;
        }
    }
}
