﻿namespace AngularLearning.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public BookCategory Category { get; set; }
    }
}