using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TopicScience : MonoBehaviour
{

    public Sprite Top1, Top2, Top3;//dito nakalagay yung mga picture, dadami depende kung ilan ang topic
    public Text subText;//ito yung ng topic name na nakalagay, magiiba ito sa left and right button
    public Text fName;//ito yung naka display na first name kapag tiningnan ang grade
    public Text lName;//ito yung naka display na last name kapag tiningnan ang grade
    public Text GradNum;//ito yung naka display na grade level kapag tiningnan ang grade
    public Text TopicGrade;//ito yung grade niya sa topic na iyon
    public Text topicName;//ito yung name ng topic na nakalagay kapag inopen ang grade
    public Image activeTopic;//ito yung lagayan ng picture ng topic
    private void Start()
    {
        //papalitan agad yung mga nakasulat kapag inopen ang grade sa topic
        string FirstN = PlayerPrefs.GetString("first_name");
        string LasstN = PlayerPrefs.GetString("last_name");
        string GradeLevel = "Grade "+PlayerPrefs.GetString("gradeLevel");
        string chosenTopic = PlayerPrefs.GetString("SelectedTopic", "Earth Science");
        string spriteTopic = PlayerPrefs.GetString("SelectedTopicSprite", "Top1");
        if (spriteTopic == "Top1")
        {
            activeTopic.sprite = Top1;
        }
        if (spriteTopic == "Top2")
        {
            activeTopic.sprite = Top2;
        }
        if (spriteTopic == "Top3")
        {
            activeTopic.sprite = Top3;
        }

        subText.text = chosenTopic;
        topicName.text = chosenTopic;
        fName.text = FirstN;
        lName.text = LasstN;
        GradNum.text = GradeLevel;
    }
    public void NextRight()
    {
        string name = activeTopic.sprite.name;
        if (name == "Earth Science")//dadami yung condition depende sa bilang ng mga topic
        {
            //palitan nalang yung pagkukunan ng data ng score, depende kung san mo isa-save yung sore
            //TopicGrade.text = topicGrade;
            activeTopic.sprite = Top2;
            subText.text = "Body Parts";
            topicName.text = "Body Parts";
            PlayerPrefs.SetString("SelectedTopic", "Body Parts");
            PlayerPrefs.SetString("SelectedTopicSprite", "Top2");
        }
        if (name == "Body Parts")
        {
            //palitan nalang yung pagkukunan ng data ng score, depende kung san mo isa-save yung sore
            //TopicGrade.text = topicGrade;
            activeTopic.sprite = Top3;
            subText.text = "Chemistry";
            topicName.text = "Chemistry";
            PlayerPrefs.SetString("SelectedTopic", "Chemistry");
            PlayerPrefs.SetString("SelectedTopicSprite", "Top3");
        }
        if (name == "Chemistry")
        {
            //palitan nalang yung pagkukunan ng data ng score, depende kung san mo isa-save yung sore
            //TopicGrade.text = topicGrade;
            activeTopic.sprite = Top1;
            subText.text = "Earth Science";
            topicName.text = "Earth Science";
            PlayerPrefs.SetString("SelectedTopic", "Earth Science");
            PlayerPrefs.SetString("SelectedTopicSprite", "Top1");
        }
    }
    public void NextLeft()
    {
        string name = activeTopic.sprite.name;
        if (name == "Earth Science")
        {
            //palitan nalang yung pagkukunan ng data ng score, depende kung san mo isa-save yung sore
            //TopicGrade.text = topicGrade;
            activeTopic.sprite = Top3;
            subText.text = "Chemistry";
            topicName.text = "Chemistry";
            PlayerPrefs.SetString("SelectedTopic", "Chemistry");
            PlayerPrefs.SetString("SelectedTopicSprite", "Top3");
        }
        if (name == "Body Parts")
        {
            //palitan nalang yung pagkukunan ng data ng score, depende kung san mo isa-save yung sore
            //TopicGrade.text = topicGrade;
            activeTopic.sprite = Top1;
            subText.text = "Earth Science";
            topicName.text = "Earth Science";
            PlayerPrefs.SetString("SelectedTopic", "Earth Science");
            PlayerPrefs.SetString("SelectedTopicSprite", "Top1");
        }
        if (name == "Chemistry")
        {
            //palitan nalang yung pagkukunan ng data ng score, depende kung san mo isa-save yung sore
            //TopicGrade.text = topicGrade;
            activeTopic.sprite = Top2;
            subText.text = "Body Parts";
            topicName.text = "Body Parts";
            PlayerPrefs.SetString("SelectedTopic", "Body Parts");
            PlayerPrefs.SetString("SelectedTopicSprite", "Top2");
        }
    }
    
    public void Play()
    {
        string pickedTopic = subText.text;//ilalagay sa variable kung anong topic yung pinili
        PlayerPrefs.SetString("SelectedTopic", pickedTopic);//save sa playerprefs kase gagamitin kapg inopen yung select level na scene
        SceneManager.LoadScene(8);
    }
}
