using UnityEngine;

public class destruir : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("bloque")){
            Destroy(collision.gameObject);//Destruyo el objeto con el que colisione
        }
    }
}
