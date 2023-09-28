using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject nauJugador;
    public GameObject gameOver;
    public GameObject boto;

    public enum EstatsGameManager { 

    Inici,
    Jugant,
    GameOver

    }
    private EstatsGameManager _estatGameManager;
    void Start()
    {
        _estatGameManager = EstatsGameManager.Inici;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void ActualitzaEstatGameManager() { 
    
        switch (_estatGameManager)
        {
            case EstatsGameManager.Inici:

                nauJugador.SetActive(false);
                GameObject.Find("GameOver").SetActive(false);
                GameObject.Find("TitolJoc").SetActive(true);
                GameObject.Find("BotoInici").SetActive(true);



                break;
                case EstatsGameManager.Jugant:
                nauJugador.SetActive(true);
                boto.SetActive(false);
                GameObject.Find("TitolJoc").SetActive(false);
                GameObject.Find("GameOver").SetActive(false);
                GameObject.Find("BotoInici").SetActive(false);




                break;
                case EstatsGameManager.GameOver:
                GameObject.Find("GameOver").SetActive(true);
                nauJugador.SetActive(false);
                GameObject.Find("TitolJoc").SetActive(false);
                GameObject.Find("BotoInici").SetActive(false);





                break;
        }
            
    }
    public void SetEstatGameManager(EstatsGameManager estat)
    {
        _estatGameManager = estat;
        ActualitzaEstatGameManager();
    }
    public void PassarAEstatJugant()
    {
        _estatGameManager = EstatsGameManager.Jugant;
        ActualitzaEstatGameManager();

    }
}
