using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SkateboardSchool.Domain;
using SkateboardSchool.DAL;

namespace SkateboardSchoolApp.Activities
{
    [Activity(Label = "StudentsListActivity")]
    public class StudentsListActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.StudentsList);

            TextView title = FindViewById<TextView>(Resource.Id.title);
            ListView listView = FindViewById<ListView>(Resource.Id.listView1);
            
            var studentRepository = new StudentRepository();
            var list = studentRepository.GetStudentProfiles().Select(s => s.PersonalData.FirstName).ToList();

            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, list);
            listView.Adapter = adapter;
        }
    }
}