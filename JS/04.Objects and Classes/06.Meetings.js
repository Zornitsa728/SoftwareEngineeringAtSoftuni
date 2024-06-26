function meetings(tokens) {
    let successfulMeetings = {};

    for (const meeting of tokens) {
        let currMeeting = meeting.split(' ');

        if (Object.keys(successfulMeetings).includes(currMeeting[0])) {
            console.log(`Conflict on ${currMeeting[0]}!`)
        } else {
            console.log(`Scheduled for ${currMeeting[0]}`)
            successfulMeetings[currMeeting[0]] = currMeeting[1];
        }
    }

    for (const day in successfulMeetings) {
        console.log(`${day} -> ${successfulMeetings[day]}`)
    }
}

meetings(['Monday Peter',
'Wednesday Bill',
'Monday Tim',
'Friday Tim']
);