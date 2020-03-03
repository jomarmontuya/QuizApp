using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Quiz_App.Activities;
using Android.Content;
using Android.Views;
using Android.Support.Design.Widget;


namespace Quiz_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainActivity : AppCompatActivity

    {

        // Creating Toolbar instance 
        Android.Support.V7.Widget.Toolbar toolbar;

        // Creatin Navigation Drawer Instance
        Android.Support.V4.Widget.DrawerLayout drawerLayout;
        Android.Support.Design.Widget.NavigationView navigationView;


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
            drawerLayout = (Android.Support.V4.Widget.DrawerLayout)FindViewById(Resource.Id.drawerLayout);
            navigationView = (Android.Support.Design.Widget.NavigationView)FindViewById(Resource.Id.navView);
            navigationView.NavigationItemSelected += NavigationView_NavigationItemSelected;


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

        private void NavigationView_NavigationItemSelected(object sender, NavigationView.NavigationItemSelectedEventArgs e)
        {
            // Conditional to test what has been clicked on the navigation drawer
            if (e.MenuItem.ItemId == Resource.Id.navHistory)
            {
                InitHistory();
                drawerLayout.CloseDrawers();
            }
            else if (e.MenuItem.ItemId == Resource.Id.navGeography)
            {
                InitGeography();
                drawerLayout.CloseDrawers();
            }
            else if (e.MenuItem.ItemId == Resource.Id.navBusiness)
            {
                InitBusiness();
                drawerLayout.CloseDrawers();
            }
            else if (e.MenuItem.ItemId == Resource.Id.navSpace)
            {
                InitSpace();
                drawerLayout.CloseDrawers();
            }
            else if (e.MenuItem.ItemId == Resource.Id.navEngineering)
            {
                InitEngineering();
                drawerLayout.CloseDrawers();
            }
            else if (e.MenuItem.ItemId == Resource.Id.navProgramming)
            {
                InitProgramming();
                drawerLayout.CloseDrawers();
            }


        }




        private void EngineeringLayout_Click(object sender, System.EventArgs e)
        {

            InitEngineering();
        }

        private void BusinessLayout_Click(object sender, System.EventArgs e)
        {
            InitBusiness();
        }

        private void ProgrammingLayout_Click(object sender, System.EventArgs e)
        {
            InitProgramming();
        }

        private void SpaceLayout_Click(object sender, System.EventArgs e)
        {
            InitSpace();
        }

        private void GeographyLayout_Click(object sender, System.EventArgs e)
        {
            InitGeography();
        }

        private void HistoryLayout_Click(object sender, System.EventArgs e)
        {
            InitHistory();
        }


        /// <summary>
        /// Create method to avoid repetition of codes
        /// </summary>
        void InitHistory()
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("Topic", "History");
            StartActivity(intent);
        }
        void InitGeography()
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("Topic", "Geography");
            StartActivity(intent);
        }
        void InitSpace()
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("Topic", "Space");
            StartActivity(intent);
        }
        void InitProgramming()
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("Topic", "Programming");
            StartActivity(intent);
        }
        void InitBusiness()
        {
            Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
            intent.PutExtra("Topic", "Business");
            StartActivity(intent);
        }
        void InitEngineering()
            {
                Intent intent = new Intent(this, typeof(QuizDescriptionActivity));
                intent.PutExtra("Topic", "Engineering");
                StartActivity(intent);
            }
        


        /// <summary>
        /// Close the navigation drawer when the home page click
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    drawerLayout.OpenDrawer((int)GravityFlags.Left);
                    return true;

                default:
                    return base.OnOptionsItemSelected(item);
            }

        }




    }
}