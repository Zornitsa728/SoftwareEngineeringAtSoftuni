const baseUrl = 'http://localhost:3030/jsonstore/tasks';

const loadMealsElement = document.getElementById('load-meals');
const addMealElement = document.getElementById('add-meal');
const editMealElement = document.getElementById('edit-meal');
const mealListElement = document.getElementById('list');
const foodInputElement = document.getElementById('food');
const timeInputElement = document.getElementById('time');
const caloriesInputElement = document.getElementById('calories');

let currMealId = null;

const loadMeals = async () => {
    // fetch(baseUrl)
    // .then(response => response.json())
    // .then(data => console.log(data))
    // .catch(er => console.error(er))
    
    //fetch all meals (fetch is async function)
    const response = await fetch(baseUrl);
    const data = await response.json();

    //clear meal list element
    mealListElement.innerHTML = '';

    const meals = Object.values(data);
    //create meal element for each
    for (const meal of meals) {
        const changeButtonElement = document.createElement('button');
        changeButtonElement.textContent = 'Change';
        changeButtonElement.classList.add('change-meal');

        const deleteButtonElement = document.createElement('button');
        deleteButtonElement.textContent = 'Delete';
        deleteButtonElement.classList.add('delete-meal');

        const buttonContainerElement = document.createElement('div');
        buttonContainerElement.id = 'meal-buttons';
        buttonContainerElement.appendChild(changeButtonElement);
        buttonContainerElement.appendChild(deleteButtonElement);

        const foodElement = document.createElement('h2');
        foodElement.textContent = meal.food;
        const timeElement = document.createElement('h3');
        timeElement.textContent = meal.time;
        const caloriesElement = document.createElement('h3');
        caloriesElement.textContent = meal.calories;

        const mealElement = document.createElement('div');
        mealElement.classList.add('meal');
        mealElement.appendChild(foodElement);
        mealElement.appendChild(timeElement);
        mealElement.appendChild(caloriesElement);
        mealElement.appendChild(buttonContainerElement);

        // Attach meal to dom
        mealListElement.appendChild(mealElement);

        // Attach on change
        changeButtonElement.addEventListener('click', () => {
            currMealId = meal._id;

            //populate input
            foodInputElement.value = meal.food;
            timeInputElement.value = meal.time;
            caloriesInputElement.value = meal.calories;

            //activate edit button 
            editMealElement.removeAttribute('disabled');

            //deactivate add button
            addMealElement.setAttribute('disabled', 'disabled');

            // remove from list
            mealElement.remove();
        })

        // Attach on delete
        deleteButtonElement.addEventListener('click', async () => {
            //delete http request
            const response = await fetch(`${baseUrl}/${meal._id}`, {
                method: 'DELETE'
            });

            //remove from list
            mealElement.remove();
        })
    }
};

loadMealsElement.addEventListener('click', loadMeals);

editMealElement.addEventListener('click', async () => {
    //get data from inputs
    const foodInput = foodInputElement.value;
    const timeInput = timeInputElement.value;
    const caloriesInput = caloriesInputElement.value;

    // put request
    const response = await fetch(`${baseUrl}/${currMealId}`, {
        method: 'PUT',
        headers: {
            'content-type': 'application/json',
        },
        body: JSON.stringify({
            _id: currMealId,
            food: foodInput,
            time: timeInput,
            calories: caloriesInput,
        })
    });

    if (!response.ok) {
        return;
    }

    //load meals 
    loadMeals();

    // deactivate edit button
    editMealElement.setAttribute('disabled', 'disabled');

    //activate add button
    addMealElement.removeAttribute('disabled');

    // clear currMealId
    currMealId = null;
})

addMealElement.addEventListener('click', async () => {
    // get input data
    const food = foodInputElement.value;
    const time = timeInputElement.value;
    const calories = caloriesInputElement.value;

    // create post request 
    const response = await fetch(baseUrl, {
        method: 'Post',
        headers: {
            'content-type': 'application/json'
        },
        body: JSON.stringify({ food, time, calories }),
    });

    if (!response.ok) {
        return;
    }
    
    //clear input fields
    foodInputElement.value = '';
    timeInputElement.value = '';
    caloriesInputElement.value = '';
    
    // load all meals
    await loadMeals();

})