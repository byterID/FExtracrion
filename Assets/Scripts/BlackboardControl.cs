using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackboardControl : MonoBehaviour
{
    [SerializeField] public GameObject Guide1;
    [SerializeField] public GameObject Guide2;
    [SerializeField] public GameObject Guide3;
    [SerializeField] public GameObject Guide4;
    [SerializeField] public GameObject Guide0;

    public void ActivateGuide1()
    {
        Guide1.SetActive(true);
        Guide2.SetActive(false);
    }
    public void ActivateGuide2()
    {
        Guide1.SetActive(false);
        Guide2.SetActive(true);
        Guide3.SetActive(false);
    }
    public void ActivateGuide3()
    {
        Guide2.SetActive(false);
        Guide3.SetActive(true);
        Guide0.SetActive(true);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("startroom");
    }
}
