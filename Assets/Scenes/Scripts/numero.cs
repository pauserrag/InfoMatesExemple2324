using System.Collections;
using System.Collections.Generic;
using System.IO;

using UnityEngine;

public class numero : MonoBehaviour
{
    public GameObject num;
    private float _vel;
    // Start is called before the first frame update
    void Start()
    {
        _vel = 2;
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
}