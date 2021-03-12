using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kullaniciİstatistigi : MonoBehaviour
{
    //List<int> list = new List<int>();
    public static int highScoreValue = 0;
    public Text highScore;
    //public Text time;
    //public Text antsKilled;

    // Start is called before the first frame update
    void Start()
    {
        //list.Add(KapaAc.skor);
    }

    // Update is called once per frame
    void Update()
    {    
        highScore.text = "High Score: " + PlayerPrefs.GetInt("High Score");      
    }
}
