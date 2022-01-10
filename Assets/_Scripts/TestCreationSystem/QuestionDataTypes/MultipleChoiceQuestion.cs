using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleChoiceQuestion : Question
{
    // Necessary data to formulate a multiple choice question.

    // The actual "question". 
    private string prompt;

    // List of possible answers as strings (maybe use a map for fast lookup?).
    private List<string> possibleAnswers;

    // Index of correct answer.
    private int correctAnswer;

    // Currently selected index (user answer).
    private int selectedIndex;

    MultipleChoiceQuestion(string prompt, List<string> possibleAnswers, int correctAnswer)
    {
        this.prompt = prompt;
        this.possibleAnswers = possibleAnswers;
        this.correctAnswer = correctAnswer;
    }

    public override bool CheckAnswer()
    {
        if (selectedIndex == correctAnswer)
        {
            return true;
        }

        return false;
    }

    public void SelectIndex(int index)
    {
        selectedIndex = index;
    }

    public void AddAnswer(string answer)
    {
        possibleAnswers.Add(answer);
    }

    public void RemoveAnswer(string answer)
    {
        possibleAnswers.Remove(answer);
    }

    public int GetAnswerCount()
    {
        return possibleAnswers.Count;
    }
}
