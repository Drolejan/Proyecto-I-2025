using UnityEngine;//Libreria Unity

public class pruebaPrimero : MonoBehaviour
{
    public int vidas;
    public float score;
    public string nombrePlayer;
    public bool estoyVivo;
    public Transform checkpoint;
    public SpriteRenderer skin;//HOLA

    // Start se ejecuta 1 sola vez al dar play
    void Start()
    {
        score=0;
        estoyVivo=true;
        Debug.Log(nombrePlayer);
        transform.position=checkpoint.position;//Asigno una nueva posición al iniciar
    }

    // Update se ejecuta todo el tiempo
    void Update()
    {
        score++;
    }
}
