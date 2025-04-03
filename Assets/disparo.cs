using UnityEngine;

public class disparo : MonoBehaviour
{
    public GameObject bala;//Declaramos la variable bala
    public Transform origen;
    public float speedBala;//velocidad de la bala
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject laBala=Instantiate(bala,origen.position,Quaternion.identity);
            Rigidbody2D balaRB=laBala.GetComponent<Rigidbody2D>();
            balaRB.AddForce(Vector2.down*speedBala,ForceMode2D.Impulse);
            Destroy(laBala,1.5f);//Destruyo la bala medio seg despues
        }
    }
}
