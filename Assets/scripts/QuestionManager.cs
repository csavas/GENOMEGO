using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestionManager : MonoBehaviour
{
    public Question[] questions;
    private static List<Question> unansweredQ;
    private Question currentQ;
    private int questionIndex;
    private int incorrectNum;
    private int correctInd;

    private float delay = 1f;

    [SerializeField]
    private Text qText;
    [SerializeField]
    private Text ans0;
    [SerializeField]
    private Text ans1;
    [SerializeField]
    private Text ans2;
    [SerializeField]
    private Text ans3;

    public void Start()
    {
        if (unansweredQ == null || unansweredQ.Count == 0) {
            unansweredQ = questions.ToList<Question>();
            questionIndex = 0;
        }
        incorrectNum = 300;
        SetQuestion();
        //Debug.Log(currentQ.question + " " + currentQ.ans);

    }
    void SetQuestion() {
        currentQ = unansweredQ[questionIndex];
        qText.text = currentQ.question;
        ans0.text = currentQ.ans[0];
        ans1.text = currentQ.ans[1];
        ans2.text = currentQ.ans[2];
        ans3.text = currentQ.ans[3];

        questionIndex++;
        correctInd = 2;
    }

    public void next() {
        SceneManager.LoadScene("correctAns", LoadSceneMode.Single);
        
    }

    public void incorrectNext()
    {
        SceneManager.LoadScene("wrongAns", LoadSceneMode.Single);
        if(incorrectNum > 0)
            incorrectNum = incorrectNum - 100;
    }

    public void UserSelectAns0() {
        if (correctInd == 0)
            next();
        else
            incorrectNext();
    }
    public void UserSelectAns1() {
        if (correctInd == 1)
            next();
        else
            incorrectNext();
    }
    public void UserSelectAns2() {
        if (correctInd == 2)
            next();
        else
            incorrectNext();
    }
    public void UserSelectAns3() {
        if (correctInd == 3)
            next();
        else
            incorrectNext();
    }

}
