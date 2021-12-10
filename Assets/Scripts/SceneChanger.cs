/*


Playerprefs USED
Prefs name = description

prefname= = inputfield
-----------------------------
first_name = first name
last_name = last name
gradeLevel = grade na nilagay
age = age na pinili
SubjectSelected = subject na pinili
SelectedTopic = Piniling Topic
SelectedTopicSprite = Spritename ng piniling topic para kapag bumalik sa pilian ng topic, ang nakasaet ay yuhng piniling topic
MAIN_VOLUME = current volume sa settings slider
GRAPHICS = settings ng graphics sa option
EngGrade_AVRG = average grade sa english
MathGrade_AVRG = average grade sa math
ScienceGrade_AVRG = average grade sa science
BasicSkillsGrade_AVRG = average grade sa basic skills
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    
    
    public void SelectSubject()
    {
        PlayerPrefs.DeleteKey("SelectedTopic");
        PlayerPrefs.DeleteKey("SelectedTopicSprite");
        SceneManager.LoadScene(2);
        Debug.Log("User go to select subject");
    }

    public void AllScore()
    {
        SceneManager.LoadScene(3);
        Debug.Log("User go to see all score");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("The game closed");
    }
    public void Home()
    {
        SceneManager.LoadScene(0);
        Debug.Log("User go to Home");
    }
    public void Mathe()
    {
        Debug.Log("Going mathe");
        SceneManager.LoadScene(5);
        Debug.Log("Going mathe done");
        PlayerPrefs.SetString("SubjectSelected", "Math");
        Debug.Log("User go to Math");
    }
    public void Science()
    {
        Debug.Log("Going science");
        SceneManager.LoadScene(4);
        Debug.Log("Going science done");
        PlayerPrefs.SetString("SubjectSelected", "Science");
        Debug.Log("User go to Science");
    }
    public void English()
    {
        Debug.Log("Going english");
        SceneManager.LoadScene(6);
        Debug.Log("Going english done");
        PlayerPrefs.SetString("SubjectSelected", "English");
        Debug.Log("User go to English");
    }
    public void BasicSkills()
    {
        Debug.Log("Going basic");
        SceneManager.LoadScene(7);
        Debug.Log("Going basic done");
        PlayerPrefs.SetString("SubjectSelected", "BasicSkills");
        Debug.Log("User go to Basic Skills");
    }
    public void BackFromGame()
    {
        SceneManager.LoadScene(8);
    }
}
