﻿namespace EventsCodeFormatting
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int byDate = this.Date.CompareTo(other.Date);
            int byTitle = this.Title.CompareTo(other.Title);
            int byLocation = this.Location.CompareTo(other.Location);

            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                else
                {
                    return byTitle;
                }
            }
            else
            {
                return byDate;
            }
        }

        public override string ToString()
        {
            StringBuilder eventToString = new StringBuilder();

            eventToString.Append(this.Date.ToString("yyyy-MM-ddTHH:mm:ss"));
            eventToString.Append(" | " + this.Title);

            if (!string.IsNullOrEmpty(this.Location))
            {
                eventToString.Append(" | " + this.Location);
            }

            return eventToString.ToString();
        }
    }
}