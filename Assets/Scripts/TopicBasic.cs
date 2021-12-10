using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TopicBasic : MonoBehaviour
{
    public Text subText;//ito yung ng topic name na nakalagay
    public Text fName;//ito yung naka display na first name kapag tiningnan ang grade
    public Text lName;//ito yung naka display na last name kapag tiningnan ang grade
    public Text GradNum;//ito yung naka display na grade level kapag tiningnan ang grade
    public Text TopicGrade;//ito yung grade niya sa topic na iyon
    public Text topicName;//ito yung name ng topic na nakalagay kapag inopen ang grade


    private void Start()
    {
        //papalitan agad yung mga nakasulat kapag inopen ang grade sa topic
        string FirstN = PlayerPrefs.GetString("first_name");
        string LasstN = PlayerPrefs.GetString("last_name");
        string GradeLevel = "Grade "+PlayerPrefs.GetString("gradeLevel");
        fName.text = FirstN;
        lName.text = LasstN;
        GradNum.text = GradeLevel;
    }
    
    public void Play()
    {
        string pickedTopic = subText.text;//ilalagay sa variable kung anong topic yung pinili
        PlayerPrefs.SetString("SelectedTopic", pickedTopic);//save sa playerprefs kase gagamitin kapg inopen yung select level na scene
        SceneManager.LoadScene(8);
    }
}
