﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SkateboardSchool.DAL;
using SkateboardSchoolApp.Activities;

namespace SkateboardSchoolApp
{
    [Activity(Label = "SkateboardSchoolApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(PassesListActivity));
                StartActivity(intent);
            };
        }
    }
}

