﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace VacancyStore.Website.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-1.*"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryui")
                .Include("~/Scripts/jquery-ui-1.*"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/modernizr-*"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                .Include("~/Scripts/bootstrap*"));
            //bundles.Add(new ScriptBundle("~/bundles/common")
            //    .Include("~/Scripts/common.js"));

            bundles.Add(new StyleBundle("~/Content/css/jqueryui")
                .Include("~/Content/themes/jquery-ui*"));
            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/bootstrap*"));
            bundles.Add(new StyleBundle("~/Content/site")
                .Include("~/Content/Site*"));
        }
    }
}