using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
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
        movimentNau();
        shoot();
        shoot2();
        





        //print(novaPos);


    }
    private void movimentNau()
    {

        float movVertical = Input.GetAxis("Vertical");
        float movHoritzontal = Input.GetAxis("Horizontal");

        SpriteRenderer spriterenderer = GetComponent<SpriteRenderer>();
        float anchura = spriterenderer.bounds.size.x / 2;
        float altura = spriterenderer.bounds.size.y / 2;


        float limiteizqX = -Camera.main.orthographicSize * Camera.main.aspect + anchura;
        float limitederX = Camera.main.orthographicSize * Camera.main.aspect - anchura;
        float limiteizqY = -Camera.main.orthographicSize + altura;
        float limitederY = Camera.main.orthographicSize - altura;


        Vector2 movimiento = new Vector2(movHoritzontal, movVertical);

        Vector2 novaPos = transform.position;
        novaPos += movimiento * velocidad * Time.deltaTime;
        transform.position = novaPos;

        novaPos.x = Mathf.Clamp(novaPos.x, limiteizqX, limitederX);
        novaPos.y = Mathf.Clamp(novaPos.y, limiteizqY, limitederY);
    }
    private void shoot() {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject bala = Instantiate(Resources.Load("Prefabs/bala") as GameObject);
            bala.transform.position = this.transform.position;
            bala.transform.position = this.transform.position + new Vector3(-0.2f, 0.0f, 0.0f);



        }

    }
    private void shoot2()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject bala = Instantiate(Resources.Load("Prefabs/bala") as GameObject);
            bala.transform.position = this.transform.position + new Vector3(0.2f, 0.0f, 0.0f);

        }

    }

    
        

}
