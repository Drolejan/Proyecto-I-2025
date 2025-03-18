using UnityEngine;

public class enemigo : MonoBehaviour
{
    public Transform pelota;//Posicion de la pelota
    void Start()
    {
        
    }
    void Update()
    {
        //Sigue la coordenada en Y de la pelota
        transform.position=new Vector2(transform.position.x,pelota.position.y);
    }
}
