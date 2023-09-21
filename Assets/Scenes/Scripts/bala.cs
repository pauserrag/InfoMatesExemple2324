using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public float velocity = 5f;
    public float maxY;
    public GameObject bullets_1;


    void Start()
    {
       maxY = Camera.main.ScreenToWorldPoint(new Vector3(0,Screen.height,0)).y;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 novaPos = transform.position;
        novaPos.y=novaPos.y + velocity * Time.deltaTime;
        transform.position = novaPos;
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (novaPos.y > maxY) { Destroy(gameObject); }
    }
    private void OnTriggerEnter2D(Collider2D objecteTocat)
    {
        if (objecteTocat.tag == "numero") { 
        Destroy(gameObject);
        
        }
    }
}
