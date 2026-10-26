using UnityEngine;
using UnityEngine.SceneManagement;

public class Shaniqua : MonoBehaviour
{
    
    [SerializeField]
    public float timey = 10f;
    [SerializeField]
    public string blurple;
    [SerializeField]
    private char _Mode;
    [SerializeField]
    private bool _ScoreReset;
    


    void Start()
    {
        if (_ScoreReset)
        {
            test.curScore = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(blurple);
        test.timer = timey;
        test.mode = _Mode;

    }

   
}
