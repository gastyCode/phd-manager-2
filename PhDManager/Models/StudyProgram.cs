﻿namespace PhDManager.Models
{
    public class StudyProgram
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

        public virtual List<Subject> Subjects { get; set; }
        public virtual List<Thesis> Thesis { get; set; }
    }
}
