using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotacao : MonoBehaviour {

    //Posição Seta
    [SerializeField] private Transform posStart;
    //Seta
    [SerializeField] private Image setaImg;

    public GameObject setaGO;

    //Ang
    public float zRotate;
    public bool liberaRota = false;
    public bool liberaTiro = false;

    // Use this for initialization
    void Start () {
        PosicionaSeta();
        PosicionaBola();
	}
	
	// Update is called once per frame
	void Update () {
        RotacaoSeta();
        InputDeRotacao();
        LimitaRotacao();
	}

    void PosicionaSeta()
    {
        setaImg.rectTransform.position = posStart.position + new Vector3(0.5f, 0, zRotate); ;
    }

    void PosicionaBola()
    {
        this.gameObject.transform.position = posStart.position;
    }

    void RotacaoSeta()
    {
        setaImg.rectTransform.eulerAngles = new Vector3(0, 0, zRotate);
    }

    void InputDeRotacao()
    {
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    zRotate += 2.5f;
        //}

        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    zRotate -= 2.5f;
        //}

        if (liberaRota == true) 
        {
            //float moveX = Input.GetAxis("Mouse X");
            float moveY = Input.GetAxis("Mouse Y");

            if(zRotate < 90)
            {
                if (moveY > 0)
                {
                    zRotate += 2.5f;
                }
            }

            if (zRotate > 0)
            {
                if (moveY < 0)
                {
                    zRotate -= 2.5f;
                }
            }
        }
    }

    void LimitaRotacao()
    {
        if (zRotate >= 90)
        {
            zRotate = 90;
        }

        if (zRotate <= 0)
        {
            zRotate = 0;
        }
    }

    private void OnMouseDown()
    {
        liberaRota = true;
        //liberaTiro = false;
        setaGO.SetActive(true);
    }

    private void OnMouseUp()
    {
        liberaRota = false;
        liberaTiro = true;
        setaGO.SetActive(false);
    }
}
