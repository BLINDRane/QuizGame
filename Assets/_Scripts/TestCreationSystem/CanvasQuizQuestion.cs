using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
public class Answer
{
    public int weight { get; set; }
    public string migration_id { get; set; }
    public int id { get; set; }
    public string text { get; set; }
}

public class CanvasQuizQuestion
{
    public int quiz_id { get; set; }
    public int id { get; set; }
    public object quiz_group_id { get; set; }
    public int? assessment_question_id { get; set; }
    public int position { get; set; }
    public string question_name { get; set; }
    public string question_type { get; set; }
    public string question_text { get; set; }
    public double points_possible { get; set; }
    public string correct_comments { get; set; }
    public string incorrect_comments { get; set; }
    public object neutral_comments { get; set; }
    public object correct_comments_html { get; set; }
    public object incorrect_comments_html { get; set; }
    public object neutral_comments_html { get; set; }
    public List<Answer> answers { get; set; }
    public object variables { get; set; }
    public object formulas { get; set; }
    public object answer_tolerance { get; set; }
    public object formula_decimal_places { get; set; }
    public object matches { get; set; }
    public object matching_answer_incorrect_matches { get; set; }
}
