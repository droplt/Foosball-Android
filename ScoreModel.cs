﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Foosball_Android
{
    public class ScoreModel
    {
        public int id { get; set; }
        public int redTeamScore { get; set; }
        public int blueTeamScore { get; set; }

    }
}