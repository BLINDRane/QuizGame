using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.IO;
using Newtonsoft.Json;

public class CanvasCommuner : MonoBehaviour
{
    // Canvas Token:
    // 2855~cO3Ra4GfzoW6r0k0gc825MoO9JPLaU1alSLaTKKuDJc8SDIdJpXVR4xWfX8tQcsr

    // prefix all Canvas requests with https://wasatch.instructure.com to find the right course

    // note that Canvas course IDs can be found in the URL of a course when you are viewing it in browser

    // how to pull all quizzes from a given course
    // GET /api/v1/courses/:course_id/quizzes

    // how to pull all questions down from a given quiz
    // GET /api/v1/courses/:course_id/quizzes/:quiz_id/questions

    public List<CanvasCourse> courses;

    void Start()
    {
        // TODO: Allow user choice
        // fetch list of user's classes
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://wasatch.instructure.com/api/v1/courses?access_token=2855~cO3Ra4GfzoW6r0k0gc825MoO9JPLaU1alSLaTKKuDJc8SDIdJpXVR4xWfX8tQcsr");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        StreamReader reader = new StreamReader(response.GetResponseStream());

        // store the response as a string
        string json = reader.ReadToEnd();

        courses = JsonConvert.DeserializeObject<List<CanvasCourse>>(json);

        reader.Close();
    }

    public List<CanvasQuiz> GetQuizzesByCourse(int courseID)
    {
        // fetch a list of quizzes for chosen class
        HttpWebRequest request =

            (HttpWebRequest)WebRequest.Create("https://wasatch.instructure.com/api/v1/courses/" 
            + courseID + 
            "/quizzes?access_token=2855~cO3Ra4GfzoW6r0k0gc825MoO9JPLaU1alSLaTKKuDJc8SDIdJpXVR4xWfX8tQcsr");

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        StreamReader reader = new StreamReader(response.GetResponseStream());

        // store the response as a string
        string json = reader.ReadToEnd();

        reader.Close();

        return JsonConvert.DeserializeObject<List<CanvasQuiz>>(json);
    }

    public List<CanvasQuizQuestion> GetQuizQuestions(int quizId)
    {
        // fetch a list of questions for chosen quiz
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://wasatch.instructure.com//api/v1/courses/31761/quizzes/"
            + quizId + 
            "/questions?access_token=2855~cO3Ra4GfzoW6r0k0gc825MoO9JPLaU1alSLaTKKuDJc8SDIdJpXVR4xWfX8tQcsr");

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        StreamReader reader = new StreamReader(response.GetResponseStream());

        string json = reader.ReadToEnd();

        reader.Close();

        return JsonConvert.DeserializeObject<List<CanvasQuizQuestion>>(json);

        
    }

}
