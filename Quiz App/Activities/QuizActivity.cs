using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Quiz_App.Data_Models;
using Quiz_App.Helpers;

namespace Quiz_App.Activities
{
    [Activity(Label = "QuizActivity")]
    public class QuizActivity : AppCompatActivity
    {
        Android.Support.V7.Widget.Toolbar toolbar;
       

        /// <summary>
        /// Creating instance from Quiz Page XML
        /// </summary>

        // Instance of RadioButton
        RadioButton optionARadio, optionBRadio, optionCRadio, optionDRadio;
        // Instance of TextViews
        TextView optionATextView, optionBTextView, optionCTextView, optionDTextView, questionTextView, questionPositionTextView, timeCounterTextView;
        // Instance of Button 
        Button proceedQuizButton;
        // Variables
        List<Question> quizQuestionList = new List<Question>();
        QuizHelper quizHelper = new QuizHelper();
        string quizTopic;
        int quizPosition;




        protected override void OnCreate(Bundle savedInstanceState)
        {

            
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.quiz_page);

            quizTopic = Intent.GetStringExtra("Topic");

            // Creating a toolbar 

            toolbar = (Android.Support.V7.Widget.Toolbar)FindViewById(Resource.Id.quiztoolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = quizTopic + " Quiz";

            Android.Support.V7.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Resource.Drawable.outline_arrowback);
            actionBar.SetDisplayHomeAsUpEnabled(true);
            connectViews();
            BeginQuiz();



        }

        /// <summary>
        /// Creating views to connect instances from Quiz Page XML
        /// </summary>
        void connectViews()
        {

            // Radio Buttons
            optionARadio = (RadioButton)FindViewById(Resource.Id.optionARadio);
            optionBRadio = (RadioButton)FindViewById(Resource.Id.optionARadio);
            optionCRadio = (RadioButton)FindViewById(Resource.Id.optionARadio);
            optionDRadio = (RadioButton)FindViewById(Resource.Id.optionARadio);

            // Text Views

            optionATextView = (TextView)FindViewById(Resource.Id.optionATextView);
            optionBTextView = (TextView)FindViewById(Resource.Id.optionBTextView);
            optionCTextView = (TextView)FindViewById(Resource.Id.optionCTextView);
            optionDTextView = (TextView)FindViewById(Resource.Id.optionDTextView);
            questionTextView = (TextView)FindViewById(Resource.Id.questionTextView);
            questionPositionTextView = (TextView)FindViewById(Resource.Id.quizPositionTextView);
            timeCounterTextView = (TextView)FindViewById(Resource.Id.timeCounterTextView);


            // Button
            proceedQuizButton = (Button)FindViewById(Resource.Id.proceedQuizButton);
        }

        void BeginQuiz()
        {
            quizPosition = 1;
            quizQuestionList = quizHelper.GetQuizQuestions(quizTopic);
            questionTextView.Text = quizQuestionList[0].QuizQuestion;
            optionATextView.Text = quizQuestionList[0].OptionA;
            optionBTextView.Text = quizQuestionList[0].OptionB;
            optionCTextView.Text = quizQuestionList[0].OptionC;
            optionDTextView.Text = quizQuestionList[0].OptionD;

            questionPositionTextView.Text = "Question " + quizPosition.ToString() + "/" + quizQuestionList.Count();

        }
    }
}