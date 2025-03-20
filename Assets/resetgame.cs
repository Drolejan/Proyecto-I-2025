using UnityEngine;
using UnityEngine.SceneManagement;//Importamos la libreria de manejo de escenas

public class resetgame : MonoBehaviour
{
    public void Awake()
    {
        Time.timeScale=1;//Descongelamos el tiempo
    }
    public void resetmalo(){      
        //Leo el indice de la escena actual y lo cargo
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
    }
}
