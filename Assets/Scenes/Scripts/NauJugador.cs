using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NauJugador : MonoBehaviour
{
    public float _velNau;
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        _velNau = 5f;
        velocidad = 5f;
       

    }
        
    // Update is called once per frame
    void Update()
    {
        float movVertical = Input.GetAxis("Vertical");
        float movHoritzontal = Input.GetAxis("Horizontal");

        SpriteRenderer spriterenderer = GetComponent<SpriteRenderer>();
        float anchura = spriterenderer.bounds.size.x /2;
        float altura = spriterenderer.bounds.size.y / 2;


        float limiteizqX = -Camera.main.orthographicSize * Camera.main.aspect + anchura;
        float limitederX = Camera.main.orthographicSize * Camera.main.aspect - anchura;
        float limiteizqY = -Camera.main.orthographicSize + altura;
        float limitederY = Camera.main.orthographicSize - altura;


        Vector2 movimiento = new Vector2(movHoritzontal, movVertical);

        Vector2 novaPos = transform.position;
        novaPos +=  movimiento * velocidad * Time.deltaTime;

        novaPos.x = Mathf.Clamp(novaPos.x, limiteizqX, limitederX);
        novaPos.y = Mathf.Clamp(novaPos.y, limiteizqY, limitederY);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();


        }

        transform.position = novaPos;


        //print(novaPos);


    }
    private void shoot() {

        GameObject bala = Instantiate(Resources.Load("Prefabs/bala") as GameObject);
        bala.transform.position = this.transform.position;
    }
}
