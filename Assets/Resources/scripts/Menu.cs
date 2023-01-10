using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject buttonsMenu;
    public GameObject SoundSettings;
    public GameObject GraphicsSettings;
    public GameObject Achievments;


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
    public void SetSoundActive()
    {
        SoundSettings.SetActive(true);
        GraphicsSettings.SetActive(false);
        Achievments.SetActive(false);
    }
    public void SetGraphicsActive()
    {
        SoundSettings.SetActive(false);
        GraphicsSettings.SetActive(true);
        Achievments.SetActive(false);
    }
    public void SetAchievmentsActive()
    {
        SoundSettings.SetActive(false);
        GraphicsSettings.SetActive(false);
        Achievments.SetActive(true);
    }
}
