function smallestNum(...nums) {
    nums.sort((a, b) => a - b);

    console.log(nums[0]);
}

smallestNum(600,
    342,
    123
    );