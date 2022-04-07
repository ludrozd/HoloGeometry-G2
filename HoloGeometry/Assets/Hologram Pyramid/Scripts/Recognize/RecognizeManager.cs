using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RecognizeManager : MonoBehaviour
{ 
    public List<RecognizeQuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject GoPanel;
    public Text ScoreTxt;
    int totalQuestions = 0;
    public int score;

    private void Start()
    {
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        HideAllGeometricObjects();
        generateQuestion();
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameOver()
    {
        GoPanel.SetActive(true);
        ScoreTxt.text = score + "/" + totalQuestions;
    }

    public void correct()
    {
        score += 1;
        QnA[currentQuestion].Question.SetActive(false);
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    public void wrong()
    {
        QnA[currentQuestion].Question.SetActive(false);
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    IEnumerator waitForNext()
    {
        yield return new WaitForSeconds(1);
        generateQuestion();
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Image>().color = options[i].GetComponent<Answerer>().startColor;
            options[i].GetComponent<Answerer>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<Answerer>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);
            GenerateRandomGeometricObject(currentQuestion);
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }

    }
    void GenerateRandomGeometricObject(int random)
    {
        QnA[random].Question.SetActive(true);
    }
    void HideAllGeometricObjects()
    {
        for (int i = 0; i < QnA.Count; i++)
            QnA[i].Question.SetActive(false);
    }
}
