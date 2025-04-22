using UnityEngine;

public class disparo : MonoBehaviour
{
    public GameObject bala;//Declaramos la variable bala
    public Transform origen;
    public float speedBala;//velocidad de la bala
    public Rigidbody2D playerRB;
    public float playerSpeed;
    void Update()
    {
        //Esto es el movimiento
        float movimientoX=Input.GetAxis("Horizontal");
        float movimientoY=Input.GetAxis("Vertical");
        Vector2 movimientoPlayer= new Vector2(movimientoX , movimientoY)*playerSpeed;
        playerRB.linearVelocity=movimientoPlayer;

        //Rotación del Personaje (Importante configurar el disparo hacia la derecha primero)
        //Si el movimiento del player es diferente de 0
        if(movimientoPlayer != Vector2.zero){
            float angle=Mathf.Atan2(movimientoY,movimientoX)*Mathf.Rad2Deg;
            playerRB.rotation=angle;
        }

        //Esto es el disparo
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject laBala=Instantiate(bala,origen.position,transform.rotation);
            Rigidbody2D balaRB=laBala.GetComponent<Rigidbody2D>();
            balaRB.AddForce(transform.right*speedBala,ForceMode2D.Impulse);
            Destroy(laBala,1.5f);//Destruyo la bala medio seg despues
        }
    }
}
