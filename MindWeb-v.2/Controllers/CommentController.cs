using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Web.Mvc;

namespace MindWeb_v._2.Controllers
{
    public class CommentController : SurfaceController
    {
        // Put: Comment
        public ActionResult CreateComment(int id)
        {
            // Get the Umbraco Content Service
            var contentService = Services.ContentService;
            var comment = contentService.CreateContent(
                "commentTest", // the name of the product
                id, // the parent id should be the id of the group node 
                "blogComment", // the alias of the product Document Type
                0);

            // We need to update properties (product id, original name and the price)
            comment.SetValue("commentDate", DateTime.Now);

            // finally we need to save and publish it (which also saves the product!)
            // - that's done via the Content Service
            contentService.SaveAndPublish(comment);

            return null;
        }
    }
}