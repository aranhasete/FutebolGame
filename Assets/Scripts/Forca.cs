using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Forca : MonoBehaviour {

    private Rigidbody2D bola;
    public float force = 0f;
    private Rotacao rota;
    public Image seta2Image;

    // Use this for initialization
    void Start() {
        bola = GetComponent<Rigidbody2D>();
        rota = GetComponent<Rotacao>();

    }

    // Update is called once per frame
    void Update() {
        ControlaForca();
        AplicaForca();
    }

    void AplicaForca()
    {
        //if (Input.GetKeyUp(KeyCode.Space))
        if (rota.liberaTiro == true)
        {
            float x = force * Mathf.Cos(rota.zRotate * Mathf.Deg2Rad);
            float y = force * Mathf.Sin(rota.zRotate * Mathf.Deg2Rad);
            bola.AddForce(new Vector2(x, y));

        }
    }

    void ControlaForca()
    {
        if (rota.liberaRota == true)
        {
            float moveX = Input.GetAxis("Mouse X");

            if (moveX < 0)
            {
                seta2Image.fillAmount += 0.8f * Time.deltaTime;
                force = seta2Image.fillAmount * 10;
            }

            if (moveX > 0)
            {
                seta2Image.fillAmount -= 0.8f  * Time.deltaTime;
                force = seta2Image.fillAmount * 10;
            }
        }
    }
}
//String[] substrings = value.Split(delimiter);


//using System;

//public class Test
//{
//    public static void Main()
//    {
//        string line;
//        while ((line = Console.ReadLine()) != null)
//        {
//            int n1, dividendo;
//            int n2, divisor, resto;

//            n1 = 2;
//            n2 = 4;

//            if (n1 > n2)
//            {
//                dividendo = n1;
//                divisor = n2;
//            }
//            else
//            {
//                dividendo = n2;
//                divisor = n1;
//            }

//            while (dividendo % divisor != 0)
//            {
//                resto = dividendo % divisor;
//                dividendo = divisor;
//                divisor = resto;
//            }

//            Console.WriteLine(line);
//        }
//    }
//}