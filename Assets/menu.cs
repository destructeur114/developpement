using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public string leveltoload;

    public void startgame () 
    {
        scenemanager.loadscene(leveltoload);
    }

    public void settingbutton () 
    {
        
    }

    public void leavebutton () 
    {
     application.quit();
    }
}
