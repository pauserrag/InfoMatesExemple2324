using System.Collections;
using System.Collections.Generic;
using System.IO;

using UnityEngine;

public class numero : MonoBehaviour
{
    public GameObject num;
    private int _valornumero;
    public Sprite[] _spritesNumeros = new Sprite[10];
    private float _vel;
    // Start is called before the first frame update
    void Start()
    {
        _vel = 2;
        System.Random aleatori = new System.Random();
        _valornumero = aleatori.Next(0, 10);
        gameObject.GetComponent<SpriteRenderer>().sprite = _spritesNumeros[_valornumero];
       
    }

    // Update is called once per frame
    void Update()
    {
       

        DestrueixSiSurtFora();


        Vector2 novaPos = transform.position;
        novaPos.y = novaPos.y - _vel * Time.deltaTime;
        transform.position = novaPos;

    }
    private void DestrueixSiSurtFora()
    {
        if (transform.position.y <= -3)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D objecteTocat)
    {
        if(objecteTocat.tag == "bala"|| objecteTocat.tag == "nau") {
        Destroy(gameObject);
        }
    }
}