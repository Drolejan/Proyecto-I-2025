using UnityEngine;

public class enemigoScript : MonoBehaviour
{
    Transform objetivo;
    public float speedE;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objetivo=GameObject.Find("Jugador").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 target=Vector2.MoveTowards(transform.position,objetivo.position,speedE*Time.deltaTime);
        transform.position=target;//Avanzar hacia el player
    }
}
