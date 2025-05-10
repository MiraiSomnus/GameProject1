using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryManager : MonoBehaviour
{
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.L)){
            RetryCurrentScene();
        }
        
    }

    public void RetryCurrentScene(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
    }
}//
