using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MultipleChoiceAnswer : QuestionPiece
{

    [SerializeField]
    GameObject textObject;

    [SerializeField]
    GameObject toggleObject;

    [SerializeField]
    GameObject deleteObject;

   
    public TMP_InputField answerText { private set; get; }
    public Toggle correctAnswer { private set; get; }
    public Button deleteButton { private set; get; }

    public void Init()
    {
        answerText = textObject.GetComponent<TMP_InputField>();
        correctAnswer = toggleObject.GetComponent<Toggle>();
        deleteButton = deleteObject.GetComponent<Button>();
    }

}
