﻿namespace Twitter.Web.Controllers
{
    using System.Web.Mvc;
    using ViewModels.Tweet;

    public class TweetController : Controller
    {
        // GET: Tweet
        public ActionResult Create(CreateTweetViewModel model)
        {
            if (this.ModelState.IsValid)
            {
            }

            return this.View("_CreateTweetPartial", model);
        }
    }
}