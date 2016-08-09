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
using SkateboardSchool.DAL.Repository;

namespace SkateboardSchoolApp.Activities
{
    [Activity(Label = "PassesListActivity")]
    public class PassesListActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PassesList);

            var passesRepository = new PassesRepository();
            var list = passesRepository.GetPasses().Select(p => p.Trick.Name).ToList();

            ExpandableListView listView = FindViewById<ExpandableListView>(Resource.Id.passesList);
            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, list);

        }
    }
}