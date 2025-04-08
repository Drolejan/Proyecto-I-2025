using UnityEngine;

public class bala : MonoBehaviour
{
    GameManager gm;
    void Start()
    {
        //Cuando aparece la bala, busca el manager y lo asigna a su variable gm
        gm=GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("enemigo")){
            Destroy(collision.gameObject);//Destruimos el enemigo
            gm.sumarPuntos();//ejecuto la funcion de mi gamemanager
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
