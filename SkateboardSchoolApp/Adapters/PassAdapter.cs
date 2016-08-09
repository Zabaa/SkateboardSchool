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

namespace SkateboardSchoolApp.Adapters
{
    public class PassAdapter : BaseAdapter<Pass>
    {
        private readonly Activity _activity;

        public IList<Pass> PassesList { get; set; }

        public override Pass this[int position]
        {
            get { return PassesList[position]; }
        }

        public override int Count
        {
            get { return PassesList.Count(); }
        }

        public PassAdapter(Activity activity, List<Pass> newPasses) : base ()
		{
            _activity = activity;
            PassesList = newPasses;
        }

        public override long GetItemId(int position)
        {
            throw new NotImplementedException();
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View newView = convertView;
            if (newView == null)
                newView = _activity.LayoutInflater.Inflate(Resource.Layout.PassListItem, null);

            newView.FindViewById<TextView>(Resource.Id.TrickName).Text = PassesList[position].Trick.Name;
            newView.FindViewById<TextView>(Resource.Id.PassDate).Text = PassesList[position].Date.ToShortDateString();
            return newView;
        }
    }
}