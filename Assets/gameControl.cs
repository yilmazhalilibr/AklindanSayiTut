using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControl : MonoBehaviour
{
    int minValue = 1;
    int maxValue = 100;
    int prediction;
    bool start = false;
    bool finish = false;
    // Start is called before the first frame update
    void Start()
    {
        print("Benim oynamak ister misin? (E/H)");
    }

    // Update is called once per frame
    void Update()
    {
        //-----------Ba�lang��-------------
        if (start == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Akl�n�zdan bir ile y�z aras�nda say� tutup l�tfen 'Enter' tu�una bas�n...");
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                print("Umar�m sonra g�r���r�z...^^");
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Control();
                start = true;
            }
            
        }

        //-----------Ba�lang��-------------
        else if(!finish)
        {
            //-----------Oyun------------------
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minValue = prediction;
                Control();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maxValue = prediction;
                Control();
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                print("Say�y� bulduk...");
                finish = true;
            }
            //-----------Oyun------------------
        }
    }
    void Control()
    {
        prediction = (minValue + maxValue) / 2;
        print("Akl�ndan tuttu�un say� " + prediction + " mi?");
        print("E�er daha y�ksek ise Yukar� y�n tu�una d���kse A�a�� y�n tu�una bas�n do�ruysa bo�lu�a bas�n�z....");
    }
}
