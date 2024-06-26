﻿namespace MoviesGalleryAPI.Services;

public interface IMoviesService
{
    Task<ServiceResponse<List<GetMovieDto>>> GetAllMovies();
    Task<ServiceResponse<GetMovieDto>> GetMovieById(int id);
    Task<ServiceResponse<List<GetMovieDto>>> GetMovieByPartialName(string partialName);
    Task<ServiceResponse<List<GetMovieDto>>> AddMovie(AddMovieDto newMovie);
    Task<ServiceResponse<GetMovieDto>> UpdateMovie(UpdateMovieDto updatedMovie);
    Task<ServiceResponse<List<GetMovieDto>>> DeleteMovie(int id);
}
