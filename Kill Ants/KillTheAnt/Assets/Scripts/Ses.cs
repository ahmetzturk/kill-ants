using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ses : MonoBehaviour
{
    public AudioSource Antsource;
    private Vector2 pos;
    private Vector2 worldPos;


    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    { 

        //if(Input.GetMouseButtonDown(0) == true)
        if (GameObject.Find("Ev").GetComponent<BolumOlustur>().touch1.phase == TouchPhase.Began || GameObject.Find("Ev").GetComponent<BolumOlustur>().touch1.phase == TouchPhase.Stationary || GameObject.Find("Ev").GetComponent<BolumOlustur>().touch2.phase == TouchPhase.Began || GameObject.Find("Ev").GetComponent<BolumOlustur>().touch2.phase == TouchPhase.Stationary)
        {

            //pos = Input.mousePosition;
            //worldPos = Camera.main.ScreenToWorldPoint(pos);
            if (GameObject.Find("Ev").GetComponent<BolumOlustur>().touch1.phase == TouchPhase.Began || GameObject.Find("Ev").GetComponent<BolumOlustur>().touch1.phase == TouchPhase.Stationary)
            {
                worldPos = Camera.main.ScreenToWorldPoint(new Vector3(GameObject.Find("Ev").GetComponent<BolumOlustur>().touch1.position.x, GameObject.Find("Ev").GetComponent<BolumOlustur>().touch1.position.y, 10));
            }
            else
            {
                worldPos = Camera.main.ScreenToWorldPoint(new Vector3(GameObject.Find("Ev").GetComponent<BolumOlustur>().touch2.position.x, GameObject.Find("Ev").GetComponent<BolumOlustur>().touch2.position.y, 10));
            }

            if (gameObject.GetComponent<BoxCollider2D>() != null)
            {
                float mostExtraX = (gameObject.GetComponent<BoxCollider2D>().size.x) / 2;
                float mostExtraY = (gameObject.GetComponent<BoxCollider2D>().size.y) / 2;

                if (gameObject.transform.position.x - mostExtraX < worldPos.x &&
               worldPos.x < gameObject.transform.position.x + mostExtraX &&
               gameObject.transform.position.y - mostExtraY < worldPos.y &&
               worldPos.y < gameObject.transform.position.y + mostExtraY)
                {
                    Antsource.Play();
                }
            }
        }
    }
    //(-9,-6,0)
    // Update is called once per frame
    /*void OnMouseDown()
    {
        if (tekSeferlik == 0)
        {
            Antsource.Play();
            tekSeferlik++;
        }
    }*/
}
