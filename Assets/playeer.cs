using UnityEngine;

public class playeer : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float vel=10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRB=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movY = Input.GetAxis("Vertical")*vel;//Detectamos el input de Y
        playerRB.linearVelocityY=movY;//Asignamos el input a la velocidad del rb
    }
}
