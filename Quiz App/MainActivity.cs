using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Quiz_App.Activities;
using Android.Content;

namespace Quiz_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity
    {

        // Creating Toolbar instance 
        Android.Support.V7.Widget.Toolbar toolbar;

        // Creating Layout instance
        LinearLayout historyLayout;
        LinearLayout spaceLayout;
        LinearLayout geographyLayout;
        LinearLayout programmingLayout;
        LinearLayout businessLayout;
        LinearLayout engineeringLayout;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            toolbar = (Android.Support.V7.Widget.Toolbar)FindViewById(Resource.Id.toolbar);
            //Setup Toolbar

            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Topics";
            Android.Support.V7.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Resource.Drawable.menuaction);
            actionBar.SetDisplayHomeAsUpEnabled(true);


            // View Setup
            historyLayout = (LinearLayout)FindViewById(Resource.Id.historyLayout);
            spaceLayout = (LinearLayout)FindViewById(Resource.Id.spaceLayout);
            geographyLayout = (LinearLayout)FindViewById(Resource.Id.geographyLayout);
            programmingLayout = (LinearLayout)FindViewById(Resource.Id.programmingLayout);
            businessLayout = (LinearLayout)FindViewById(Resource.Id.businessLayout);
            engineeringLayout = (LinearLayout)FindViewById(Resource.Id.engineeringLayout);


       

            // Click Event Handlers

            historyLayout.Click += HistoryLayout_Click;
            geographyLayout.Click += GeographyLayout_Click;
            spaceLayout.Click += SpaceLayout_Click;
            programmingLayout.Click += ProgrammingLayout_Click;
            businessLayout.Click += BusinessLayout_Click;
            engineeringLayout.Click += EngineeringLayout_Click;


        }

        private void EngineeringLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("Topic", "Engineering");
            StartActivity(intent);
        }

        private void BusinessLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("Topic", "Business");
            StartActivity(intent);
        }

        private void ProgrammingLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("Topic", "Programming");
            StartActivity(intent);
        }

        private void SpaceLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("Topic", "Space");
            StartActivity(intent);
        }

        private void GeographyLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("Topic", "Geography");
            StartActivity(intent);
        }

        private void HistoryLayout_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("Topic", "History");
            StartActivity(intent);


        }
    }
}