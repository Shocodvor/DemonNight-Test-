using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentScore : MonoBehaviour
{

     public static int _currentScore;
    [SerializeField] private TextMeshProUGUI NowScore;
    [SerializeField] private TextMeshProUGUI TopScore;


    private void Update()
    {



        NowScore.text = _currentScore.ToString();
        TopScore.text = PlayerPrefs.GetInt("TopScore").ToString(); 

        if (PlayerPrefs.GetInt("Score") < _currentScore)
        {
            PlayerPrefs.SetInt("Score", _currentScore);
            PlayerPrefs.SetInt("TopScore", _currentScore);

        }

    }

}
