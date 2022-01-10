using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestMaker : MonoBehaviour
{

    [SerializeField]
    GameObject newTestButton;

    [SerializeField]
    GameObject testMakingGroup;

    [SerializeField]
    GameObject[] questionTypes;
    int selectedQuestionType;

    [SerializeField]
    MultipleChoiceQuestionBuilder mcQuestionBuilder;

    [SerializeField]
    GameObject mcAnswerTemplate;

    private Test underConstruction;

    /// <summary>
    /// Deactivates the make test button and activates the test making suite
    /// </summary>
    public void BeginTestContruction()
    {
        newTestButton.SetActive(false);
        testMakingGroup.SetActive(true);
        underConstruction = new Test();
    }

    public void ShowQuestionBuildTools(int option)
    {
        questionTypes[selectedQuestionType].SetActive(false);
        questionTypes[option].SetActive(true);
        selectedQuestionType = option;
    }

    #region MultipleChoiceBuilder

    public void AddMCAnswer()
    {
        // Create a new answer object and put it in the scroll list
        GameObject temp = Instantiate(mcAnswerTemplate, mcQuestionBuilder.GetAnswerListContent());

        // Create a reference to the answer's script
        MultipleChoiceAnswer mcAnswer = temp.GetComponent<MultipleChoiceAnswer>();

        // Tell the answer script to initialize itself
        mcAnswer.Init();

        // When the delete button is pressed, destroy temp.
        mcAnswer.deleteButton.onClick.AddListener(() =>
        {
            Destroy(temp);
        });

        // If this is the first answer added, mark it as the correct one
        if(mcQuestionBuilder.answerList.content.childCount == 1)
        {
            mcAnswer.correctAnswer.SetIsOnWithoutNotify(true);
        }

        // When the toggle button is pressed, check if there is already a correct answer, deselect that answer, and choose the one that was just clicked.
        
    }

    public void FinalizeMCQuestion()
    {
        // create new MultipleChoiceQuestion
        // collect the prompt from the relevant text field
        // 
    }

    #endregion

    // TODO: link the multiple choice question creation fields to this class. 
    // TODO: make the add question button create a new question for the test's question list, and make it show up in the question list.  
}
