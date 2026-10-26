using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using System;
using UnityEditor;

public class LeaderBoard : MonoBehaviour
{
    [SerializeField]
    public TMPro.TextMeshProUGUI _lB;
    [SerializeField]
    public TMPro.TextMeshProUGUI _inText;
    [SerializeField]
    public TMP_InputField tMP;
    [SerializeField]
    public string _FileName;

    private string filepath;
    private int currentlineIndex = 0;
    private List<string> scores;
    

    void Start()
    {
        filepath = Application.dataPath + "/Scenes/GameOver/Scripts/";
        ReadFromFile();
        
    }

    
    void Update()
    {
        //PrintToCon();
    }   

    //Function to write to a file to save scoreboards
    public void WriteToFile()
    {
        while (tMP.text.Length < 10)
        {
            tMP.text += " ";
        }
        if (test.mode == 'E')
        {
            File.AppendAllText(filepath + "EasyLboard.txt", "N: " + tMP.text + " S: " + test.curScore + "<br>");
        }
        else if (test.mode == 'M')
        {
            File.WriteAllText(filepath + "MediumLboard.txt", "N: " + tMP.text + " S: " + test.curScore);
        }
        else
        {
            File.WriteAllText(filepath + "HardLboard.txt", "N: " + tMP.text + " S: " + test.curScore);
        }
    }

    public void ReadFromFile()
    {
        _lB.text = File.ReadAllText(filepath + _FileName + ".txt");
        
    }


    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    void OnEnable()
    {
        //_lB.text = "Big shooters are fine";
    }

    
}

