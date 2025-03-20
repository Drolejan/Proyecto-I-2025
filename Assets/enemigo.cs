using UnityEngine;

public class enemigo : MonoBehaviour
{
    public Transform pelota;//Posicion de la pelota
    public float pelotaVel;
    void Start()
    {
        
    }
    void Update()
    {
        float target = Mathf.MoveTowards(transform.position.y,pelota.position.y,pelotaVel*Time.deltaTime);
        //Sigue la coordenada en Y de la pelota
        transform.position=new Vector2(transform.position.x,target);
    }
}
