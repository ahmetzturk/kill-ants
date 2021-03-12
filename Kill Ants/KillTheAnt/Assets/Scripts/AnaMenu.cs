using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenu : MonoBehaviour
{
    //private KapaAc kapaAcScripti;

    void Start()
    {
        //kapaAcScripti = GameObject.Find("Kullanılmayan Karınca").GetComponent<KapaAc>();
    }

    public void PlayGame()
    {
        KapaAc.skor = 0;
        KarincaYarat.birimYaratimSikligi = 50;
        RotasalHareket.hiz = 0.15f;
        SceneManager.LoadSceneAsync("MainMenu");
        
    }

    public void ShowTheStatistics()
    {
        KapaAc.skor = 0;
        KarincaYarat.birimYaratimSikligi = 50;
        RotasalHareket.hiz = 0.15f;
        SceneManager.LoadSceneAsync("UserStatistics");
    }

    public void RestartGame()
    {
        KapaAc.skor = 0;
        KarincaYarat.birimYaratimSikligi = 50;
        RotasalHareket.hiz = 0.15f;
        SceneManager.LoadSceneAsync("SampleScene");

    }


}
