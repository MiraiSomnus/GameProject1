using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoryManager : MonoBehaviour
{

    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Mouse0)){
    
    SceneManager.LoadScene("Game");
        
        }  
    }
    
    
}
