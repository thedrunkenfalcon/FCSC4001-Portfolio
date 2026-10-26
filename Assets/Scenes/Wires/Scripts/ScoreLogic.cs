using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ScoreLogic : MonoBehaviour
{
    [SerializeField]
    public TMPro.TextMeshProUGUI scoreText;
    public float score = 0f;


    void Start()
    {
        score = test.curScore;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    public void SetScore(float pAdd)
    {
        score += pAdd;
    }

    public float GetScore()
    {
        return score;
    }
}
