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

namespace Quiz_App.Helpers
{
   public class QuizHelper
    {
        public string GetTopicDescription(string topic)
        {
            string topicDescription = "";
            if (topic == "History")
            {
                topicDescription = "History is the study of the past as it is described in written documents. " +
                    "Events occurring before written record are considered prehistory. It is an " +
                    "umbrella term that relates to past events as well as the memory, discovery, " +
                    "collection, organization, presentation, and interpretation of information about these events.";

            }
            else if (topic == "Space")
            {
                topicDescription = "The concept of space is considered to be of fundamental importance to an understanding of the physical universe. However, " +
                    "disagreement continues between philosophers over whether it is itself an" +
                    " entity, a relationship between entities, or part of a conceptual framework.";
            }
            else if (topic == "Geography")
            {
                topicDescription = "Geography is the study of places and the relationships between people and " +
                    "their environments. Geographers explore both the physical properties" +
                    " of Earth's surface and the human societies spread across it.";
            }


            return topicDescription;
        }
    }
}