using UnityEngine;
using UnityEngine.SceneManagement;//Libreria para manejar escenas

public class newgame : MonoBehaviour
{

    public void botonInicio(){
        Debug.Log("NEW GAME");
        SceneManager.LoadScene("PrimerParcial");//Poner nombre de su escena
    }

}
