﻿namespace Tasks.Models
{
    public sealed class AndroidNotification
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string AppName { get; set; }
        public string PackageName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
