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
        //-----------Baþlangýç-------------
        if (start == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Aklýnýzdan bir ile yüz arasýnda sayý tutup lütfen 'Enter' tuþuna basýn...");
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                print("Umarým sonra görüþürüz...^^");
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Control();
                start = true;
            }
            
        }

        //-----------Baþlangýç-------------
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
                print("Sayýyý bulduk...");
                finish = true;
            }
            //-----------Oyun------------------
        }
    }
    void Control()
    {
        prediction = (minValue + maxValue) / 2;
        print("Aklýndan tuttuðun sayý " + prediction + " mi?");
        print("Eðer daha yüksek ise Yukarý yön tuþuna düþükse Aþaðý yön tuþuna basýn doðruysa boþluða basýnýz....");
    }
}
