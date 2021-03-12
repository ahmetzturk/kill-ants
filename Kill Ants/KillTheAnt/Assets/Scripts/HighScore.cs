using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    private Text highScore;
    private int birkezGuncelle = 0;

    // Start is called before the first frame update
    void Start()
    {
        highScore = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (birkezGuncelle == 0)
        {
            highScore.text = "Your High Score is " + PlayerPrefs.GetInt("High Score");
            birkezGuncelle++;
        }
    }
}
