﻿namespace MeetingApp.Models
{
    public class Meetinginfo
    {
        public int Id { get; set; }
        public string? Location { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfPeople { get; set; }
    }
}
