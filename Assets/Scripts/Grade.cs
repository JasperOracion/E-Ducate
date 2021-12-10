using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grade : MonoBehaviour
{
    public Text Fname, Lname, grade, English_Grade, Math_Grade, Science_Grade, BasicSkills_Grade;//gameobject ng mga nagbabago
    private void Start()
    {
        string FirstN = PlayerPrefs.GetString("first_name");
        string LastN = PlayerPrefs.GetString("last_name");
        string GradeLevel = "Grade " + PlayerPrefs.GetString("gradeLevel");
        string gradeEnglish = PlayerPrefs.GetString("EngGrade_AVRG");
        string gradeMath = PlayerPrefs.GetString("MathGrade_AVRG");
        string gradeScience = PlayerPrefs.GetString("ScienceGrade_AVRG");
        string gradeBasicSkills = PlayerPrefs.GetString("BasicSkillsGrade_AVRG");

        Fname.text = FirstN;//ilalagay ang registered name
        Lname.text = LastN;//ilalagay ang registered surname
        grade.text = GradeLevel;//ilalagay ang registered grade

        //uncomment ang nasa baba kapag meron ng laman na average ang mga nasa playerprefs sa taas
        
        // English_Grade.text = gradeEnglish;
        // Math_Grade.text = gradeMath;
        // Science_Grade.text = gradeScience;
        // BasicSkills_Grade.text = gradeBasicSkills;
    }
}
