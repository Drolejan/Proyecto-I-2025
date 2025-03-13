using UnityEngine;
using TMPro;//Con esto importamos comandos de TextMeshPro

public class saque : MonoBehaviour
{
    public int scoreP1,scoreP2;//Variables numericas
    public TextMeshProUGUI textoP1,textoP2;//Variables de texto
    Rigidbody2D pelotaRB;//Este es el rigidbody de la pelota
    public float fuerza;
    public bool playing;
    public Transform inicio;
    void Start()
    {
        pelotaRB=GetComponent<Rigidbody2D>();//Obtenemos el componente
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&playing==false){
            pelotaRB.AddForce(Vector2.one*fuerza,ForceMode2D.Impulse);
            playing=true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("golP1")){
            playing=false;
            pelotaRB.linearVelocity=Vector2.zero;
            transform.position=inicio.position;
            scoreP1++;//Le sumamos 1 al score
            textoP1.text="Jugador1: "+scoreP1.ToString();//Cambiamos el texto
        }
        if(collision.gameObject.CompareTag("golP2")){
            playing=false;
            pelotaRB.linearVelocity=Vector2.zero;
            transform.position=inicio.position;
            scoreP2++;//Le sumamos 1 al score
            textoP2.text="Jugador2: "+scoreP2.ToString();//Cambiamos el texto
        }
        
    }
}
