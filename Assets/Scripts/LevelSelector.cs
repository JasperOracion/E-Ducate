using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public Text Title;//kung ano yung topic na pinili
    public Image background;//magiiba ito depende sa pinagmulang scene, kung math, science, english, etc..
    public Sprite English, Mathe, Science, BasicSkills;//dito nakalagay yung mga magiging background image depende kung anong subject yung pinili..

    private void Start()
    {
        string subject = PlayerPrefs.GetString("SubjectSelected");//nilagay sa variable kung ano yung piniling subject na nakasave sa playerprefs
        string topic = PlayerPrefs.GetString("SelectedTopic");//nilagay sa variable kung ano yung piniling subject na nakasave sa playerprefs

        Title.text = topic;//pinalitan na yung nakasulat na topic.. ang nilgay ay yung name ng topic na pinili, na nakasave sa playerprefs
        
        //if else, pangpalit ng background image depende sa piniling subject
        if (subject == "Math")
        {
            background.sprite = Mathe;
        }
        if (subject == "Science")
        {
            background.sprite = Science;
        }
        if (subject == "English")
        {
            background.sprite = English;
        }
        if (subject == "BasicSkills")
        {
            background.sprite = BasicSkills;
        }

        Debug.Log(PlayerPrefs.GetString("SubjectSelected"));
        Debug.Log(PlayerPrefs.GetString("SelectedTopic"));
    }
    public void BackFromSelectLevel()//ibabalik sa pilian ng topic.. babalik sya sa scene depende sa piniling subject na nakasave sa playerprefs
    {
        string prevScene = PlayerPrefs.GetString("SubjectSelected");
        if (prevScene == "Math")
        {
            SceneManager.LoadScene(5);
        }
        if (prevScene == "Science")
        {
            SceneManager.LoadScene(4);
        }
        if (prevScene == "English")
        {
            SceneManager.LoadScene(6);
        }
        if (prevScene == "BasicSkills")
        {
            SceneManager.LoadScene(7);
        }
    }
    public void goToGame()
    {
        SceneManager.LoadScene(9);
    }
}
