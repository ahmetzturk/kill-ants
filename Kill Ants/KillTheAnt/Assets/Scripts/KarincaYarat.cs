using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarincaYarat : MonoBehaviour
{
    private int sayac;
    private int randomNumber;
    public static float birimYaratimSikligi = 50;
    private Vector3[] karincaPositions = new Vector3[8];
    private Vector3[] karincaRotations = new Vector3[8];
    public GameObject kullanilmayanKarinca;
    public GameObject kullanilmayanKarinca2;

    // Start is called before the first frame update
    void Start()
    {
        sayac = 0;
        randomNumber = 0;
        for(int i = 1; i < 8; i++)
        {
            string s = "Karınca (" + i.ToString() + ")";
            karincaPositions[i] = GameObject.Find(s).transform.position;
            karincaRotations[i] = GameObject.Find(s).transform.rotation.eulerAngles;
        }      
    }

    // Update is called once per frame
    void Update()
    {
        sayac++;
        if (sayac == (int)birimYaratimSikligi)
        {
            switch(randomNumber = (int) Random.Range(1f, 8f))
            {
                case 1:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 1)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[1], Quaternion.Euler(karincaRotations[1]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[1], Quaternion.Euler(karincaRotations[1]));
                    }
                    break;
                case 2:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 2)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[2], Quaternion.Euler(karincaRotations[2]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[2], Quaternion.Euler(karincaRotations[2]));
                    }
                    break;
                case 3:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 3)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[3], Quaternion.Euler(karincaRotations[3]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[3], Quaternion.Euler(karincaRotations[3]));
                    }
                    break;
                case 4:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 4)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[4], Quaternion.Euler(karincaRotations[4]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[4], Quaternion.Euler(karincaRotations[4]));
                    }
                    break;
                case 5:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 5)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[5], Quaternion.Euler(karincaRotations[5]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[5], Quaternion.Euler(karincaRotations[5]));
                    }
                    break;
                case 6:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 6)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[6], Quaternion.Euler(karincaRotations[6]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[6], Quaternion.Euler(karincaRotations[6]));
                    }
                    break;
                case 7:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 7)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[7], Quaternion.Euler(karincaRotations[7]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[7], Quaternion.Euler(karincaRotations[7]));
                    }
                    break;
                case 8:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 8)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[8], Quaternion.Euler(karincaRotations[8]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[8], Quaternion.Euler(karincaRotations[8]));
                    }
                    break;
            }
        }
        else if (sayac == (int)birimYaratimSikligi * 2)
        {
            switch (randomNumber = (int)Random.Range(1f, 8f))
            {
                case 1:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 1)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[1], Quaternion.Euler(karincaRotations[1]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[1], Quaternion.Euler(karincaRotations[1]));
                    }
                    break;
                case 2:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 2)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[2], Quaternion.Euler(karincaRotations[2]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[2], Quaternion.Euler(karincaRotations[2]));
                    }
                    break;
                case 3:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 3)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[3], Quaternion.Euler(karincaRotations[3]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[3], Quaternion.Euler(karincaRotations[3]));
                    }
                    break;
                case 4:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 4)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[4], Quaternion.Euler(karincaRotations[4]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[4], Quaternion.Euler(karincaRotations[4]));
                    }
                    break;
                case 5:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 5)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[5], Quaternion.Euler(karincaRotations[5]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[5], Quaternion.Euler(karincaRotations[5]));
                    }
                    break;
                case 6:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 6)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[6], Quaternion.Euler(karincaRotations[6]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[6], Quaternion.Euler(karincaRotations[6]));
                    }
                    break;
                case 7:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 7)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[7], Quaternion.Euler(karincaRotations[7]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[7], Quaternion.Euler(karincaRotations[7]));
                    }
                    break;
                case 8:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 8)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[8], Quaternion.Euler(karincaRotations[8]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[8], Quaternion.Euler(karincaRotations[8]));
                    }
                    break;
            }
        }
        else if (sayac == (int)birimYaratimSikligi * 3)
        {
            switch (randomNumber = (int)Random.Range(1f, 8f))
            {
                case 1:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 1)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[1], Quaternion.Euler(karincaRotations[1]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[1], Quaternion.Euler(karincaRotations[1]));
                    }
                    break;
                case 2:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 2)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[2], Quaternion.Euler(karincaRotations[2]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[2], Quaternion.Euler(karincaRotations[2]));
                    }
                    break;
                case 3:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 3)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[3], Quaternion.Euler(karincaRotations[3]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[3], Quaternion.Euler(karincaRotations[3]));
                    }
                    break;
                case 4:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 4)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[4], Quaternion.Euler(karincaRotations[4]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[4], Quaternion.Euler(karincaRotations[4]));
                    }
                    break;
                case 5:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 5)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[5], Quaternion.Euler(karincaRotations[5]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[5], Quaternion.Euler(karincaRotations[5]));
                    }
                    break;
                case 6:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 6)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[6], Quaternion.Euler(karincaRotations[6]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[6], Quaternion.Euler(karincaRotations[6]));
                    }
                    break;
                case 7:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 7)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[7], Quaternion.Euler(karincaRotations[7]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[7], Quaternion.Euler(karincaRotations[7]));
                    }
                    break;
                case 8:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 8)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[8], Quaternion.Euler(karincaRotations[8]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[8], Quaternion.Euler(karincaRotations[8]));
                    }
                    break;
            }
        }
        else if (sayac == (int)birimYaratimSikligi * 4)
        {
            switch (randomNumber = (int)Random.Range(1f, 8f))
            {
                case 1:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 1)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[1], Quaternion.Euler(karincaRotations[1]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[1], Quaternion.Euler(karincaRotations[1]));
                    }
                    break;
                case 2:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 2)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[2], Quaternion.Euler(karincaRotations[2]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[2], Quaternion.Euler(karincaRotations[2]));
                    }
                    break;
                case 3:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 3)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[3], Quaternion.Euler(karincaRotations[3]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[3], Quaternion.Euler(karincaRotations[3]));
                    }
                    break;
                case 4:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 4)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[4], Quaternion.Euler(karincaRotations[4]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[4], Quaternion.Euler(karincaRotations[4]));
                    }
                    break;
                case 5:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 5)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[5], Quaternion.Euler(karincaRotations[5]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[5], Quaternion.Euler(karincaRotations[5]));
                    }
                    break;
                case 6:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 6)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[6], Quaternion.Euler(karincaRotations[6]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[6], Quaternion.Euler(karincaRotations[6]));
                    }
                    break;
                case 7:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 7)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[7], Quaternion.Euler(karincaRotations[7]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[7], Quaternion.Euler(karincaRotations[7]));
                    }
                    break;
                case 8:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 8)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[8], Quaternion.Euler(karincaRotations[8]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[8], Quaternion.Euler(karincaRotations[8]));
                    }
                    break;
            }
        }
        else if (sayac == (int)birimYaratimSikligi * 5)
        {
            switch (randomNumber = (int)Random.Range(1f, 8f))
            {
                case 1:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 1)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[1], Quaternion.Euler(karincaRotations[1]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[1], Quaternion.Euler(karincaRotations[1]));
                    }
                    break;
                case 2:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 2)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[2], Quaternion.Euler(karincaRotations[2]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[2], Quaternion.Euler(karincaRotations[2]));
                    }
                    break;
                case 3:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 3)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[3], Quaternion.Euler(karincaRotations[3]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[3], Quaternion.Euler(karincaRotations[3]));
                    }
                    break;
                case 4:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 4)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[4], Quaternion.Euler(karincaRotations[4]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[4], Quaternion.Euler(karincaRotations[4]));
                    }
                    break;
                case 5:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 5)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[5], Quaternion.Euler(karincaRotations[5]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[5], Quaternion.Euler(karincaRotations[5]));
                    }
                    break;
                case 6:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 6)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[6], Quaternion.Euler(karincaRotations[6]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[6], Quaternion.Euler(karincaRotations[6]));
                    }
                    break;
                case 7:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 7)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[7], Quaternion.Euler(karincaRotations[7]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[7], Quaternion.Euler(karincaRotations[7]));
                    }
                    break;
                case 8:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 8)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[8], Quaternion.Euler(karincaRotations[8]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[8], Quaternion.Euler(karincaRotations[8]));
                    }
                    break;
            }
        }
        else if (sayac == (int)birimYaratimSikligi * 6)
        {
            switch (randomNumber = (int)Random.Range(1f, 8f))
            {
                case 1:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 1)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[1], Quaternion.Euler(karincaRotations[1]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[1], Quaternion.Euler(karincaRotations[1]));
                    }
                    break;
                case 2:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 2)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[2], Quaternion.Euler(karincaRotations[2]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[2], Quaternion.Euler(karincaRotations[2]));
                    }
                    break;
                case 3:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 3)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[3], Quaternion.Euler(karincaRotations[3]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[3], Quaternion.Euler(karincaRotations[3]));
                    }
                    break;
                case 4:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 4)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[4], Quaternion.Euler(karincaRotations[4]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[4], Quaternion.Euler(karincaRotations[4]));
                    }
                    break;
                case 5:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 5)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[5], Quaternion.Euler(karincaRotations[5]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[5], Quaternion.Euler(karincaRotations[5]));
                    }
                    break;
                case 6:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 6)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[6], Quaternion.Euler(karincaRotations[6]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[6], Quaternion.Euler(karincaRotations[6]));
                    }
                    break;
                case 7:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 7)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[7], Quaternion.Euler(karincaRotations[7]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[7], Quaternion.Euler(karincaRotations[7]));
                    }
                    break;
                case 8:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 8)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[8], Quaternion.Euler(karincaRotations[8]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[8], Quaternion.Euler(karincaRotations[8]));
                    }
                    break;
            }
        }
        else if (sayac == (int)birimYaratimSikligi * 7)
        {
            switch (randomNumber = (int)Random.Range(1f, 8f))
            {
                case 1:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 1)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[1], Quaternion.Euler(karincaRotations[1]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[1], Quaternion.Euler(karincaRotations[1]));
                    }
                    break;
                case 2:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 2)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[2], Quaternion.Euler(karincaRotations[2]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[2], Quaternion.Euler(karincaRotations[2]));
                    }
                    break;
                case 3:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 3)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[3], Quaternion.Euler(karincaRotations[3]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[3], Quaternion.Euler(karincaRotations[3]));
                    }
                    break;
                case 4:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 4)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[4], Quaternion.Euler(karincaRotations[4]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[4], Quaternion.Euler(karincaRotations[4]));
                    }
                    break;
                case 5:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 5)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[5], Quaternion.Euler(karincaRotations[5]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[5], Quaternion.Euler(karincaRotations[5]));
                    }
                    break;
                case 6:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 6)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[6], Quaternion.Euler(karincaRotations[6]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[6], Quaternion.Euler(karincaRotations[6]));
                    }
                    break;
                case 7:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 7)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[7], Quaternion.Euler(karincaRotations[7]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[7], Quaternion.Euler(karincaRotations[7]));
                    }
                    break;
                case 8:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 8)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[8], Quaternion.Euler(karincaRotations[8]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[8], Quaternion.Euler(karincaRotations[8]));
                    }
                    break;
            }
        }
        else if (sayac == (int)birimYaratimSikligi * 8)
        {
            switch (randomNumber = (int)Random.Range(1f, 8f))
            {
                case 1:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 1)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[1], Quaternion.Euler(karincaRotations[1]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[1], Quaternion.Euler(karincaRotations[1]));
                    }
                    break;
                case 2:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 2)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[2], Quaternion.Euler(karincaRotations[2]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[2], Quaternion.Euler(karincaRotations[2]));
                    }
                    break;
                case 3:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 3)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[3], Quaternion.Euler(karincaRotations[3]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[3], Quaternion.Euler(karincaRotations[3]));
                    }
                    break;
                case 4:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 4)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[4], Quaternion.Euler(karincaRotations[4]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[4], Quaternion.Euler(karincaRotations[4]));
                    }
                    break;
                case 5:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 5)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[5], Quaternion.Euler(karincaRotations[5]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[5], Quaternion.Euler(karincaRotations[5]));
                    }
                    break;
                case 6:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 6)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[6], Quaternion.Euler(karincaRotations[6]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[6], Quaternion.Euler(karincaRotations[6]));
                    }
                    break;
                case 7:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 7)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[7], Quaternion.Euler(karincaRotations[7]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[7], Quaternion.Euler(karincaRotations[7]));
                    }
                    break;
                case 8:
                    if (GameObject.Find("Ev").GetComponent<BolumOlustur>().mevcutDalga > 8)
                    {
                        Instantiate(kullanilmayanKarinca2, karincaPositions[8], Quaternion.Euler(karincaRotations[8]));
                    }
                    else
                    {
                        Instantiate(kullanilmayanKarinca, karincaPositions[8], Quaternion.Euler(karincaRotations[8]));
                    }
                    break;
            }
        }
        else if (sayac > (int)birimYaratimSikligi * 8)
        {
            sayac = 0;
        }
    }
}
