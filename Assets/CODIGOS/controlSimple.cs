using UnityEngine;

public class controlSimple : MonoBehaviour
{
    Rigidbody2D playerRB;//Declaramos una variable de tipo Rigidbody2d
    public float velocidad=1;
    public float fuerza =10;//Fuerza del salto
    public GameObject jumpscare;//Declaro un gameobject
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       playerRB=GetComponent<Rigidbody2D>();//Obtenemos el componente RB de nuestro objeto 
    }

    // Update is called once per frame
    void Update()
    {
       float ejeX=Input.GetAxis("Horizontal");//Obtenemos el input horizontal
       playerRB.linearVelocityX=ejeX*velocidad;//Le asignamos la velocidad en X de acuerdo al input

       if(Input.GetKeyDown(KeyCode.Space)){
         playerRB.AddForce(Vector2.up*fuerza,ForceMode2D.Impulse);
       }
    }

   //Lo que vamos a hacer ahorita va fuera del update pero dentro de la class
   void OnCollisionEnter2D(Collision2D col){
      Debug.Log(col.gameObject.name);//Imprime el nombre del objeto que choque
      if(col.gameObject.CompareTag("item")){
         Destroy(col.gameObject);//Destruye el objeto si es un item
      }
      if(col.gameObject.CompareTag("Respawn")){
         jumpscare.SetActive(true);//Activa el jumpscare
      }
   }
   void OnTriggerEnter2D(Collider2D col){
      Debug.Log(col.gameObject.name);//Imprime el nombre del objeto que choque
      if(col.gameObject.CompareTag("muerte")){
         transform.position=Vector2.zero;//Al tocar la muerte regresas al punto 0,0
      }
   }

}///No escriban por ahora despues de la llave final
