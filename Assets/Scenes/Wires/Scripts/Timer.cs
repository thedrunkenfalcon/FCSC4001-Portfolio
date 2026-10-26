using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Timer : MonoBehaviour
{
    [SerializeField]
    public TMPro.TextMeshProUGUI timerText;
    
    
    
    private float frames, seconds = 0f;
    public float timeLeft;
    private float dif;



    void Start()
    {
        if (test.mode == 'E' && test.win)
        {
            dif = 0.9f;
        }
        else if (test.mode == 'M' && test.win)
        {
            dif = 0.8f;
        }
        else if (test.mode == 'H' && test.win)
        {
            dif = 0.75f;
        }

        if (test.win)
        {
            test.timer = math.round(test.timer * dif);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft = test.timer - seconds;
        timerText.text = "Timer: " + timeLeft;
        
        frames++;
        
        if (frames == 60)
        {
            seconds++;
            frames = 0f;
        }

        if (timeLeft == 0f)
        {
            test.win = false;
            SceneManager.LoadScene("Assets/Scenes/GameOver/GameOver.unity");
        }
        
    }


}
