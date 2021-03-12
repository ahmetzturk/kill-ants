using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RotasalHareket : MonoBehaviour
{
    // burası bu script birden fazla oyun objesinde bulunsa da sadece 1 kez çalışır (LoadScene çağrılsa bile)
    public static float barinGucu = 1;
    public static float hiz = 0.15f;
    private Vector3 rota;
    public GameObject hedef;
    public Canvas tumBar;
    public Image canBari;
    public Canvas oyunSonu;
    public Text myText;
    public Text skor;
    AudioSource[] sesler;


    // Start is called before the first frame update
    void Start()
    {
        canBari.rectTransform.localScale = new Vector3(barinGucu, 1, 1);
        rota = hedef.transform.position - gameObject.transform.position;
        sesler = GameObject.Find("Ev").GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.Translate(rota * Time.deltaTime * hiz, Space.World);

        if (canBari.rectTransform.localScale.x <= 0f)
        {
            {
                GameObject.Find("Arka Plan 1").GetComponent<AudioSource>().Play();
                Destroy(hedef);
                tumBar.enabled = false;
                DestroySpecificGameObjects();
                oyunSonu.enabled = true;
                myText.text = skor.text;             
                barinGucu = 1f;

                if (PlayerPrefs.GetInt("High Score") < KapaAc.skor)
                {
                    Kullaniciİstatistigi.highScoreValue = KapaAc.skor;
                    PlayerPrefs.SetInt("High Score", Kullaniciİstatistigi.highScoreValue);
                }

            }

        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (barinGucu > 0)
        {
            barinGucu = barinGucu - 0.1f;
            canBari.rectTransform.localScale = new Vector3(barinGucu, 1f, 1f);
            sesler[1].Play();
        }
        Destroy(gameObject);


    }

    void DestroySpecificGameObjects()
    {
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("Karinca"))
        {
            Destroy(o);
        }
    }

 
}
