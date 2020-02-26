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

namespace Quiz_App.Activities
{
    [Activity(Label = "QuizDescriptionActivity", Theme ="@style/AppTheme" )]
    public class QuizDescriptionActivity : AppCompatActivity
    {

        // Creating Instance from Selected Topic View
        TextView quizTopicTextView;
        TextView descriptionTextView;
        ImageView quizImageView;
        Button startQuizButton;

        // Variables
       string quizTopic;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.selected_topic);

            // Selected Topic Setup

            quizTopicTextView = (TextView)FindViewById(Resource.Id.quizTopicText);
            descriptionTextView = (TextView)FindViewById(Resource.Id.quizDescriptionText);
            quizImageView = (ImageView)FindViewById(Resource.Id.quizImage);
            startQuizButton = (Button)FindViewById(Resource.Id.startQuizButton);

            quizTopic = Intent.GetStringExtra("Topic");
            quizTopicTextView.Text = quizTopic;
            quizImageView.SetImageResource(GetImage(quizTopic));

        }

        // Getting Images from Drawable

        int GetImage(string topic)
        {
            int imageInt = 0;

            if(topic == "History")
            {
                imageInt = Resource.Drawable.history;
            }
            else if(topic == "Geography")
            {
                imageInt = Resource.Drawable.geography;
            }
            else if (topic == "Space")
            {
                imageInt = Resource.Drawable.space;
            }
            else if (topic == "Programming")
            {
                imageInt = Resource.Drawable.programming;
            }
            else if (topic == "Business")
            {
                imageInt = Resource.Drawable.business;
            }
            else if (topic == "Engineering")
            {
                imageInt = Resource.Drawable.engineering;
            }

            return imageInt;
        }
    }
}