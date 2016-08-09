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
using Java.Lang;
using SkateboardSchool.Domain;
using SkateboardSchool.Domain.Enums;

namespace SkateboardSchoolApp.Adapters
{
    public class PassesExpandableListAdapter : BaseExpandableListAdapter
    {
        private readonly Activity _activity;

        public IList<Pass> PassesList { get; set; }

        public override int GroupCount
        {
            get { return System.Enum.GetNames(typeof(SkillLevel)).Length; }
        }

        public override bool HasStableIds
        {
            get { return true; }
        }

        public PassesExpandableListAdapter(Activity activity, IList<Pass> passesList)
        {
            _activity = activity;
            PassesList = passesList;
        }

        public override Java.Lang.Object GetChild(int groupPosition, int childPosition)
        {
            return null;
        }

        public override long GetChildId(int groupPosition, int childPosition)
        {
            return childPosition;
        }

        public override int GetChildrenCount(int groupPosition)
        {
            return 5;
        }

        public override Java.Lang.Object GetGroup(int groupPosition)
        {
            throw new NotImplementedException();
        }

        public override long GetGroupId(int groupPosition)
        {
            throw new NotImplementedException();
        }

        public override View GetGroupView(int groupPosition, bool isExpanded, View convertView, ViewGroup parent)
        {
            View header = convertView;
            if (header == null)
            {
                header = _activity.LayoutInflater.Inflate(Resource.Layout.PassListGroup, null);
            }

            string groupName = System.Enum.GetNames(typeof(SkillLevel))[groupPosition];
            header.FindViewById<TextView>(Resource.Id.DataHeader).Text = groupName;

            return header;
        }

        public override View GetChildView(int groupPosition, int childPosition, bool isLastChild, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = _activity.LayoutInflater.Inflate(Resource.Layout.PassListItem, null);
            }

            var skillLevel = (SkillLevel)groupPosition;
            var rookie1List = PassesList.Where(p => p.Trick.SkillLevel == skillLevel).ToList();

            row.FindViewById<TextView>(Resource.Id.TrickName).Text = rookie1List[childPosition].Trick.Name;
            row.FindViewById<TextView>(Resource.Id.PassDate).Text = rookie1List[childPosition].Date.ToShortDateString();

            return row;
        }

        public override bool IsChildSelectable(int groupPosition, int childPosition)
        {
            return true;
        }
    }
}