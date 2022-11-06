let heros = [
  { id: 1, name: "Hanabi", specialization: "Marksman" },
  { id: 2, name: "Zilong", specialization: "Fighter" },
  { id: 3, name: "Haylos", specialization: "Tank" },
  { id: 4, name: "Hayabusa", specialization: "Assasin" },
  { id: 5, name: "Valir", specialization: "Mage" },
];

//  __________________________________________________________________________

// here callback is used to call the display heros function after 1 sec delay
// callback is conventional name , any name is fine.
// "I will call back later!"
// A callback is a function passed as an argument to another function
// This technique allows a function to call another function
// A callback function can run after another function has finished

// https://developer.mozilla.org/en-US/docs/Glossary/Callback_function


// ____________________________________________________________________________



function insertIntoHeros(callback) {
  setTimeout(() => {
    heros.push({ id: 6, name: "Lesely", specialization: "Marksman" });
		callback();
  }, 1000);

}

// _____________________________________________________________________________

function displayHeros() {
  let tableID = document.getElementById("tbody");

  heros.forEach((hero) => {
    tableID.innerHTML += `
        
      <tr> 
      <td>${hero.id} </td>
      <td>${hero.name} </td>
      <td>${hero.specialization}</td>
      </tr>
        
      `;
  });
}

// _____________________________________________________________________________

insertIntoHeros(displayHeros);
