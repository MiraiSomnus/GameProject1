using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryManager : MonoBehaviour
{
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
             UnityEditor.EditorApplication.isPlaying = false;
        }
         
    }

}
