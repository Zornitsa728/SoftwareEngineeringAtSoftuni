function solve(data) {
    class Song {
        constructor(typeList, name, time) {
            this.typeList = typeList;
            this.name = name;
            this.time = time;
        }
    }

    let songsCount = data[0];
    let typeList = data[data.length - 1];
    let allSongs = [];

    for (let i = 1; i <= songsCount; i++) {
        let currSong = data[i].split('_');
        allSongs.push(new Song(currSong[0], currSong[1], currSong[2]));
    }

    if (typeList == 'all') {
        allSongs.forEach(song => {
            console.log(song.name);
        });
    } else {
        allSongs.forEach(song => {
            if (typeList == song.typeList) {
            console.log(song.name);
            }
        });
    }
}

solve([3,
    'favourite_DownTown_3:14',
    'favourite_Kiss_4:16',
    'favourite_Smooth Criminal_4:01',
    'favourite']
    );