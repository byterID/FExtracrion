using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject buttonsMenu;
    
    public void ExitGame()
    {
        Application.Quit();
    }


    public void NewGameLoadScenesUPK()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void LoadMain()
    {
        SceneManager.LoadScene("startroom");
    }
}
