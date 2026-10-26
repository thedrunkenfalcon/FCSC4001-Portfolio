using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> rightWires;

    [SerializeField]
    public List<GameObject> leftWires;

    [SerializeField]
    private List<Wire> leftywires;

    [SerializeField]
    private List<Wire> rightywires;

    [SerializeField]
    public ScoreLogic scoreLogic;


    void Awake()
    {
        ShuffleWires();
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 60;
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        int connectedLeftWires = 0;
        //int connectedRightWires = 0;
        
        foreach(Wire w in leftywires)
        {
            if (w.IsConnected())
            {
                connectedLeftWires++;
                //scoreLogic.SetScore(scoreLogic.GetScore() + 10);
            }
        }

        foreach (Wire w in rightywires)
        {
            if (w.IsConnected())
            {
                connectedLeftWires++;
                //scoreLogic.SetScore(5);
            }
        }



        if (connectedLeftWires == leftywires.Count)
        {
            
            test.win = true;
            test.curScore = scoreLogic.score;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }

    void ShuffleLeftWires()
    {
        List<Vector3> wirePos = new List<Vector3>();

        foreach(GameObject w in leftWires)
        {
            Vector3 pos = w.transform.position;
            wirePos.Add(pos);
        }
        foreach(GameObject w in leftWires)
        {
            int randind1 = Random.Range(0, wirePos.Count);
            w.transform.position = wirePos[randind1];
            wirePos.RemoveAt(randind1);
        }
    }

    void ShuffleRightWires()
    {
        List<Vector3> wirePos2 = new List<Vector3>();

        foreach(GameObject w in rightWires)
        {
            Vector3 pos = w.transform.position;
            wirePos2.Add(pos);
        }
        foreach(GameObject w in rightWires)
        {
            int randind = Random.Range(0, wirePos2.Count);
            w.transform.position = wirePos2[randind];
            wirePos2.RemoveAt(randind);
        }
    }

    void ShuffleWires()
    {
        ShuffleLeftWires();
        ShuffleRightWires();
    }

}
