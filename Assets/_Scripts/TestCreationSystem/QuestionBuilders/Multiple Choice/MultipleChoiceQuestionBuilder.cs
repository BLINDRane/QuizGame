using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MultipleChoiceQuestionBuilder : MonoBehaviour
{
    [SerializeField]
    GameObject promptObject;

    [SerializeField]
    GameObject answerListObject;

    [SerializeField]
    Transform answerListContent;

    public TMP_InputField prompt { private set; get; }
    public ScrollRect answerList { private set; get; }

    void Start()
    {
        prompt = promptObject.GetComponent<TMP_InputField>();
        answerList = answerListObject.GetComponent<ScrollRect>();
    }

    public Transform GetAnswerListContent()
    {
        return answerListContent;
    }
}
