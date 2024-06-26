﻿namespace MoviesGalleryAPI.Dtos
{
    public class AddMovieDto
    {
        public string? Title { get; set; }
        public int Year { get; set; }
        public string[]? Genre { get; set; }
        public float Rating { get; set; }
        public string? Director { get; set; }
        public string[]? Actors { get; set; }
        public string? Plot { get; set; }
        public IFormFile? PosterFile { get; set; }
        public string? Trailer { get; set; }
    }
}
