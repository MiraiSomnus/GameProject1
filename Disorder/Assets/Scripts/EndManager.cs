using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndManager : MonoBehaviour
{
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Escape)){
            Debug.Log("App Escaped");
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
            
        
        }  
    }
}
