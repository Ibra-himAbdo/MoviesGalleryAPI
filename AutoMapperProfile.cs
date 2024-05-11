﻿namespace MoviesGalleryAPI;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Movie, GetMovieDto>();
        CreateMap<AddMovieDto, Movie>();
        CreateMap<UpdateMovieDto, Movie>();
    }
}