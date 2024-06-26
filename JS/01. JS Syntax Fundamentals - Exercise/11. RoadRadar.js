function roadRadar(speed, area) {
    let overSpeed = false;
    let speedLimit = 0;

    if (area === 'residential') {
        speedLimit = 20;

        if (speed > 20) {
            overSpeed = true;
        }
    } else if (area === 'city') {
        speedLimit = 50;

        if (speed > 50) {
            overSpeed = true;
        }
    } else if (area === 'interstate') {
        speedLimit = 90;

        if (speed > 90) {
            overSpeed = true;
        }
    } else if (area === 'motorway') {
        speedLimit = 130;

        if (speed > 130) {
            overSpeed = true;
        }
    }

    if (!overSpeed) {
        console.log(`Driving ${speed} km/h in a ${speedLimit} zone`);
    } else {
        let difference = speed - speedLimit;
        let status = '';

        if (difference <= 20) {
            status = 'speeding';
        } else if (difference <= 40) {
            status = 'excessive speeding';
        } else {
            status = 'reckless driving';
        }

        console.log(`The speed is ${difference} km/h faster than the allowed speed of ${speedLimit} - ${status}`);
    }
}

roadRadar(200, 'motorway');