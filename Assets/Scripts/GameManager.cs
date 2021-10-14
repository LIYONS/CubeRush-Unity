
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded=false;

    public GameObject completeMessage;

    public void EndLevel ()
    {
        completeMessage.SetActive(true);
    } 
    public void EndGame(){
        if(gameHasEnded == false){

            gameHasEnded=true;
            Invoke("Restart",3f);

        }
       

    }
    void Restart(){
           SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       }
    
}
