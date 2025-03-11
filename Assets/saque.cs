using UnityEngine;

public class saque : MonoBehaviour
{
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
        playing=false;
        pelotaRB.linearVelocity=Vector2.zero;
        transform.position=inicio.position;
    }
}
