function solve(input) {
    const allMovies = [];

    for (const row of input) {
        let currMovie = [];

        const movieInfo = {};

        if (row.includes('addMovie')) {
            const [movieName] = row.split('addMovie ').filter(item => item !== '');
            movieInfo.name = movieName;
            allMovies.push(movieInfo);

        } else if (row.includes('directedBy')) {
            const [movieName, director] = row.split(' directedBy ').filter(item => item !== '');
            const movie = allMovies.find(movie => movie.name === movieName);
            if (movie) {
                movie.director = director;
            }

        } else if (row.includes('onDate')) {
            const [movieName, date] = row.split(' onDate ').filter(item => item !== '');
            const movie = allMovies.find(movie => movie.name === movieName);
            if (movie) {
                movie.date = date;
            }
        }
    }

    allMovies
        .filter(film => film.name && film.date && film.director)
        .forEach(element => console.log(JSON.stringify(element)));
}

solve([
    'addMovie Fast and Furious',
    'addMovie Godfather',
    'Inception directedBy Christopher Nolan',
    'Godfather directedBy Francis Ford Coppola',
    'Godfather onDate 29.07.2018',
    'Fast and Furious onDate 30.07.2018',
    'Batman onDate 01.08.2018',
    'Fast and Furious directedBy Rob Cohen'
]
);

solve([
    'addMovie The Avengers',
    'addMovie Superman',
    'The Avengers directedBy Anthony Russo',
    'The Avengers onDate 30.07.2010',
    'Captain America onDate 30.07.2010',
    'Captain America directedBy Joe Russo'
]
);