using System.Collections;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemigo;
    public bool generando;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(generador());//Empezamos la corutina
    }
    IEnumerator generador(){
        while(generando==true){
        //Esto se ejecuta primero
        Debug.Log("EMPIEZA LA RUTINA");
        yield return new WaitForSeconds(1f);//Esperamos 1 segundo
        //Esto se ejecuta despues
        GameObject elEnemigo=Instantiate(enemigo,transform.position,Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
