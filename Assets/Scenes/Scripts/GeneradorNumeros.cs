using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorNumeros : MonoBehaviour
{
    public GameObject _PrefabNumero;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarNumero", 1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void GenerarNumero()
    {
        Vector2 costatsuperiordret = Camera.main.ViewportToWorldPoint(new Vector2(1f, 1f));
        Vector2 costatinferioresquerra = Camera.main.ViewportToWorldPoint(new Vector2(0f, 0f));
        GameObject numero = Instantiate(_PrefabNumero);
        numero.transform.position = new Vector2(Random.Range(costatinferioresquerra.x,costatsuperiordret.x),costatsuperiordret.y);
    }
}