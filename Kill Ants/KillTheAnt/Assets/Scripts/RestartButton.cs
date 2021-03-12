using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    //private RotasalHareket rotasalHareketScripti;
    //private KapaAc kapaAcScripti;

    void Start()
    {
        //rotasalHareketScripti = GameObject.Find("Kullanılmayan Karınca").GetComponent<RotasalHareket>();
        //kapaAcScripti = GameObject.Find("Kullanılmayan Karınca").GetComponent<KapaAc>();
    }

    public void RestartGame()

    {
        RotasalHareket.barinGucu = 1f;
        KapaAc.skor = 0;
        KarincaYarat.birimYaratimSikligi = 50;
        RotasalHareket.hiz = 0.15f;
        SceneManager.LoadSceneAsync("SampleScene");


    }

}
