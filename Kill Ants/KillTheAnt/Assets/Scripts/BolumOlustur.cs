using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BolumOlustur : MonoBehaviour
{
    private int skorEsigi;
    private int artimHizi;
    public int mevcutDalga;
    public Text levelGostergesi;
    public Touch touch1;
    public Touch touch2;
    private int tapCount;


    // Start is called before the first frame update
    void Start()
    {
        skorEsigi = 20;
        artimHizi = 10;
        mevcutDalga = 1;
        tapCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tapCount = Input.touchCount;
        if (tapCount == 1)
        {
            touch1 = Input.GetTouch(0);
        }
        else if (tapCount == 2)
        {
            touch1 = Input.GetTouch(0);
            touch2 = Input.GetTouch(1);
        }

        if (KapaAc.skor == skorEsigi)
        {
            mevcutDalga++;
            artimHizi += 10;
            skorEsigi += artimHizi;
            RotasalHareket.hiz += 0.05f;
            KarincaYarat.birimYaratimSikligi *= 0.9f;
            levelGostergesi.text = "Wave " + mevcutDalga;
            RotasalHareket.barinGucu = 1f;

        }
    }
}
